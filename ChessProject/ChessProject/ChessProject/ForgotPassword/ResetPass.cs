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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPassword.TextLength == 0 || tbReType.TextLength == 0 || tbPassword.Text != tbReType.Text)
            {
                return;
            }

            ServerConnect.Send(ForgotPass.Username, tbPassword.Text, 0, 3);
            ServerConnect.WaitForData();

            if (ServerConnect.recvBytes[0] == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                Form si = new SignIn();
                this.Hide();
                si.Show();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại, vui lòng nhập mật khẩu khác!");
                return;
            }
        }
    }
}
