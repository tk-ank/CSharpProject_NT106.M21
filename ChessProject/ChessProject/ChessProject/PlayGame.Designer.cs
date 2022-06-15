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
            this.pnRank = new System.Windows.Forms.Panel();
            this.lbRank = new System.Windows.Forms.Label();
            this.pnPractise = new System.Windows.Forms.Panel();
            this.lbPractise = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.PictureBox();
            this.practise = new System.Windows.Forms.PictureBox();
            this.pnRank.SuspendLayout();
            this.pnPractise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practise)).BeginInit();
            this.SuspendLayout();
            // 
            // pnRank
            // 
            this.pnRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.pnRank.Controls.Add(this.Rank);
            this.pnRank.Controls.Add(this.lbRank);
            this.pnRank.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnRank.Location = new System.Drawing.Point(174, 597);
            this.pnRank.Margin = new System.Windows.Forms.Padding(4);
            this.pnRank.Name = "pnRank";
            this.pnRank.Size = new System.Drawing.Size(533, 98);
            this.pnRank.TabIndex = 12;
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
            // 
            // pnPractise
            // 
            this.pnPractise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.pnPractise.Controls.Add(this.practise);
            this.pnPractise.Controls.Add(this.lbPractise);
            this.pnPractise.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPractise.Location = new System.Drawing.Point(174, 351);
            this.pnPractise.Margin = new System.Windows.Forms.Padding(4);
            this.pnPractise.Name = "pnPractise";
            this.pnPractise.Size = new System.Drawing.Size(533, 98);
            this.pnPractise.TabIndex = 13;
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
            // 
            // Rank
            // 
            this.Rank.BackgroundImage = global::ChessProject.Properties.Resources.icons8_chess_64;
            this.Rank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rank.Location = new System.Drawing.Point(0, 0);
            this.Rank.Margin = new System.Windows.Forms.Padding(4);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(107, 98);
            this.Rank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Rank.TabIndex = 1;
            this.Rank.TabStop = false;
            // 
            // practise
            // 
            this.practise.Image = global::ChessProject.Properties.Resources.icons8_book_50;
            this.practise.Location = new System.Drawing.Point(0, 0);
            this.practise.Margin = new System.Windows.Forms.Padding(4);
            this.practise.Name = "practise";
            this.practise.Size = new System.Drawing.Size(107, 98);
            this.practise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.practise.TabIndex = 1;
            this.practise.TabStop = false;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(875, 800);
            this.Controls.Add(this.pnRank);
            this.Controls.Add(this.pnPractise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.pnRank.ResumeLayout(false);
            this.pnRank.PerformLayout();
            this.pnPractise.ResumeLayout(false);
            this.pnPractise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRank;
        private System.Windows.Forms.PictureBox Rank;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Panel pnPractise;
        private System.Windows.Forms.PictureBox practise;
        private System.Windows.Forms.Label lbPractise;
    }
}