namespace TimeManagement
{
    partial class Information
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.ptbAvarta = new System.Windows.Forms.PictureBox();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDateRegister = new System.Windows.Forms.Label();
            this.lbGetUp = new System.Windows.Forms.Label();
            this.lbSleep = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUniversity = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvarta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.pnTitle.Controls.Add(this.lbUniversity);
            this.pnTitle.Controls.Add(this.lbUserName);
            this.pnTitle.Controls.Add(this.ptbAvarta);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(875, 200);
            this.pnTitle.TabIndex = 0;
            // 
            // ptbAvarta
            // 
            this.ptbAvarta.BackColor = System.Drawing.Color.White;
            this.ptbAvarta.Location = new System.Drawing.Point(0, 0);
            this.ptbAvarta.Name = "ptbAvarta";
            this.ptbAvarta.Size = new System.Drawing.Size(200, 200);
            this.ptbAvarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvarta.TabIndex = 0;
            this.ptbAvarta.TabStop = false;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.Location = new System.Drawing.Point(15, 250);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(135, 32);
            this.lbBirthday.TabIndex = 1;
            this.lbBirthday.Text = "Ngày sinh: ";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(15, 325);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(114, 32);
            this.lbSex.TabIndex = 2;
            this.lbSex.Text = "Giới tính:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(15, 400);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(165, 32);
            this.lbPhoneNumber.TabIndex = 3;
            this.lbPhoneNumber.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(15, 475);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(78, 32);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email:";
            // 
            // lbDateRegister
            // 
            this.lbDateRegister.AutoSize = true;
            this.lbDateRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRegister.Location = new System.Drawing.Point(15, 550);
            this.lbDateRegister.Name = "lbDateRegister";
            this.lbDateRegister.Size = new System.Drawing.Size(172, 32);
            this.lbDateRegister.TabIndex = 6;
            this.lbDateRegister.Text = "Ngày đăng ký:";
            // 
            // lbGetUp
            // 
            this.lbGetUp.AutoSize = true;
            this.lbGetUp.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGetUp.Location = new System.Drawing.Point(15, 625);
            this.lbGetUp.Name = "lbGetUp";
            this.lbGetUp.Size = new System.Drawing.Size(160, 32);
            this.lbGetUp.TabIndex = 7;
            this.lbGetUp.Text = "Giờ thức dậy:";
            // 
            // lbSleep
            // 
            this.lbSleep.AutoSize = true;
            this.lbSleep.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSleep.Location = new System.Drawing.Point(15, 700);
            this.lbSleep.Name = "lbSleep";
            this.lbSleep.Size = new System.Drawing.Size(135, 32);
            this.lbSleep.TabIndex = 8;
            this.lbSleep.Text = "Giờ đi ngủ:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.btnEdit.Location = new System.Drawing.Point(635, 750);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Chỉnh sửa thông tin";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.lbUserName.Location = new System.Drawing.Point(245, 45);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(222, 45);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Trang Kỳ Anh";
            // 
            // lbUniversity
            // 
            this.lbUniversity.AutoSize = true;
            this.lbUniversity.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUniversity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.lbUniversity.Location = new System.Drawing.Point(245, 110);
            this.lbUniversity.Name = "lbUniversity";
            this.lbUniversity.Size = new System.Drawing.Size(431, 32);
            this.lbUniversity.TabIndex = 2;
            this.lbUniversity.Text = "Trường Đại Học Công Nghệ Thông Tin";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(875, 800);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbSleep);
            this.Controls.Add(this.lbGetUp);
            this.Controls.Add(this.lbDateRegister);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Information";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDateRegister;
        private System.Windows.Forms.Label lbGetUp;
        private System.Windows.Forms.Label lbSleep;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox ptbAvarta;
        private System.Windows.Forms.Label lbUniversity;
        private System.Windows.Forms.Label lbUserName;
    }
}