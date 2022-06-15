using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessProject
{
    public partial class VerifyForm : Form
    {
        public static string VerifyCode = ForgotPass.VerifyCode;
        public static string userMail = ForgotPass.InputMail;
        public VerifyForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            
            if (tbCode.Text == VerifyCode)
            {
                ResetPass sp = new ResetPass();
                this.Hide();
                sp.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai mã xác thực!");
            }
            
        }

        private async void btnSendAgain_Click(object sender, EventArgs e)
        {
            List<byte> fullPackage = new List<byte>();
            fullPackage.Add(0);
            fullPackage.Add(1);
            fullPackage.AddRange(Encoding.UTF8.GetBytes(userMail.Trim()));
            Login.clientSocket.Send(fullPackage.ToArray());

            byte[] recvBytes = new byte[20];

            await Task.Run(() =>
            {
                //trycatch
                Login.clientSocket.Receive(recvBytes, 0, recvBytes.Length, System.Net.Sockets.SocketFlags.None);
            });

            if (recvBytes[0] == 1)
            {
                VerifyCode = Encoding.UTF8.GetString(recvBytes, 1, recvBytes.Length - 1);
            }
            else
            {
                MessageBox.Show("Gửi tới mail "+ userMail + " không thành công!");
                return;
            }
            
        }
    }
}
