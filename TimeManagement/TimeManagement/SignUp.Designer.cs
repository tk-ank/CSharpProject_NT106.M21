
namespace TimeManagement
{
    partial class SignUp
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
            this.header = new System.Windows.Forms.Panel();
            this.SigUp = new System.Windows.Forms.Label();
            this.bckSignUp = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.University = new System.Windows.Forms.Label();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUniversity = new System.Windows.Forms.TextBox();
            this.Male = new System.Windows.Forms.CheckBox();
            this.Female = new System.Windows.Forms.CheckBox();
            this.header.SuspendLayout();
            this.bckSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.header.Controls.Add(this.SigUp);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(660, 100);
            this.header.TabIndex = 1;
            // 
            // SigUp
            // 
            this.SigUp.AutoSize = true;
            this.SigUp.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.SigUp.Location = new System.Drawing.Point(25, 25);
            this.SigUp.Name = "SigUp";
            this.SigUp.Size = new System.Drawing.Size(354, 45);
            this.SigUp.TabIndex = 0;
            this.SigUp.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // bckSignUp
            // 
            this.bckSignUp.Controls.Add(this.Female);
            this.bckSignUp.Controls.Add(this.Male);
            this.bckSignUp.Controls.Add(this.tbUniversity);
            this.bckSignUp.Controls.Add(this.tbEmail);
            this.bckSignUp.Controls.Add(this.tbPhoneNumber);
            this.bckSignUp.Controls.Add(this.tbFullName);
            this.bckSignUp.Controls.Add(this.tbPassWord);
            this.bckSignUp.Controls.Add(this.tbUsername);
            this.bckSignUp.Controls.Add(this.tbConfirm);
            this.bckSignUp.Controls.Add(this.button1);
            this.bckSignUp.Controls.Add(this.cbConfirm);
            this.bckSignUp.Controls.Add(this.University);
            this.bckSignUp.Controls.Add(this.Email);
            this.bckSignUp.Controls.Add(this.PhoneNumber);
            this.bckSignUp.Controls.Add(this.Sex);
            this.bckSignUp.Controls.Add(this.FullName);
            this.bckSignUp.Controls.Add(this.Confirm);
            this.bckSignUp.Controls.Add(this.PassWord);
            this.bckSignUp.Controls.Add(this.UserName);
            this.bckSignUp.Location = new System.Drawing.Point(0, 100);
            this.bckSignUp.Name = "bckSignUp";
            this.bckSignUp.Size = new System.Drawing.Size(660, 600);
            this.bckSignUp.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(10, 15);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(184, 32);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Tên đăng nhập:";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.Location = new System.Drawing.Point(10, 70);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(126, 32);
            this.PassWord.TabIndex = 1;
            this.PassWord.Text = "Mật khẩu:";
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = true;
            this.Confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(10, 125);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(233, 32);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "Xác nhận mật khẩu:";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(10, 180);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(128, 32);
            this.FullName.TabIndex = 3;
            this.FullName.Text = "Họ và tên:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(10, 235);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(115, 32);
            this.Sex.TabIndex = 4;
            this.Sex.Text = "Giới tính:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(10, 290);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(166, 32);
            this.PhoneNumber.TabIndex = 5;
            this.PhoneNumber.Text = "Số điện thoại:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(10, 345);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(79, 32);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email:";
            // 
            // University
            // 
            this.University.AutoSize = true;
            this.University.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.University.Location = new System.Drawing.Point(10, 400);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(142, 32);
            this.University.TabIndex = 7;
            this.University.Text = "Tên trường:";
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirm.Location = new System.Drawing.Point(30, 450);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(332, 32);
            this.cbConfirm.TabIndex = 8;
            this.cbConfirm.Text = "Tôi xác nhận những thông tin trên";
            this.cbConfirm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(81)))), ((int)(((byte)(153)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.button1.Location = new System.Drawing.Point(230, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đăng Ký";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbConfirm
            // 
            this.tbConfirm.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbConfirm.Location = new System.Drawing.Point(250, 125);
            this.tbConfirm.Multiline = true;
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(375, 32);
            this.tbConfirm.TabIndex = 10;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbUsername.Location = new System.Drawing.Point(250, 15);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(375, 32);
            this.tbUsername.TabIndex = 11;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbPassWord.Location = new System.Drawing.Point(250, 70);
            this.tbPassWord.Multiline = true;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(375, 32);
            this.tbPassWord.TabIndex = 12;
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbFullName.Location = new System.Drawing.Point(250, 180);
            this.tbFullName.Multiline = true;
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(375, 32);
            this.tbFullName.TabIndex = 13;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbPhoneNumber.Location = new System.Drawing.Point(250, 290);
            this.tbPhoneNumber.Multiline = true;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(375, 32);
            this.tbPhoneNumber.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbEmail.Location = new System.Drawing.Point(250, 345);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(375, 32);
            this.tbEmail.TabIndex = 15;
            // 
            // tbUniversity
            // 
            this.tbUniversity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUniversity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbUniversity.Location = new System.Drawing.Point(250, 400);
            this.tbUniversity.Multiline = true;
            this.tbUniversity.Name = "tbUniversity";
            this.tbUniversity.Size = new System.Drawing.Size(375, 32);
            this.tbUniversity.TabIndex = 16;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(300, 235);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(76, 32);
            this.Male.TabIndex = 17;
            this.Male.Text = "Nam";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.Location = new System.Drawing.Point(500, 235);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(61, 32);
            this.Female.TabIndex = 18;
            this.Female.Text = "Nữ";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(660, 700);
            this.Controls.Add(this.bckSignUp);
            this.Controls.Add(this.header);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.bckSignUp.ResumeLayout(false);
            this.bckSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label SigUp;
        private System.Windows.Forms.Panel bckSignUp;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.CheckBox Female;
        private System.Windows.Forms.CheckBox Male;
        private System.Windows.Forms.TextBox tbUniversity;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.Label University;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Confirm;
        private System.Windows.Forms.Label PassWord;
    }
}