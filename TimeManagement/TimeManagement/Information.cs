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

<<<<<<< Updated upstream
        void Avarta_Show()
        {
            Rectangle r = new Rectangle(0, 0, ptbAvarta.Width, ptbAvarta.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(25, 25, 150, 150);
            Region rg = new Region(gp);
            ptbAvarta.Region = rg;
=======
        void Change_Avatar()
        {
            Rectangle r = new Rectangle(0, 0, Avatar.Width, Avatar.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, Avatar.Width, Avatar.Height);
            Region rg = new Region(gp);
            Avatar.Region = rg;
>>>>>>> Stashed changes
        }

        private void Information_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            Avarta_Show();
=======
            Change_Avatar();
>>>>>>> Stashed changes
        }
    }
}
