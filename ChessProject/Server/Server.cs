using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using MailKit.Net;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net;
using System.Net.Mail;


namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }


        #region NHẬN, GỬI DỮ LIỆU ĐI

        byte[] recvBuffer = new byte[300];
        Socket listenSock;
        Socket recvSock;

        private void btnListen_Click(object sender, EventArgs e)
        {
            listenSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenSock.Bind(new IPEndPoint(IPAddress.Any, 1234));
            listenSock.Listen(10);
            listenSock.BeginAccept(listenCallBack, listenSock);

            btnListen.Enabled = false;
        }
        private void listenCallBack(IAsyncResult ar)
        {
            recvSock = listenSock.EndAccept(ar);
            recvSock.BeginReceive(recvBuffer, 0, 0, SocketFlags.None, recvCallBack, recvSock);
            listenSock.BeginAccept(recvCallBack, listenSock);
        }
        private void recvCallBack(IAsyncResult ar)
        {
            recvSock.Receive(recvBuffer, 0, recvBuffer.Length, SocketFlags.None);

            byte[] recvData = new byte[300];
            byte[] sendData;
            string[] stringArr;
            string stringData="";

            switch (recvBuffer[1])
            {
                case 1:
                    {
                        sendData = new byte[30];
                        List<byte> fullPackage = new List<byte>();
                        string email = Encoding.UTF8.GetString(recvBuffer, 2, recvBuffer.Length - 2).Trim();
                        string randomCode = RandomString(5, true);
                        username += " " + randomCode;
                        if (checkMail(email, randomCode))
                        {

                            fullPackage.Add(1);
                            fullPackage.AddRange(Encoding.UTF8.GetBytes(username));
                        }
                        else
                        {
                            fullPackage.Add(0);
                        }
                        recvSock.Send(fullPackage.ToArray());
                        break;
                    }
                case 2:
                    break;
                case 3:
                    {
                        sendData = new byte[1];
                        stringData = Encoding.UTF8.GetString(recvBuffer, 2, recvBuffer.Length - 2).Trim();
                        stringArr = stringData.Split(' ');
                        if (NewPass(stringArr[0], stringArr[1]))
                        {
                            sendData[0] = 1;
                        }
                        recvSock.Send(sendData);
                        break;
                    }
                case 4:
                    {
                        sendData = new byte[1];
                        stringData = Encoding.UTF8.GetString(recvBuffer, 2, recvBuffer.Length - 2).Trim();
                        stringArr = stringData.Split(' ');
                        if (SignIn(stringArr[0], stringArr[1]))
                            sendData[0] = 1;
                        recvSock.Send(sendData);
                        break;
                    }
                case 5:
                    break;
                case 6:
                    {
                        sendData = new byte[1];
                        stringData = Encoding.UTF8.GetString(recvBuffer, 2, recvBuffer.Length - 2).Trim();
                        stringArr = stringData.Split(' ');
                        if (SignUp(stringArr))
                            sendData[0] = 1;
                        recvSock.Send(sendData);
                        break;
                    }
                case 7:
                    {
                        stringData = Encoding.UTF8.GetString(recvBuffer, 2, recvBuffer.Length - 2).Trim();
                        string[] RankList = Rank(stringData);
                        stringData = RankList[0] + ' ' + RankList[1] + ' '
                                    + RankList[2] + ' ' + RankList[3] + ' '
                                    + RankList[4] + ' ' + RankList[5] + ' '
                                    + RankList[6] + ' ' + RankList[7] + ' ' + RankList[8];
                        recvSock.Send(Encoding.UTF8.GetBytes(stringData));
                    }
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 0:
                    break;
            }

            recvBuffer = new byte[300];
            recvSock.BeginReceive(recvBuffer, 0, 0, SocketFlags.None, recvCallBack, recvSock);

        }

        #endregion

        #region CÁC HÀM TRUY XUẤT SQL 

        public string username = "";
        //01
        private bool checkMail(string inputGmail,string code)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=123321;";

            string sql = "SELECT TENND FROM NGUOIDUNG WHERE EMAIL=@mail ";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sc = new SqlCommand(sql, con);
            sc.Parameters.AddWithValue("@mail", inputGmail);
            SqlDataReader sqlReader = sc.ExecuteReader();

            bool kq = sqlReader.HasRows;
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    username = sqlReader.GetString(0); // biến toàn cục để lưu username để sd khi cần
                    
                    // viết hàm tạo mã và gửi về gmail tại đây

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("", "chessappnt106@gmail.com"));
                    message.To.Add(new MailboxAddress("", inputGmail));
                    message.Subject = "Mã xác nhận đổi tài khoản App Chess";
                    BodyBuilder bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Mã xác nhận là : " + code;
                    message.Body = bodyBuilder.ToMessageBody();
                    using (var client = new MailKit.Net.Smtp.SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("chessappnt106@gmail.com", "sonmatnoi1");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }

            }
            con.Dispose();
            sc.Dispose();
            sqlReader.Close();

            return kq;
        }

        //02
        private bool VerifyCode(string code)
        {
            //check if true

            //Generate random code

            return true;
        }

        //03
        private bool NewPass(string username, string newPass)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            string sql = "UPDATE NGUOIDUNG SET MATKHAU = @mk WHERE TENND = @ten";
            SqlCommand sc = new SqlCommand(sql, con);
            sc.Parameters.AddWithValue("@ten", username);
            sc.Parameters.AddWithValue("@mk", newPass);
            int row = sc.ExecuteNonQuery();

            con.Dispose();
            sc.Dispose();
            if (row == 0)
                return false;
            return true;


        }

        //04
        private bool SignIn(string username, string pass)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";

            string sql = "SELECT TENND FROM NGUOIDUNG WHERE TENND=@ten AND MATKHAU=@mk ";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sc = new SqlCommand(sql, con);
            sc.Parameters.AddWithValue("@ten", username);
            //pass = pass.Replace("", "/0");
            sc.Parameters.AddWithValue("@mk", pass);
            SqlDataReader sqlReader = sc.ExecuteReader();

            bool result = sqlReader.HasRows;
            con.Dispose();
            sc.Dispose();
            sqlReader.Close();

            return result;
        }

        //05
        private bool checkSignUp(string username, string inputGmail)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";

            string sql = "SELECT TENND FROM NGUOIDUNG WHERE TENND =@ten OR EMAIL=@mail ";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sc = new SqlCommand(sql, con);
            sc.Parameters.AddWithValue("@ten", username);
            sc.Parameters.AddWithValue("@mail", inputGmail);
            SqlDataReader sqlReader = sc.ExecuteReader();

            bool kq = sqlReader.HasRows;
            con.Dispose();
            sc.Dispose();
            sqlReader.Close();

            return kq;
        }

        //06
        private bool SignUp(string[] msg)
        {
            //msg[0]: username, msg[1]:pass, msg[2]:email
            if (checkSignUp(msg[0], msg[2]) == false)
            {
                string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";

                string sql = "INSERT INTO NGUOIDUNG(TENND,MATKHAU,EMAIL,DIEM) VALUES (@ten,@mk,@mail,0)";
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand sc = new SqlCommand(sql, con);
                sc.Parameters.AddWithValue("@ten", msg[0]);
                sc.Parameters.AddWithValue("@mk", msg[1]);
                sc.Parameters.AddWithValue("@mail", msg[2]);
                int row = sc.ExecuteNonQuery();

                con.Dispose();
                sc.Dispose();

                if (row == 0)
                    return false;
                return true;
            }
            return false;
        }

        //07
        private string[] Rank(string username)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";

            string sql = "SELECT TOP 3 DIEM, TENND FROM NGUOIDUNG ORDER BY DIEM DESC ";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sc = new SqlCommand(sql, con);
            SqlDataReader sqlReader = sc.ExecuteReader();

            string[] chuoi = new string[9];
            int i = 0;

            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    chuoi[i] = sqlReader.GetString(1);
                    i++;
                    chuoi[i] = sqlReader.GetInt64(0).ToString();
                    i++;
                }

            }
            con.Dispose();
            sc.Dispose();
            sqlReader.Close();

            string sql_user = "SELECT ROW_NUMBER() OVER (ORDER BY DIEM DESC) AS XEPHANG, TENND, DIEM FROM NGUOIDUNG";
            SqlConnection con1 = new SqlConnection(conn);
            con1.Open();
            SqlCommand sc1 = new SqlCommand(sql_user, con1);
            SqlDataReader sqlReader1 = sc1.ExecuteReader();
            if (sqlReader1.HasRows)
            {
                while (sqlReader1.Read())
                {
                    if (string.Equals(sqlReader1.GetString(1), username, StringComparison.OrdinalIgnoreCase))
                    {
                        chuoi[i] = sqlReader1.GetString(1);
                        i++;
                        chuoi[i] = sqlReader1.GetInt64(2).ToString();
                        i++;
                        chuoi[i] = sqlReader1.GetInt64(0).ToString();
                        break;
                    }

                }

            }
            con1.Dispose();
            sc1.Dispose();
            sqlReader1.Close();
            return chuoi;

        }

        //08
        private string[] getInfo(string username)
        {
            string[] info = new string[4];
            info[0] = getBattleCount(username).ToString(); //số trận
            info[1] = getCurrRank(username).ToString(); // hạng hiện tại
            info[2] = getBattleWinCount(username).ToString(); //số trận thắng
            info[3] = getWinRate(username).ToString() + "%"; //tỉ lệ thắng

            return info;

            //code chạy thử người dùng bất kỳ
            //string[] thongtin = getInfo("andinh");
            //MessageBox.Show(thongtin[0] + " " + thongtin[1] + " " + thongtin[2] + " " + thongtin[3]);
        }

        #endregion

        #region CHUYỂN TIẾP DỮ LIỆU ĐẾN CLIENT KHÁC
        //09
        private void PlayGame()
        {

        }

        //10
        private void Chat()
        {

        }

        #endregion

        #region CÁC HÀM PHỤ

        private readonly Random _random = new Random();
        private string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        private int getBattleCount(string username)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            string sql = "SELECT COUNT(MABC) FROM BANCHOI WHERE TENND = @ten";
            SqlCommand sc = new SqlCommand(sql, con);
            sc.Parameters.AddWithValue("@ten", username);
            SqlDataReader sqlReader = sc.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    return sqlReader.GetInt32(0);
                }

            }
            con.Dispose();
            sc.Dispose();
            sqlReader.Close();
            return 0;
        }

        private int getBattleWinCount(string username)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            string sql = "SELECT COUNT(MABC) FROM BANCHOI WHERE TENND = @ten AND KQUA=2";
            SqlCommand sc = new SqlCommand(sql, con);
            sc.Parameters.AddWithValue("@ten", username);
            SqlDataReader sqlReader = sc.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    return sqlReader.GetInt32(0);
                }

            }
            con.Dispose();
            sc.Dispose();
            sqlReader.Close();
            return 0;
        }

        private int getBattleDrawCount(string username)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            string sql = "SELECT COUNT(MABC) FROM BANCHOI WHERE TENND = @ten AND KQUA=1";
            SqlCommand sc = new SqlCommand(sql, con);
            sc.Parameters.AddWithValue("@ten", username);
            SqlDataReader sqlReader = sc.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    return sqlReader.GetInt32(0);
                }

            }
            con.Dispose();
            sc.Dispose();
            sqlReader.Close();
            return 0;
        }

        private double getWinRate(string username)
        {
            int win = getBattleWinCount(username);
            int draw = getBattleDrawCount(username);
            int battle = getBattleCount(username);

            double rate = (win + draw * 0.5) * 100.0 / battle;
            rate = Math.Round(rate, 1);
            return rate;
        }

        private int getCurrRank(string username)
        {
            string conn = "Data Source=TRANGKYANH\\SQLEXPRESS;Initial Catalog=QLCOVUA;User id=sa;password=sa;";

            string sql_user = "SELECT ROW_NUMBER() OVER (ORDER BY DIEM DESC) AS XEPHANG, TENND FROM NGUOIDUNG";
            SqlConnection con1 = new SqlConnection(conn);
            con1.Open();
            SqlCommand sc1 = new SqlCommand(sql_user, con1);
            //sc1.Parameters.AddWithValue("@ten", username);
            SqlDataReader sqlReader1 = sc1.ExecuteReader();

            int rank = 0;

            if (sqlReader1.HasRows)
            {
                while (sqlReader1.Read())
                {
                    if (string.Equals(sqlReader1.GetString(1), username, StringComparison.OrdinalIgnoreCase))
                    {
                        rank = (int)sqlReader1.GetInt64(0);
                    }

                }

            }
            con1.Dispose();
            sc1.Dispose();
            sqlReader1.Close();
            return rank;
        }

        #endregion
    }
}
