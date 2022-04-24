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
            this.University = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.BedTime = new System.Windows.Forms.Label();
            this.GetUpTime = new System.Windows.Forms.Label();
            this.SignUpDate = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.btnEdition = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.pnTitle.Controls.Add(this.University);
            this.pnTitle.Controls.Add(this.Username);
            this.pnTitle.Controls.Add(this.Avatar);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(875, 200);
            this.pnTitle.TabIndex = 10;
<<<<<<< Updated upstream
=======
            // 
            // University
            // 
            this.University.AutoSize = true;
            this.University.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.University.ForeColor = System.Drawing.Color.White;
            this.University.Location = new System.Drawing.Point(200, 130);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(581, 45);
            this.University.TabIndex = 2;
            this.University.Text = "Trường Đại Học Công Nghệ Thông Tin";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(200, 65);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(329, 65);
            this.Username.TabIndex = 1;
            this.Username.Text = "Trang Kỳ Anh";
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Avatar.Image = global::TimeManagement.Properties.Resources.icons8_person_64;
            this.Avatar.Location = new System.Drawing.Point(25, 25);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(150, 150);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.btnEdit.Location = new System.Drawing.Point(892, 929);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(251, 46);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Chỉnh sửa thông tin";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // BedTime
            // 
            this.BedTime.AutoSize = true;
            this.BedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BedTime.Location = new System.Drawing.Point(25, 675);
            this.BedTime.Name = "BedTime";
            this.BedTime.Size = new System.Drawing.Size(122, 30);
            this.BedTime.TabIndex = 17;
            this.BedTime.Text = "Giờ đi ngủ:";
            // 
            // GetUpTime
            // 
            this.GetUpTime.AutoSize = true;
            this.GetUpTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetUpTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.GetUpTime.Location = new System.Drawing.Point(25, 600);
            this.GetUpTime.Name = "GetUpTime";
            this.GetUpTime.Size = new System.Drawing.Size(144, 30);
            this.GetUpTime.TabIndex = 16;
            this.GetUpTime.Text = "Giờ thức dậy:";
            // 
            // SignUpDate
            // 
            this.SignUpDate.AutoSize = true;
            this.SignUpDate.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SignUpDate.Location = new System.Drawing.Point(25, 525);
            this.SignUpDate.Name = "SignUpDate";
            this.SignUpDate.Size = new System.Drawing.Size(155, 30);
            this.SignUpDate.TabIndex = 15;
            this.SignUpDate.Text = "Ngày đăng ký:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Email.Location = new System.Drawing.Point(25, 450);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(71, 30);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.PhoneNumber.Location = new System.Drawing.Point(25, 375);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(150, 30);
            this.PhoneNumber.TabIndex = 13;
            this.PhoneNumber.Text = "Số điện thoại:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Sex.Location = new System.Drawing.Point(25, 300);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(104, 30);
            this.Sex.TabIndex = 12;
            this.Sex.Text = "Giới tính:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Birthday.Location = new System.Drawing.Point(25, 225);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(117, 30);
            this.Birthday.TabIndex = 11;
            this.Birthday.Text = "Ngày sinh:";
            // 
            // btnEdition
            // 
            this.btnEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.btnEdition.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdition.ForeColor = System.Drawing.Color.White;
            this.btnEdition.Location = new System.Drawing.Point(662, 745);
            this.btnEdition.Name = "btnEdition";
            this.btnEdition.Size = new System.Drawing.Size(175, 35);
            this.btnEdition.TabIndex = 19;
            this.btnEdition.Text = "Chỉnh sửa thông tin";
            this.btnEdition.UseVisualStyleBackColor = false;
>>>>>>> Stashed changes
            // 
            // University
            // 
            this.University.AutoSize = true;
            this.University.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.University.ForeColor = System.Drawing.Color.White;
            this.University.Location = new System.Drawing.Point(200, 130);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(581, 45);
            this.University.TabIndex = 2;
            this.University.Text = "Trường Đại Học Công Nghệ Thông Tin";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(200, 65);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(329, 65);
            this.Username.TabIndex = 1;
            this.Username.Text = "Trang Kỳ Anh";
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Avatar.Image = global::TimeManagement.Properties.Resources.icons8_person_64;
            this.Avatar.Location = new System.Drawing.Point(25, 25);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(150, 150);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.btnEdit.Location = new System.Drawing.Point(892, 929);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(251, 46);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Chỉnh sửa thông tin";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // BedTime
            // 
            this.BedTime.AutoSize = true;
            this.BedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BedTime.Location = new System.Drawing.Point(25, 675);
            this.BedTime.Name = "BedTime";
            this.BedTime.Size = new System.Drawing.Size(122, 30);
            this.BedTime.TabIndex = 17;
            this.BedTime.Text = "Giờ đi ngủ:";
            // 
            // GetUpTime
            // 
            this.GetUpTime.AutoSize = true;
            this.GetUpTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetUpTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.GetUpTime.Location = new System.Drawing.Point(25, 600);
            this.GetUpTime.Name = "GetUpTime";
            this.GetUpTime.Size = new System.Drawing.Size(144, 30);
            this.GetUpTime.TabIndex = 16;
            this.GetUpTime.Text = "Giờ thức dậy:";
            // 
            // SignUpDate
            // 
            this.SignUpDate.AutoSize = true;
            this.SignUpDate.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SignUpDate.Location = new System.Drawing.Point(25, 525);
            this.SignUpDate.Name = "SignUpDate";
            this.SignUpDate.Size = new System.Drawing.Size(155, 30);
            this.SignUpDate.TabIndex = 15;
            this.SignUpDate.Text = "Ngày đăng ký:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Email.Location = new System.Drawing.Point(25, 450);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(71, 30);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.PhoneNumber.Location = new System.Drawing.Point(25, 375);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(150, 30);
            this.PhoneNumber.TabIndex = 13;
            this.PhoneNumber.Text = "Số điện thoại:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Sex.Location = new System.Drawing.Point(25, 300);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(104, 30);
            this.Sex.TabIndex = 12;
            this.Sex.Text = "Giới tính:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Birthday.Location = new System.Drawing.Point(25, 225);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(117, 30);
            this.Birthday.TabIndex = 11;
            this.Birthday.Text = "Ngày sinh:";
            // 
            // btnEdition
            // 
            this.btnEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.btnEdition.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdition.ForeColor = System.Drawing.Color.White;
            this.btnEdition.Location = new System.Drawing.Point(662, 745);
            this.btnEdition.Name = "btnEdition";
            this.btnEdition.Size = new System.Drawing.Size(175, 35);
            this.btnEdition.TabIndex = 19;
            this.btnEdition.Text = "Chỉnh sửa thông tin";
            this.btnEdition.UseVisualStyleBackColor = false;
            // 
>>>>>>> Stashed changes
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(875, 800);
            this.Controls.Add(this.btnEdition);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.BedTime);
            this.Controls.Add(this.GetUpTime);
            this.Controls.Add(this.SignUpDate);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Birthday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Information";
            this.Text = "Information";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label University;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label BedTime;
        private System.Windows.Forms.Label GetUpTime;
        private System.Windows.Forms.Label SignUpDate;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Button btnEdition;
    }
}