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
    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
        }

        public static bool localPlay = false;
        private void lbPractise_Click(object sender, EventArgs e)
        {
            Form sp = new SinglePlay();
            this.Hide();
            sp.Show ();
        }

        private void lbRank_Click(object sender, EventArgs e)
        {
            localPlay = true;
            this.Close();
            PlayChess PlayLAN = new PlayChess();
            PlayLAN.Show();
        }
    }
}
