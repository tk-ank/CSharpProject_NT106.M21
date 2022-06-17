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

using System.Threading;
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

        

        byte[] recvBuffer = new byte[4];
        byte[] recvBytes;
        public static Socket listenSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static Socket recvSock;
        string conn;

        //"DESKTOP-AG3SDR7\SQLEXPRESS" .replace(\,\\)
        //"123321"
        //Nhập user của sqlexpress trên máy local host, đảm bảo là  "\" thành "\\"
        private void btnListen_Click(object sender, EventArgs e)
        {
            //if (tbLocalName.TextLength == 0 || tbPassword.TextLength == 0)
            //{
            //    return;
            //}

            //String SQLuser = tbLocalName.Text.Replace(@"\","\\");
            //conn = ("Data Source=" + SQLuser + ";Initial Catalog=QLCOVUA;User id=sa;password=" + tbPassword.Text + ";");
            conn = ("Data Source=TRANGKYANH;Initial Catalog=QLCOVUA;User id=sa;password=sa;");

            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới sql data base");
                return;
            }

            MessageBox.Show("Kết nối cơ sở dữ liệu thành công!");

            listenSock.Bind(new IPEndPoint(IPAddress.Any, 1234));
            listenSock.Listen(10);
            listenSock.BeginAccept(listenCallBack, listenSock);

            btnListen.Enabled = false;
        }
        private void listenCallBack(IAsyncResult ar)
        {
            recvBuffer = new byte[4];
            recvSock = listenSock.EndAccept(ar);
            recvSock.BeginReceive(recvBuffer, 0, recvBuffer.Length, SocketFlags.None, recvCallBack, recvSock);

            listenSock.BeginAccept(listenCallBack, listenSock);
        }
        private void recvCallBack(IAsyncResult AR)
        {
            
            recvBytes = new byte[BitConverter.ToInt32(recvBuffer,0)];
            recvSock.Receive(recvBytes, 0, recvBytes.Length, SocketFlags.None);

            string stringData = "";
            string[] stringArr;

            bool flag = false;
            switch (recvBytes[1])
            {
                case 1://ForgotPass - Gửi mail xác thực
                    {
                        string email = Encoding.UTF8.GetString(recvBytes, 2, recvBytes.Length - 2).Trim();
                        string randomCode = RandomString(5, true);
                        if (checkMail(email, randomCode))
                        {
                            stringData = username + " " + randomCode;
                            Send(stringData, 1);
                        }
                        else
                        {
                            Send(0);
                        }
                        break;
                    }
                case 2://Xác thực ở máy, chưa dùng *** (Hàm bỏ trống)
                    break;
                case 3://ForgotPass - Đổi mật khẩu
                    {
                        stringData = Encoding.UTF8.GetString(recvBytes, 2, recvBytes.Length - 2).Trim();
                        stringArr = stringData.Split(' ');
                        if (NewPass(stringArr[0], stringArr[1]))
                        {
                            Send(1);
                        }
                        else
                        {
                            Send(0);
                        }
                        break;
                    }
                case 4://Đăng nhập 
                    {
                        stringData = Encoding.UTF8.GetString(recvBytes,2,recvBytes.Length-2);
                        stringArr = stringData.Split(' ');
                        if (SignIn(stringArr[0], stringArr[1]))
                        {
                            Send(1);
                        }
                        else
                        {
                            Send(0);
                        }
                        break;
                    }
                case 5:
                    break;
                case 6:
                    {
                        stringData = Encoding.UTF8.GetString(recvBytes, 2, recvBytes.Length - 2).Trim();
                        stringArr = stringData.Split(' ');
                        if (SignUp(stringArr))
                        {
                            Send(1);
                        }
                        else
                        {
                            Send(0);
                        }
                        break;
                    }
                case 7:
                    {
                        stringData = Encoding.UTF8.GetString(recvBytes, 2, recvBytes.Length - 2).Trim();
                        string[] RankList = Rank(stringData);
                        stringData = RankList[0] + ' ' + RankList[1] + ' '
                                    + RankList[2] + ' ' + RankList[3] + ' '
                                    + RankList[4] + ' ' + RankList[5] + ' '
                                    + RankList[6] + ' ' + RankList[7] + ' ' + RankList[8];
                        Send(stringData,1);
                        break;
                    }
                case 8:
                    {
                        stringData = Encoding.UTF8.GetString(recvBytes, 2, recvBytes.Length - 2).Trim();
                        stringArr = getInfo(stringData);
                        stringData = stringArr[0] + " " + stringArr[1] + " " + stringArr[2] + " " + stringArr[3];
                        Send(stringData,1);
                        break;
                    }
                case 9:
                    ManageClient.AddClient(recvSock);
                    flag = true;
                    break;
                case 0:
                    stringData = Encoding.UTF8.GetString(recvBytes, 2, recvBytes.Length - 2).Trim();
                    stringArr = stringData.Split(' ');
                    if (changePass(stringArr[0], stringArr[1], stringArr[2]))
                        Send(1);
                    else
                        Send(0);

                    break;
            }

            recvBuffer = new byte[4];
            
            if (!flag)
                recvSock.BeginReceive(recvBuffer, 0, recvBuffer.Length, SocketFlags.None, recvCallBack, recvSock);

        }
        public static void Send(byte[] data)
        {
            List<byte> fullPackage = new List<byte>();
            fullPackage.AddRange(BitConverter.GetBytes(data.Length));
            fullPackage.AddRange(data);
            recvSock.Send(fullPackage.ToArray());
        }
        public static void Send(byte firstByte)
        {
            List<byte> fullPackage = new List<byte>();
            fullPackage.AddRange(BitConverter.GetBytes(1));
            fullPackage.Add(firstByte);
            //fullPackage.Add(secondByte);
            recvSock.Send(fullPackage.ToArray());
        }
        public static void Send(string sendString, byte firstByte)
        {
            List<byte> fullPackage = new List<byte>();
            fullPackage.AddRange(BitConverter.GetBytes(sendString.Length+1));
            fullPackage.Add(firstByte);
            //fullPackage.Add(secondByte);
            fullPackage.AddRange(Encoding.UTF8.GetBytes(sendString));
            recvSock.Send(fullPackage.ToArray());
        }
        public static void Send(string sendString1, string sendString2, byte firstByte)
        {
            List<byte> fullPackage = new List<byte>();
            string sendString = sendString1 + " " + sendString2;
            fullPackage.AddRange(BitConverter.GetBytes(sendString.Length+1));
            fullPackage.Add(firstByte);
            fullPackage.AddRange(Encoding.UTF8.GetBytes(sendString));
            recvSock.Send(fullPackage.ToArray());
        }
        public static void Send(string sendString1, string sendString2, string sendString3, byte firstByte)
        {
            List<byte> fullPackage = new List<byte>();
            string sendString = sendString1 + " " + sendString2 + " " + sendString3;
            fullPackage.AddRange(BitConverter.GetBytes(sendString.Length+1));
            fullPackage.Add(firstByte);
            fullPackage.AddRange(Encoding.UTF8.GetBytes(sendString));
            recvSock.Send(fullPackage.ToArray());
        }

        #endregion

        #region CÁC HÀM TRUY XUẤT SQL 

        public string username = "";
        //01
        private bool checkMail(string inputGmail, string code)
        {
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
                    message.From.Add(new MailboxAddress("", "ChessApp@gmail.com"));
                    message.To.Add(new MailboxAddress("", inputGmail));
                    message.Subject = "Mã xác nhận đổi tài khoản App Chess";
                    BodyBuilder bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Mã xác nhận là : " + code;
                    message.Body = bodyBuilder.ToMessageBody();
                    using (var client = new MailKit.Net.Smtp.SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("20520370@gm.uit.edu.vn", "gguit3139");
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


        //03
        private bool NewPass(string username, string newPass)
        {
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
            string sql = "SELECT TENND FROM NGUOIDUNG WHERE TENND=@ten AND MATKHAU=@mk ";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sc = new SqlCommand(sql, con);
            sc.Parameters.AddWithValue("@ten", username);
            sc.Parameters.AddWithValue("@mk", pass);
            SqlDataReader sqlReader = sc.ExecuteReader();

            bool result = sqlReader.HasRows;
            con.Dispose();
            sc.Dispose();
            sqlReader.Close();

            return result;
        }

        //05
        

        //06
        private bool SignUp(string[] msg)
        {
            //msg[0]: username, msg[1]:pass, msg[2]:email
            if (checkSignUp(msg[0], msg[2]) == false)
            {
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
        private bool changePass(string username, string oldPass, string newPass)
        {
            if (SignIn(username, oldPass) == true)
            {
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
            return false;
        }

        //11
        private bool MatchUpdate(string username1, string username2, int ratio)
        {
            //ratio 0:username1 thua
            //ratio 1:username1 hòa
            //ratio 2:username1 thắng
            return true;
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

        private bool checkSignUp(string username, string inputGmail)
        {


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

        private int getBattleCount(string username)
        {

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
            double rate;
            if (battle == 0)
                rate = 0.0;
            else
                rate = (win + draw * 0.5) * 100.0 / battle;
            rate = Math.Round(rate, 1);
            return rate;
        }

        private int getCurrRank(string username)
        {


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

        #region Socket
        public class Client
        {
            public Socket clientSock { get; set; }
            public int id { get; set; }
            public byte[] data = new byte[8];
            public bool isWaiting = false;

            public Client(Socket _socket, int _id)
            {
                clientSock = _socket;
                id = _id;
            }
            public void send(byte[] _data)
            {
                var fullPacket = new List<byte>();
                fullPacket.AddRange(BitConverter.GetBytes(_data.Length));
                fullPacket.AddRange(_data);
                clientSock.Send(fullPacket.ToArray());
            }
            public void StartReceiving()
            {
                try
                {
                    data = new byte[12];
                    clientSock.BeginReceive(data, 0, 4, SocketFlags.None, ReceiveCallback, null);
                }
                catch { }
            }
            private void ReceiveCallback(IAsyncResult AR)
            {
                try
                {
                    data = new byte[8];
                    if (clientSock.EndReceive(AR) > 1)
                    {
                        clientSock.Receive(data, data.Length, SocketFlags.None);
                    }
                    else
                    {
                        Disconnect();
                    }
                }
                catch
                {
                    // if exeption is throw check if socket is connected because than you can startreive again else Dissconect
                    if (!clientSock.Connected)
                    {
                        Disconnect();
                    }
                    else
                    {
                        StartReceiving();
                    }
                }
            }

            private void Disconnect()
            {
                // Close connection
                clientSock.Disconnect(true);

            }
        }
        public static class ManageClient
        {
            static List<Client> Clients = new List<Client>();

            public static void AddClient(Socket _socket)
            {
                Clients.Add(new Client(_socket, Clients.Count));
                //MessageBox.Show($"adding new socket success! id:{Clients[Clients.Count - 1].id}");

                //Có người đang đợi
                if (Clients.Count % 2 == 0)
                {
                    foreach (Client client in Clients)
                    {
                        if (client.isWaiting)
                        {
                            client.isWaiting = false;
                            MatchBetween(client, Clients[Clients.Count - 1]);
                            break;
                        }
                    }
                }
                else
                {
                    Clients[Clients.Count - 1].isWaiting = true;
                }
            }

            public static void RemoveClient(int _id)
            {
                int findIndex = Clients.FindIndex(x => x.id == _id);
                Clients.RemoveAt(findIndex);
                MessageBox.Show($"Remove id {_id} which is Clients[{findIndex}] ");
            }

            public static void MatchBetween(Client firstPlayer, Client secondPlayer)
            {
                //buffer để gửi
                byte[] buffer = new byte[8];

                #region TRƯỚC VÁN ĐẤU

                //Quy định quân đen hay trắng
                buffer[0] = 1;
                firstPlayer.send(buffer);

                buffer[0] = 0;
                secondPlayer.send(buffer);

                #endregion

                #region VÁN ĐẤU

                bool WhiteToPlay = true;
                while (true)
                {
                    buffer = new byte[8];
                    if (WhiteToPlay)
                    {
                        firstPlayer.StartReceiving();

                        while (firstPlayer.data[4] == firstPlayer.data[6] &&
                            firstPlayer.data[5] == firstPlayer.data[7])
                        {
                            Thread.Sleep(1000);
                        }
                        buffer = firstPlayer.data;
                        secondPlayer.send(buffer);
                    }
                    else
                    {
                        secondPlayer.StartReceiving();

                        while (secondPlayer.data[4] == secondPlayer.data[6] &&
                            secondPlayer.data[5] == secondPlayer.data[7])
                        {
                            Thread.Sleep(1000);
                        }

                        buffer = secondPlayer.data;
                        firstPlayer.send(buffer);
                    }
                    WhiteToPlay = !WhiteToPlay;
                    //Ván kết thúc

                }

                #endregion
            }
        }
        #endregion
    }
}



