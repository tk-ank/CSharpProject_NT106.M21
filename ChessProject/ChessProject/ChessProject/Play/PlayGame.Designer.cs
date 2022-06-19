namespace ChessProject
{
    partial class PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.pnRank = new System.Windows.Forms.Panel();
            this.Rank = new System.Windows.Forms.PictureBox();
            this.lbRank = new System.Windows.Forms.Label();
            this.pnPractice = new System.Windows.Forms.Panel();
            this.practise = new System.Windows.Forms.PictureBox();
            this.lbPractise = new System.Windows.Forms.Label();
            this.pnRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).BeginInit();
            this.pnPractice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practise)).BeginInit();
            this.SuspendLayout();
            // 
            // pnRank
            // 
            this.pnRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.pnRank.Controls.Add(this.Rank);
            this.pnRank.Controls.Add(this.lbRank);
            this.pnRank.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnRank.Location = new System.Drawing.Point(175, 450);
            this.pnRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnRank.Name = "pnRank";
            this.pnRank.Size = new System.Drawing.Size(525, 100);
            this.pnRank.TabIndex = 12;
            // 
            // Rank
            // 
            this.Rank.BackgroundImage = global::ChessProject.Properties.Resources.icons8_chess_64;
            this.Rank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rank.Location = new System.Drawing.Point(0, 0);
            this.Rank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(107, 98);
            this.Rank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Rank.TabIndex = 1;
            this.Rank.TabStop = false;
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.ForeColor = System.Drawing.Color.White;
            this.lbRank.Location = new System.Drawing.Point(160, 10);
            this.lbRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(238, 65);
            this.lbRank.TabIndex = 0;
            this.lbRank.Text = "Đấu hạng";
            this.lbRank.Click += new System.EventHandler(this.lbRank_Click);
            // 
            // pnPractice
            // 
            this.pnPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.pnPractice.Controls.Add(this.practise);
            this.pnPractice.Controls.Add(this.lbPractise);
            this.pnPractice.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPractice.Location = new System.Drawing.Point(175, 250);
            this.pnPractice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnPractice.Name = "pnPractice";
            this.pnPractice.Size = new System.Drawing.Size(525, 100);
            this.pnPractice.TabIndex = 13;
            // 
            // practise
            // 
            this.practise.Image = global::ChessProject.Properties.Resources.icons8_book_50;
            this.practise.Location = new System.Drawing.Point(0, 0);
            this.practise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.practise.Name = "practise";
            this.practise.Size = new System.Drawing.Size(107, 98);
            this.practise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.practise.TabIndex = 1;
            this.practise.TabStop = false;
            // 
            // lbPractise
            // 
            this.lbPractise.AutoSize = true;
            this.lbPractise.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPractise.ForeColor = System.Drawing.Color.White;
            this.lbPractise.Location = new System.Drawing.Point(173, 10);
            this.lbPractise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPractise.Name = "lbPractise";
            this.lbPractise.Size = new System.Drawing.Size(199, 65);
            this.lbPractise.TabIndex = 0;
            this.lbPractise.Text = "Đấu tập";
            this.lbPractise.Click += new System.EventHandler(this.lbPractise_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(875, 800);
            this.Controls.Add(this.pnRank);
            this.Controls.Add(this.pnPractice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.pnRank.ResumeLayout(false);
            this.pnRank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).EndInit();
            this.pnPractice.ResumeLayout(false);
            this.pnPractice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRank;
        private System.Windows.Forms.PictureBox Rank;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Panel pnPractice;
        private System.Windows.Forms.PictureBox practise;
        private System.Windows.Forms.Label lbPractise;
    }
}