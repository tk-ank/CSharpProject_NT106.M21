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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (tbPassword.TextLength == 0 || tbNewPass.TextLength == 0
                || tbConfirm.TextLength == 0)
                return;
            string stringData = ServerConnect.username + " " + tbPassword.Text + " " + tbNewPass.Text;
            ServerConnect.Send(stringData,1,0);
            ServerConnect.WaitForData();
            if (ServerConnect.recvBytes[0] == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
            else
                MessageBox.Show("Đổi mật khẩu thất bại!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Infor inf = new Infor();
            this.Hide();
            inf.Show();
        }
    }
}
