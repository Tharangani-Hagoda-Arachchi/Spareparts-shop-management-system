
namespace project_GUI
{
    partial class Loging
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbiPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.linkLabelShow = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(119, 358);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(332, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbiPassword
            // 
            this.lbiPassword.AutoSize = true;
            this.lbiPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbiPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbiPassword.ForeColor = System.Drawing.Color.White;
            this.lbiPassword.Location = new System.Drawing.Point(115, 245);
            this.lbiPassword.Name = "lbiPassword";
            this.lbiPassword.Size = new System.Drawing.Size(81, 19);
            this.lbiPassword.TabIndex = 35;
            this.lbiPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(115, 188);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 19);
            this.lblUsername.TabIndex = 34;
            this.lblUsername.Text = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(219, 248);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 20);
            this.txtPassword.TabIndex = 33;
            // 
            // txtUser_name
            // 
            this.txtUser_name.Location = new System.Drawing.Point(219, 188);
            this.txtUser_name.Name = "txtUser_name";
            this.txtUser_name.Size = new System.Drawing.Size(232, 20);
            this.txtUser_name.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(170, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 1);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(166, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 1);
            this.panel1.TabIndex = 28;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLogin.Location = new System.Drawing.Point(247, 90);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(87, 28);
            this.lblLogin.TabIndex = 25;
            this.lblLogin.Text = "LOG IN";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::project_GUI.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(74, 240);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project_GUI.Properties.Resources.usename;
            this.pictureBox2.Location = new System.Drawing.Point(74, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxLogin.Image = global::project_GUI.Properties.Resources.png_transparent_computer_icons_user_login_desktop_others_blue_computer_prints1;
            this.pictureBoxLogin.Location = new System.Drawing.Point(252, 21);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(75, 66);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 24;
            this.pictureBoxLogin.TabStop = false;
            // 
            // linkLabelShow
            // 
            this.linkLabelShow.AutoSize = true;
            this.linkLabelShow.BackColor = System.Drawing.Color.White;
            this.linkLabelShow.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabelShow.LinkColor = System.Drawing.Color.Black;
            this.linkLabelShow.Location = new System.Drawing.Point(410, 251);
            this.linkLabelShow.Name = "linkLabelShow";
            this.linkLabelShow.Size = new System.Drawing.Size(41, 13);
            this.linkLabelShow.TabIndex = 36;
            this.linkLabelShow.TabStop = true;
            this.linkLabelShow.Text = "SHOW";
            this.linkLabelShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShow_LinkClicked);
            // 
            // Loging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::project_GUI.Properties.Resources.cus_reg_31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 591);
            this.Controls.Add(this.linkLabelShow);
            this.Controls.Add(this.lbiPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loging";
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.Loging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbiPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.LinkLabel linkLabelShow;
    }
}