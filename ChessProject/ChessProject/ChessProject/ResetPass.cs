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
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPass.TextLength ==0 || tbReType.TextLength==0 || tbPass.Text != tbReType.Text)
            {
                return;
            }

            string sendString = ForgotPass.username +' '+tbPass.Text;
            List<byte> fullPackage = new List<byte>();
            fullPackage.Add(0);
            fullPackage.Add(3);
            fullPackage.AddRange(Encoding.UTF8.GetBytes(sendString));
            Login.clientSocket.Send(fullPackage.ToArray());

            byte[] recvBytes = new byte[1];

            await Task.Run(() =>
            {
                //trycatch
                Login.clientSocket.Receive(recvBytes, 0, 1, System.Net.Sockets.SocketFlags.None);
            });

            if (recvBytes[0] == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                Form login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại, vui lòng nhập mật khẩu khác!");
                return;
            }
        }
    }
}
