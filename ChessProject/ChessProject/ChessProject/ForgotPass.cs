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
    public partial class ForgotPass : Form
    {
        public static string InputMail = "";
        public static string username = "";
        public static string VerifyCode = "";
        Socket clientSocket = Login.clientSocket;
        public ForgotPass()
        {
            InitializeComponent();
        }

        
        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbInputMail.TextLength==0)
            {
                return;
            }

            List<byte> fullPackage = new List<byte>();
            fullPackage.Add(0);
            fullPackage.Add(1);
            fullPackage.AddRange(Encoding.UTF8.GetBytes(tbInputMail.Text.Trim()));
            clientSocket.Send(fullPackage.ToArray());

            byte[] recvBytes = new byte[20];

            await Task.Run(() =>
            {
                //trycatch
                clientSocket.Receive(recvBytes, 0, recvBytes.Length, SocketFlags.None);
            });

            if (recvBytes[0] == 1)
            {
                InputMail = tbInputMail.Text;
                string recvString = Encoding.UTF8.GetString(recvBytes, 1, recvBytes.Length - 1);
                string[] stringArr = recvString.Split(' ');
                username = stringArr[0];
                VerifyCode = stringArr[1];

                VerifyForm vs = new VerifyForm();
                this.Hide();
                vs.Show();
            }
            else
            {
                MessageBox.Show("Không tồn tại Mail này");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
