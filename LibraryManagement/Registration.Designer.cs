namespace LibraryManagement
{
    partial class Registration
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
            label2 = new Label();
            panel1 = new Panel();
            HidePassWordRegis = new CheckBox();
            txtrepass = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btRegis = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 9);
            label2.Name = "label2";
            label2.Size = new Size(236, 46);
            label2.TabIndex = 1;
            label2.Text = "Đăng ký";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(HidePassWordRegis);
            panel1.Controls.Add(txtrepass);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 343);
            panel1.TabIndex = 11;
            // 
            // HidePassWordRegis
            // 
            HidePassWordRegis.AutoSize = true;
            HidePassWordRegis.Location = new Point(333, 252);
            HidePassWordRegis.Name = "HidePassWordRegis";
            HidePassWordRegis.Size = new Size(127, 24);
            HidePassWordRegis.TabIndex = 23;
            HidePassWordRegis.Text = "Hiện mật khẩu";
            HidePassWordRegis.UseVisualStyleBackColor = true;
            HidePassWordRegis.CheckedChanged += HidePassWordRegis_CheckedChanged;
            // 
            // txtrepass
            // 
            txtrepass.Location = new Point(183, 207);
            txtrepass.Name = "txtrepass";
            txtrepass.Size = new Size(286, 27);
            txtrepass.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label7.Location = new Point(18, 212);
            label7.Name = "label7";
            label7.Size = new Size(153, 22);
            label7.TabIndex = 21;
            label7.Text = "Nhập lại mật khẩu:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(183, 291);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(183, 147);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(286, 27);
            txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(183, 82);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(286, 27);
            txtUser.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 27);
            txtName.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label5.Location = new Point(18, 291);
            label5.Name = "label5";
            label5.Size = new Size(56, 22);
            label5.TabIndex = 14;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label4.Location = new Point(18, 152);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 13;
            label4.Text = "mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label3.Location = new Point(18, 87);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 12;
            label3.Text = "tên người dùng: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 11;
            label1.Text = "Họ và tên:";
            // 
            // btRegis
            // 
            btRegis.BackColor = Color.FromArgb(192, 255, 192);
            btRegis.FlatStyle = FlatStyle.Popup;
            btRegis.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRegis.ForeColor = Color.FromArgb(0, 192, 0);
            btRegis.Location = new Point(181, 436);
            btRegis.Name = "btRegis";
            btRegis.Size = new Size(140, 43);
            btRegis.TabIndex = 0;
            btRegis.Text = "Đăng ký";
            btRegis.UseVisualStyleBackColor = false;
            btRegis.Click += btRegis_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(509, 496);
            Controls.Add(btRegis);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button2;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtUser;
        private TextBox txtName;
        private Button btRegis;
        private TextBox txtrepass;
        private Label label7;
        private CheckBox HidePassWordRegis;
    }
}