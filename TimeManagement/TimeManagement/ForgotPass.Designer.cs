namespace TimeManagement
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
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Verify = new System.Windows.Forms.Label();
            this.pnForgot = new System.Windows.Forms.Panel();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.btnConform = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnForgot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.Title.Location = new System.Drawing.Point(75, 85);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(249, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "XÁC NHẬN EMAIL";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 30);
            this.textBox1.TabIndex = 1;
            // 
            // Verify
            // 
            this.Verify.AutoSize = true;
            this.Verify.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verify.Location = new System.Drawing.Point(36, 130);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(327, 20);
            this.Verify.TabIndex = 2;
            this.Verify.Text = "Nhập email bạn đã dùng để đăng ký tài khoản";
            // 
            // pnForgot
            // 
            this.pnForgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.pnForgot.Controls.Add(this.LogoPic);
            this.pnForgot.Location = new System.Drawing.Point(0, 0);
            this.pnForgot.Name = "pnForgot";
            this.pnForgot.Size = new System.Drawing.Size(400, 75);
            this.pnForgot.TabIndex = 3;
            // 
            // LogoPic
            // 
            this.LogoPic.BackgroundImage = global::TimeManagement.Properties.Resources.logo_app;
            this.LogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPic.Location = new System.Drawing.Point(0, 0);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(250, 75);
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            // 
            // btnConform
            // 
            this.btnConform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.btnConform.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConform.ForeColor = System.Drawing.Color.White;
            this.btnConform.Location = new System.Drawing.Point(275, 200);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(100, 35);
            this.btnConform.TabIndex = 4;
            this.btnConform.Text = "Tiếp tục";
            this.btnConform.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(150, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConform);
            this.Controls.Add(this.pnForgot);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.pnForgot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Verify;
        private System.Windows.Forms.Panel pnForgot;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Button btnConform;
        private System.Windows.Forms.Button btnExit;
    }
}