namespace TimeManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePic
            // 
            this.HomePic.BackgroundImage = global::TimeManagement.Properties.Resources.Untitled_1;
            this.HomePic.Location = new System.Drawing.Point(0, 0);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(875, 800);
            this.HomePic.TabIndex = 0;
            this.HomePic.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.Title.Location = new System.Drawing.Point(20, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(831, 212);
            this.Title.TabIndex = 2;
            this.Title.Text = "PHẦN MỀM\nQUẢN LÝ THỜI GIAN";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(875, 800);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.HomePic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Time Management";
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.Label Title;
    }
}