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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbUsername.TextLength == 0 || tbPassWord.TextLength == 0 ||
                tbEmail.TextLength == 0 || tbPassWord.Text != tbConfirm.Text|| 
                (!cbMale.Checked && !cbFemale.Checked))
            {
                return;
            }
            string sendString = tbUsername.Text + ' ' + tbPassWord.Text + ' ' + tbEmail.Text;
            List<byte> fullPackage = new List<byte>();
            fullPackage.Add(0);
            fullPackage.Add(6);
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
                MessageBox.Show("Đăng ký thành công!");
                Form login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công!");
                return;
            }

        }
    }
}
