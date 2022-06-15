﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        
        

        private void btnHome_Click(object sender, EventArgs e)
        { 
            pnContent.Controls.Clear();
            Home TrangChu = new Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnContent.Controls.Add(TrangChu);
            TrangChu.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Home TrangChu = new Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnContent.Controls.Add(TrangChu);
            TrangChu.Show();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
            Ranking BXH = new Ranking()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnContent.Controls.Add(BXH);
            BXH.Show();
        }
    }
}
