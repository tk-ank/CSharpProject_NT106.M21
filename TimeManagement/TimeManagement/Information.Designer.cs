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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.University);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Avatar);
            this.panel1.Location = new System.Drawing.Point(0, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 200);
            this.panel1.TabIndex = 10;
            // 
            // University
            // 
            this.University.AutoSize = true;
            this.University.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.University.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.University.Location = new System.Drawing.Point(200, 100);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(432, 32);
            this.University.TabIndex = 2;
            this.University.Text = "Trường Đại Học Công Nghệ Thông Tin";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.Username.Location = new System.Drawing.Point(200, 50);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(227, 45);
            this.Username.TabIndex = 1;
            this.Username.Text = "Trang Kỳ Anh";
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
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.btnEdit.Location = new System.Drawing.Point(899, 933);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(250, 45);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Chỉnh sửa thông tin";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // BedTime
            // 
            this.BedTime.AutoSize = true;
            this.BedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BedTime.Location = new System.Drawing.Point(19, 833);
            this.BedTime.Name = "BedTime";
            this.BedTime.Size = new System.Drawing.Size(157, 38);
            this.BedTime.TabIndex = 17;
            this.BedTime.Text = "Giờ đi ngủ:";
            // 
            // GetUpTime
            // 
            this.GetUpTime.AutoSize = true;
            this.GetUpTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetUpTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.GetUpTime.Location = new System.Drawing.Point(19, 733);
            this.GetUpTime.Name = "GetUpTime";
            this.GetUpTime.Size = new System.Drawing.Size(186, 38);
            this.GetUpTime.TabIndex = 16;
            this.GetUpTime.Text = "Giờ thức dậy:";
            // 
            // SignUpDate
            // 
            this.SignUpDate.AutoSize = true;
            this.SignUpDate.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SignUpDate.Location = new System.Drawing.Point(19, 633);
            this.SignUpDate.Name = "SignUpDate";
            this.SignUpDate.Size = new System.Drawing.Size(201, 38);
            this.SignUpDate.TabIndex = 15;
            this.SignUpDate.Text = "Ngày đăng ký:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Email.Location = new System.Drawing.Point(19, 533);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(93, 38);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.PhoneNumber.Location = new System.Drawing.Point(19, 433);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(192, 38);
            this.PhoneNumber.TabIndex = 13;
            this.PhoneNumber.Text = "Số điện thoại:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Sex.Location = new System.Drawing.Point(19, 333);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(132, 38);
            this.Sex.TabIndex = 12;
            this.Sex.Text = "Giới tính:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Birthday.Location = new System.Drawing.Point(19, 233);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(150, 38);
            this.Birthday.TabIndex = 11;
            this.Birthday.Text = "Ngày sinh:";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1167, 985);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.BedTime);
            this.Controls.Add(this.GetUpTime);
            this.Controls.Add(this.SignUpDate);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Birthday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Information";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}