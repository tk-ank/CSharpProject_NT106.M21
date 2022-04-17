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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        void Avarta_Show()
        {
            Rectangle r = new Rectangle(0, 0, ptbAvarta.Width, ptbAvarta.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(25, 25, 150, 150);
            Region rg = new Region(gp);
            ptbAvarta.Region = rg;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            Avarta_Show();
        }
    }
}
