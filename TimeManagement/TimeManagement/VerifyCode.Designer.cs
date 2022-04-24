namespace TimeManagement
{
    partial class VerifyCode
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
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.pnForgot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnForgot
            // 
            this.pnForgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.pnForgot.Controls.Add(this.LogoPic);
            this.pnForgot.Location = new System.Drawing.Point(0, 0);
            this.pnForgot.Name = "pnForgot";
            this.pnForgot.Size = new System.Drawing.Size(400, 75);
            this.pnForgot.TabIndex = 4;
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
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.Title.Location = new System.Drawing.Point(39, 85);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(322, 37);
            this.Title.TabIndex = 5;
            this.Title.Text = "XÁC NHẬN DANH TÍNH";
            // 
            // VerifyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pnForgot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerifyCode";
            this.Text = "VerifyCode";
            this.pnForgot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnForgot;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Label Title;
    }
}