using System.Drawing;
using System.Windows.Forms;

namespace TimeManagement
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnTodo = new System.Windows.Forms.Panel();
            this.btnTodo = new System.Windows.Forms.Button();
            this.pnDeadline = new System.Windows.Forms.Panel();
            this.btnDeadline = new System.Windows.Forms.Button();
            this.pnSchedule = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.pnUser = new System.Windows.Forms.Panel();
            this.btnInfor = new System.Windows.Forms.Button();
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.pnTodo.SuspendLayout();
            this.pnDeadline.SuspendLayout();
            this.pnSchedule.SuspendLayout();
            this.pnUser.SuspendLayout();
            this.pnHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.pnMenu.Controls.Add(this.Logo);
            this.pnMenu.Controls.Add(this.pnLogout);
            this.pnMenu.Controls.Add(this.pnTodo);
            this.pnMenu.Controls.Add(this.pnDeadline);
            this.pnMenu.Controls.Add(this.pnSchedule);
            this.pnMenu.Controls.Add(this.pnUser);
            this.pnMenu.Controls.Add(this.pnHome);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(325, 800);
            this.pnMenu.TabIndex = 0;
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.pictureBox5);
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(0, 590);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(325, 75);
            this.pnLogout.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.Location = new System.Drawing.Point(75, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 75);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnTodo
            // 
            this.pnTodo.Controls.Add(this.pictureBox4);
            this.pnTodo.Controls.Add(this.btnTodo);
            this.pnTodo.Location = new System.Drawing.Point(0, 515);
            this.pnTodo.Margin = new System.Windows.Forms.Padding(2);
            this.pnTodo.Name = "pnTodo";
            this.pnTodo.Size = new System.Drawing.Size(325, 75);
            this.pnTodo.TabIndex = 4;
            // 
            // btnTodo
            // 
            this.btnTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTodo.FlatAppearance.BorderSize = 0;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTodo.Location = new System.Drawing.Point(75, 0);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(250, 75);
            this.btnTodo.TabIndex = 0;
            this.btnTodo.TabStop = false;
            this.btnTodo.Text = "Todo list";
            this.btnTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodo.UseVisualStyleBackColor = false;
            // 
            // pnDeadline
            // 
            this.pnDeadline.Controls.Add(this.pictureBox3);
            this.pnDeadline.Controls.Add(this.btnDeadline);
            this.pnDeadline.Location = new System.Drawing.Point(0, 440);
            this.pnDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.pnDeadline.Name = "pnDeadline";
            this.pnDeadline.Size = new System.Drawing.Size(325, 75);
            this.pnDeadline.TabIndex = 3;
            // 
            // btnDeadline
            // 
            this.btnDeadline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeadline.FlatAppearance.BorderSize = 0;
            this.btnDeadline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeadline.Location = new System.Drawing.Point(75, 0);
            this.btnDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeadline.Name = "btnDeadline";
            this.btnDeadline.Size = new System.Drawing.Size(250, 75);
            this.btnDeadline.TabIndex = 0;
            this.btnDeadline.TabStop = false;
            this.btnDeadline.Text = "Deadline";
            this.btnDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeadline.UseVisualStyleBackColor = false;
            // 
            // pnSchedule
            // 
            this.pnSchedule.Controls.Add(this.pictureBox2);
            this.pnSchedule.Controls.Add(this.btnSchedule);
            this.pnSchedule.Location = new System.Drawing.Point(0, 365);
            this.pnSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.pnSchedule.Name = "pnSchedule";
            this.pnSchedule.Size = new System.Drawing.Size(325, 75);
            this.pnSchedule.TabIndex = 2;
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSchedule.Location = new System.Drawing.Point(75, 0);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(250, 75);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.TabStop = false;
            this.btnSchedule.Text = "Thời khóa biểu";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.UseVisualStyleBackColor = false;
            // 
            // pnUser
            // 
            this.pnUser.Controls.Add(this.UserPic);
            this.pnUser.Controls.Add(this.btnInfor);
            this.pnUser.Location = new System.Drawing.Point(0, 290);
            this.pnUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(325, 75);
            this.pnUser.TabIndex = 1;
            // 
            // btnInfor
            // 
            this.btnInfor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInfor.FlatAppearance.BorderSize = 0;
            this.btnInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInfor.Location = new System.Drawing.Point(75, 0);
            this.btnInfor.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Size = new System.Drawing.Size(250, 75);
            this.btnInfor.TabIndex = 0;
            this.btnInfor.TabStop = false;
            this.btnInfor.Text = "Thông tin cá nhân";
            this.btnInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfor.UseVisualStyleBackColor = false;
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.HomePic);
            this.pnHome.Controls.Add(this.btnHome);
            this.pnHome.Location = new System.Drawing.Point(0, 215);
            this.pnHome.Margin = new System.Windows.Forms.Padding(2);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(325, 75);
            this.pnHome.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.Location = new System.Drawing.Point(75, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 75);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnContent
            // 
            this.pnContent.Location = new System.Drawing.Point(325, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(875, 800);
            this.pnContent.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Image = global::TimeManagement.Properties.Resources.logo_app1;
            this.Logo.Location = new System.Drawing.Point(59, 75);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(206, 81);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::TimeManagement.Properties.Resources.icons8_logout_30__1_;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(25, 25);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TimeManagement.Properties.Resources.icons8_todo_list_64;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(25, 25);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TimeManagement.Properties.Resources.icons8_deadline_64;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(25, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::TimeManagement.Properties.Resources.icons8_schedule_48;
            this.pictureBox2.Location = new System.Drawing.Point(25, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // UserPic
            // 
            this.UserPic.Image = global::TimeManagement.Properties.Resources.icons8_person_64;
            this.UserPic.Location = new System.Drawing.Point(25, 25);
            this.UserPic.Margin = new System.Windows.Forms.Padding(2);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(25, 25);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPic.TabIndex = 1;
            this.UserPic.TabStop = false;
            // 
            // HomePic
            // 
            this.HomePic.BackgroundImage = global::TimeManagement.Properties.Resources.icons8_home_50;
            this.HomePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomePic.Location = new System.Drawing.Point(25, 25);
            this.HomePic.Margin = new System.Windows.Forms.Padding(2);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(25, 25);
            this.HomePic.TabIndex = 1;
            this.HomePic.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Management";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.pnTodo.ResumeLayout(false);
            this.pnDeadline.ResumeLayout(false);
            this.pnSchedule.ResumeLayout(false);
            this.pnUser.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Button btnHome;
        private PictureBox HomePic;
        private Panel pnLogout;
        private PictureBox pictureBox5;
        private Button btnLogout;
        private Panel pnTodo;
        private PictureBox pictureBox4;
        private Button btnTodo;
        private Panel pnDeadline;
        private PictureBox pictureBox3;
        private Button btnDeadline;
        private Panel pnSchedule;
        private PictureBox pictureBox2;
        private Button btnSchedule;
        private Panel pnUser;
        private Button btnInfor;
        private PictureBox UserPic;
        private PictureBox Logo;
    }
}