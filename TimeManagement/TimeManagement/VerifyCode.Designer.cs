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
            this.CodeText = new System.Windows.Forms.TextBox();
            this.Verify = new System.Windows.Forms.Label();
            this.btnConform = new System.Windows.Forms.Button();
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
            // CodeText
            // 
            this.CodeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodeText.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeText.Location = new System.Drawing.Point(25, 165);
            this.CodeText.Name = "CodeText";
            this.CodeText.Size = new System.Drawing.Size(350, 30);
            this.CodeText.TabIndex = 6;
            // 
            // Verify
            // 
            this.Verify.AutoSize = true;
            this.Verify.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verify.Location = new System.Drawing.Point(25, 140);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(97, 20);
            this.Verify.TabIndex = 7;
            this.Verify.Text = "Mã xác nhận";
            // 
            // btnConform
            // 
            this.btnConform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.btnConform.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConform.ForeColor = System.Drawing.Color.White;
            this.btnConform.Location = new System.Drawing.Point(275, 205);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(100, 35);
            this.btnConform.TabIndex = 8;
            this.btnConform.Text = "Xác nhận";
            this.btnConform.UseVisualStyleBackColor = false;
            // 
            // VerifyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnConform);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.CodeText);
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
        private System.Windows.Forms.TextBox CodeText;
        private System.Windows.Forms.Label Verify;
        private System.Windows.Forms.Button btnConform;
    }
}