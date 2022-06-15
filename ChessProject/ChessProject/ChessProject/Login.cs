using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace ChessProject
{
    
    public partial class Login : Form
    {
        public static string username = "";
        public static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static bool TryToConnect(Socket connector)
        {
            while (!clientSocket.Connected)
            {
                try
                {
                    clientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234));
                }
                catch
                {
                    if (MessageBox.Show("Connect to server failed. Try again?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                        return false;
                }
            }
            return true;
        }

        public Login()
        {
            InitializeComponent();
        }
        private void ForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPass fg = new ForgotPass();
            this.Hide();
            fg.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            this.Hide();
            su.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!TryToConnect(clientSocket))
                return;
            btnConnect.Enabled = false;
            MessageBox.Show("Kết nối tới server thành công");
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (AccountText.TextLength == 0 || PasswordText.TextLength == 0)
            {
                return;
            }

            string sendString = AccountText.Text + " " + PasswordText.Text;
            List<byte> fullPackage = new List<byte>();
            fullPackage.Add(0);
            fullPackage.Add(4);
            fullPackage.AddRange(Encoding.UTF8.GetBytes(sendString));
            clientSocket.Send(fullPackage.ToArray());

            byte[] recvBytes = new byte[1];

            await Task.Run(() =>
            {
                //trycatch
                clientSocket.Receive(recvBytes, 0, 1, SocketFlags.None);
            });

            if (recvBytes[0] == 1) 
            {
                username = AccountText.Text;
                MessageBox.Show("Đăng nhập thành công!");
                Form menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                return;
            }
        }
    }
}
