namespace ChessProject
{
    partial class ForgotPass
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
            this.pnForgot = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.Verify = new System.Windows.Forms.Label();
            this.tbInputMail = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnForgot.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForgot
            // 
            this.pnForgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.pnForgot.Controls.Add(this.Title);
            this.pnForgot.Location = new System.Drawing.Point(0, 0);
            this.pnForgot.Margin = new System.Windows.Forms.Padding(4);
            this.pnForgot.Name = "pnForgot";
            this.pnForgot.Size = new System.Drawing.Size(533, 92);
            this.pnForgot.TabIndex = 15;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.Title.Location = new System.Drawing.Point(100, 31);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(312, 46);
            this.Title.TabIndex = 12;
            this.Title.Text = "XÁC NHẬN EMAIL";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(367, 215);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 43);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Tiếp tục";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Verify
            // 
            this.Verify.AutoSize = true;
            this.Verify.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verify.Location = new System.Drawing.Point(48, 123);
            this.Verify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(410, 25);
            this.Verify.TabIndex = 14;
            this.Verify.Text = "Nhập email bạn đã dùng để đăng ký tài khoản";
            // 
            // tbInputMail
            // 
            this.tbInputMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputMail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputMail.Location = new System.Drawing.Point(33, 166);
            this.tbInputMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbInputMail.Name = "tbInputMail";
            this.tbInputMail.Size = new System.Drawing.Size(466, 36);
            this.tbInputMail.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(200, 215);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 43);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(533, 277);
            this.Controls.Add(this.pnForgot);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.tbInputMail);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.pnForgot.ResumeLayout(false);
            this.pnForgot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnForgot;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label Verify;
        private System.Windows.Forms.TextBox tbInputMail;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnExit;
    }
}