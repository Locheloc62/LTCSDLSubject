namespace LibraryManagement
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtCoSo = new TextBox();
            txtMaSV = new TextBox();
            txtTenSV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtKhoaHoc = new TextBox();
            btRefesh = new Button();
            btSavett = new Button();
            btExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-9, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 95);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(234, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 331);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 36);
            label1.Name = "label1";
            label1.Size = new Size(173, 40);
            label1.TabIndex = 1;
            label1.Text = "Thêm sinh viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(221, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 418);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(384, 376);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 27);
            txtEmail.TabIndex = 25;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(384, 328);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(236, 27);
            txtSDT.TabIndex = 24;
            // 
            // txtCoSo
            // 
            txtCoSo.Location = new Point(384, 217);
            txtCoSo.Name = "txtCoSo";
            txtCoSo.Size = new Size(236, 27);
            txtCoSo.TabIndex = 23;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(388, 164);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(236, 27);
            txtMaSV.TabIndex = 22;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(388, 107);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(236, 27);
            txtTenSV.TabIndex = 21;
            // 
            // label7
            // 
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.Location = new Point(236, 369);
            label7.Name = "label7";
            label7.Size = new Size(127, 39);
            label7.TabIndex = 20;
            label7.Text = "Email:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(239, 316);
            label6.Name = "label6";
            label6.Size = new Size(124, 39);
            label6.TabIndex = 19;
            label6.Text = "Số điện thoại";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.Location = new Point(239, 262);
            label5.Name = "label5";
            label5.Size = new Size(135, 39);
            label5.TabIndex = 18;
            label5.Text = "Khóa học:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.Location = new Point(239, 205);
            label4.Name = "label4";
            label4.Size = new Size(135, 39);
            label4.TabIndex = 17;
            label4.Text = "Cơ sở:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(258, 152);
            label3.Name = "label3";
            label3.Size = new Size(124, 39);
            label3.TabIndex = 16;
            label3.Text = "Mã sinh viên:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(239, 100);
            label2.Name = "label2";
            label2.Size = new Size(135, 39);
            label2.TabIndex = 15;
            label2.Text = "Tên sinh viên:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtKhoaHoc
            // 
            txtKhoaHoc.Location = new Point(384, 274);
            txtKhoaHoc.Name = "txtKhoaHoc";
            txtKhoaHoc.Size = new Size(236, 27);
            txtKhoaHoc.TabIndex = 26;
            // 
            // btRefesh
            // 
            btRefesh.Location = new Point(302, 449);
            btRefesh.Name = "btRefesh";
            btRefesh.Size = new Size(94, 29);
            btRefesh.TabIndex = 27;
            btRefesh.Text = "Refesh";
            btRefesh.UseVisualStyleBackColor = true;
            btRefesh.Click += btRefesh_Click;
            // 
            // btSavett
            // 
            btSavett.Location = new Point(421, 449);
            btSavett.Name = "btSavett";
            btSavett.Size = new Size(116, 29);
            btSavett.TabIndex = 28;
            btSavett.Text = "Lưu thông tin";
            btSavett.UseVisualStyleBackColor = true;
            btSavett.Click += btSavett_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(560, 449);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 29);
            btExit.TabIndex = 29;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(682, 506);
            Controls.Add(btExit);
            Controls.Add(btSavett);
            Controls.Add(btRefesh);
            Controls.Add(txtKhoaHoc);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtCoSo);
            Controls.Add(txtMaSV);
            Controls.Add(txtTenSV);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtCoSo;
        private TextBox txtMaSV;
        private TextBox txtTenSV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtKhoaHoc;
        private Button btRefesh;
        private Button btSavett;
        private Button btExit;
    }
}