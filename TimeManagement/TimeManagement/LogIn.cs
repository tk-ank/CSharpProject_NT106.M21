﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeManagement
{
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();
        }

        private void ForgotPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass forgot = new ForgotPass();
            forgot.Show();
        }
    }
}
