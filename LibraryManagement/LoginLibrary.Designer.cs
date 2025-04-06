namespace LibraryManagement
{
    partial class LoginLibrary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginLibrary));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btSignUp = new Button();
            btLogin = new Button();
            pictureFacebook = new PictureBox();
            pictureYoutube = new PictureBox();
            pictureIns = new PictureBox();
            btClose = new Button();
            HidePassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFacebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureYoutube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureIns).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(35, 36, 55);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(102, 223);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(197, 25);
            txtUser.TabIndex = 0;
            txtUser.Text = "Username";
            txtUser.MouseClick += txtUser_MouseClick;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(35, 36, 55);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.White;
            txtPass.Location = new Point(102, 284);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(197, 25);
            txtPass.TabIndex = 1;
            txtPass.Text = "Password";
            txtPass.MouseClick += txtPass_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user_icon_512x512_x23sj495;
            pictureBox3.Location = new Point(35, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(35, 279);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(102, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 4);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(102, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 4);
            panel2.TabIndex = 7;
            // 
            // btSignUp
            // 
            btSignUp.BackColor = Color.Black;
            btSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSignUp.ForeColor = Color.Cyan;
            btSignUp.Location = new Point(35, 412);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(264, 39);
            btSignUp.TabIndex = 3;
            btSignUp.Text = "Sign Up";
            btSignUp.UseVisualStyleBackColor = false;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.FromArgb(192, 255, 255);
            btLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.Location = new Point(35, 367);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(264, 39);
            btLogin.TabIndex = 2;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // pictureFacebook
            // 
            pictureFacebook.Image = Properties.Resources.images__1_;
            pictureFacebook.Location = new Point(35, 474);
            pictureFacebook.Name = "pictureFacebook";
            pictureFacebook.Size = new Size(65, 50);
            pictureFacebook.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFacebook.TabIndex = 11;
            pictureFacebook.TabStop = false;
            pictureFacebook.Click += pictureFacebook_Click;
            // 
            // pictureYoutube
            // 
            pictureYoutube.Image = (Image)resources.GetObject("pictureYoutube.Image");
            pictureYoutube.Location = new Point(140, 474);
            pictureYoutube.Name = "pictureYoutube";
            pictureYoutube.Size = new Size(65, 50);
            pictureYoutube.SizeMode = PictureBoxSizeMode.Zoom;
            pictureYoutube.TabIndex = 12;
            pictureYoutube.TabStop = false;
            pictureYoutube.Click += pictureYoutube_Click;
            // 
            // pictureIns
            // 
            pictureIns.Image = (Image)resources.GetObject("pictureIns.Image");
            pictureIns.Location = new Point(234, 474);
            pictureIns.Name = "pictureIns";
            pictureIns.Size = new Size(65, 50);
            pictureIns.SizeMode = PictureBoxSizeMode.Zoom;
            pictureIns.TabIndex = 13;
            pictureIns.TabStop = false;
            pictureIns.Click += pictureIns_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.FromArgb(64, 64, 64);
            btClose.ForeColor = Color.Red;
            btClose.Location = new Point(280, 12);
            btClose.Name = "btClose";
            btClose.Size = new Size(39, 31);
            btClose.TabIndex = 14;
            btClose.Text = "X";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            btClose.KeyDown += btClose_KeyDown;
            // 
            // HidePassword
            // 
            HidePassword.AutoSize = true;
            HidePassword.ForeColor = SystemColors.ButtonHighlight;
            HidePassword.Location = new Point(158, 328);
            HidePassword.Name = "HidePassword";
            HidePassword.Size = new Size(127, 24);
            HidePassword.TabIndex = 15;
            HidePassword.Text = "Hiện mật khẩu";
            HidePassword.UseVisualStyleBackColor = true;
            HidePassword.CheckedChanged += HidePassword_CheckedChanged;
            // 
            // LoginLibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 55);
            ClientSize = new Size(331, 557);
            Controls.Add(HidePassword);
            Controls.Add(btClose);
            Controls.Add(pictureIns);
            Controls.Add(pictureYoutube);
            Controls.Add(pictureFacebook);
            Controls.Add(btLogin);
            Controls.Add(btSignUp);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginLibrary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginLibrary_Load;
            KeyDown += LoginLibrary_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFacebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureYoutube).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureIns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUser;
        private TextBox txtPass;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Button btSignUp;
        private Button btLogin;
        private PictureBox pictureFacebook;
        private PictureBox pictureYoutube;
        private PictureBox pictureIns;
        private Button btClose;
        private CheckBox HidePassword;
    }
}
