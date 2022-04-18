using System.Drawing;

namespace TimeManagement
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.header = new System.Windows.Forms.Panel();
            this.ForgotPass = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.bckLogIn = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.AccountText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.bckLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.header.Controls.Add(this.ForgotPass);
            this.header.Controls.Add(this.SignUp);
            this.header.Controls.Add(this.Logo);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1000, 125);
            this.header.TabIndex = 0;
            // 
            // ForgotPass
            // 
            this.ForgotPass.AutoSize = true;
            this.ForgotPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ForgotPass.Location = new System.Drawing.Point(650, 85);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(188, 31);
            this.ForgotPass.TabIndex = 2;
            this.ForgotPass.Text = "Quên mật khẩu?";
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.SignUp.Location = new System.Drawing.Point(875, 85);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(102, 31);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Đăng ký";
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::TimeManagement.Properties.Resources.logo_app;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(425, 125);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // bckLogIn
            // 
            this.bckLogIn.Controls.Add(this.btnLogin);
            this.bckLogIn.Controls.Add(this.PasswordText);
            this.bckLogIn.Controls.Add(this.AccountText);
            this.bckLogIn.Controls.Add(this.Password);
            this.bckLogIn.Controls.Add(this.Account);
            this.bckLogIn.Location = new System.Drawing.Point(100, 150);
            this.bckLogIn.Name = "bckLogIn";
            this.bckLogIn.Size = new System.Drawing.Size(800, 350);
            this.bckLogIn.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.btnLogin.Location = new System.Drawing.Point(25, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(750, 75);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(300, 150);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(475, 51);
            this.PasswordText.TabIndex = 4;
            // 
            // AccountText
            // 
            this.AccountText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountText.Location = new System.Drawing.Point(300, 50);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(475, 51);
            this.AccountText.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.Password.Location = new System.Drawing.Point(25, 150);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(169, 45);
            this.Password.TabIndex = 2;
            this.Password.Text = "Mật khẩu:";
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.Account.Location = new System.Drawing.Point(25, 50);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(249, 45);
            this.Account.TabIndex = 1;
            this.Account.Text = "Tên đăng nhập:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.bckLogIn);
            this.Controls.Add(this.header);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Management";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.bckLogIn.ResumeLayout(false);
            this.bckLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Panel bckLogIn;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox AccountText;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label ForgotPass;
    }
}

