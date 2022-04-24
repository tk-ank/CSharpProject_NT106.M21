using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagement
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
            Home home = new Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnContent.Controls.Add(home);
            home.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           btnHome_Click(sender, e);
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
            Information infor = new Information()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnContent.Controls.Add(infor);
            infor.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
            Schedule TKB = new Schedule()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnContent.Controls.Add(TKB);
            TKB.Show();

        }
    }
}
