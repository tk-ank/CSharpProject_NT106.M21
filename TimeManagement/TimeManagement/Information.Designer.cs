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
<<<<<<< Updated upstream
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
=======
            this.University = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Birthday = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.SignUpDate = new System.Windows.Forms.Label();
            this.GetUpTime = new System.Windows.Forms.Label();
            this.BedTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
<<<<<<< Updated upstream
            this.pnTitle.Controls.Add(this.lbUniversity);
            this.pnTitle.Controls.Add(this.lbUserName);
            this.pnTitle.Controls.Add(this.ptbAvarta);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
=======
            this.pnTitle.Controls.Add(this.University);
            this.pnTitle.Controls.Add(this.UserName);
            this.pnTitle.Controls.Add(this.Avatar);
            this.pnTitle.Location = new System.Drawing.Point(1, -1);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> Stashed changes
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1167, 200);
            this.pnTitle.TabIndex = 0;
            // 
<<<<<<< Updated upstream
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
=======
            // University
            // 
            this.University.AutoSize = true;
            this.University.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.University.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.University.Location = new System.Drawing.Point(200, 110);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(432, 32);
            this.University.TabIndex = 2;
            this.University.Text = "Trường Đại Học Công Nghệ Thông Tin";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.UserName.Location = new System.Drawing.Point(200, 50);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(217, 45);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Trang Kỳ Anh";
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.Avatar.Image = global::TimeManagement.Properties.Resources.icons8_person_64;
            this.Avatar.Location = new System.Drawing.Point(25, 25);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(150, 150);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Birthday.Location = new System.Drawing.Point(25, 225);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(153, 38);
            this.Birthday.TabIndex = 1;
            this.Birthday.Text = "Ngày Sinh:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Sex.Location = new System.Drawing.Point(25, 325);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(137, 38);
            this.Sex.TabIndex = 2;
            this.Sex.Text = "Giới Tính:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.PhoneNumber.Location = new System.Drawing.Point(25, 425);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(200, 38);
            this.PhoneNumber.TabIndex = 3;
            this.PhoneNumber.Text = "Số Điện Thoại:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Email.Location = new System.Drawing.Point(25, 525);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(93, 38);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email:";
            // 
            // SignUpDate
            // 
            this.SignUpDate.AutoSize = true;
            this.SignUpDate.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SignUpDate.Location = new System.Drawing.Point(25, 625);
            this.SignUpDate.Name = "SignUpDate";
            this.SignUpDate.Size = new System.Drawing.Size(205, 38);
            this.SignUpDate.TabIndex = 5;
            this.SignUpDate.Text = "Ngày Đăng Ký:";
            // 
            // GetUpTime
            // 
            this.GetUpTime.AutoSize = true;
            this.GetUpTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetUpTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.GetUpTime.Location = new System.Drawing.Point(25, 725);
            this.GetUpTime.Name = "GetUpTime";
            this.GetUpTime.Size = new System.Drawing.Size(194, 38);
            this.GetUpTime.TabIndex = 6;
            this.GetUpTime.Text = "Giờ Thức Dậy:";
            // 
            // BedTime
            // 
            this.BedTime.AutoSize = true;
            this.BedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BedTime.Location = new System.Drawing.Point(25, 825);
            this.BedTime.Name = "BedTime";
            this.BedTime.Size = new System.Drawing.Size(165, 38);
            this.BedTime.TabIndex = 7;
            this.BedTime.Text = "Giờ Đi Ngủ:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.button1.Location = new System.Drawing.Point(900, 925);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chỉnh Sửa Thông Tin";
            this.button1.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
<<<<<<< Updated upstream
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
=======
            this.ClientSize = new System.Drawing.Size(1167, 985);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BedTime);
            this.Controls.Add(this.GetUpTime);
            this.Controls.Add(this.SignUpDate);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Birthday);
>>>>>>> Stashed changes
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Information";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
<<<<<<< Updated upstream
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvarta)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
<<<<<<< Updated upstream
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
=======
        private System.Windows.Forms.Label University;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label SignUpDate;
        private System.Windows.Forms.Label GetUpTime;
        private System.Windows.Forms.Label BedTime;
        private System.Windows.Forms.Button button1;
>>>>>>> Stashed changes
    }
}