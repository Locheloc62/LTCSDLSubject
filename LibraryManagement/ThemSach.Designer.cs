namespace LibraryManagement
{
    partial class ThemSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSach));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btCancle = new Button();
            btSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtChatLuong = new TextBox();
            txtGia = new TextBox();
            txtXB = new TextBox();
            txtTG = new TextBox();
            txtTen = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 73);
            panel1.TabIndex = 1;
   
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 10);
            label1.Name = "label1";
            label1.Size = new Size(153, 50);
            label1.TabIndex = 1;
            label1.Text = "Thêm sách";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(242, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(btCancle);
            panel2.Controls.Add(btSave);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtChatLuong);
            panel2.Controls.Add(txtGia);
            panel2.Controls.Add(txtXB);
            panel2.Controls.Add(txtTG);
            panel2.Controls.Add(txtTen);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(271, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 393);
            panel2.TabIndex = 2;
            // 
            // btCancle
            // 
            btCancle.FlatStyle = FlatStyle.Popup;
            btCancle.Location = new Point(295, 338);
            btCancle.Name = "btCancle";
            btCancle.Size = new Size(118, 38);
            btCancle.TabIndex = 17;
            btCancle.Text = "Cancle";
            btCancle.UseVisualStyleBackColor = true;
            btCancle.Click += btCancle_Click;
            // 
            // btSave
            // 
            btSave.FlatStyle = FlatStyle.Popup;
            btSave.Location = new Point(163, 338);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 38);
            btSave.TabIndex = 15;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // txtChatLuong
            // 
            txtChatLuong.Location = new Point(163, 294);
            txtChatLuong.Name = "txtChatLuong";
            txtChatLuong.Size = new Size(236, 27);
            txtChatLuong.TabIndex = 13;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(163, 246);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(236, 27);
            txtGia.TabIndex = 12;
            // 
            // txtXB
            // 
            txtXB.Location = new Point(163, 135);
            txtXB.Name = "txtXB";
            txtXB.Size = new Size(236, 27);
            txtXB.TabIndex = 11;
            // 
            // txtTG
            // 
            txtTG.Location = new Point(163, 82);
            txtTG.Name = "txtTG";
            txtTG.Size = new Size(236, 27);
            txtTG.TabIndex = 10;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(163, 25);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(236, 27);
            txtTen.TabIndex = 9;
            // 
            // label7
            // 
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 287);
            label7.Name = "label7";
            label7.Size = new Size(157, 39);
            label7.TabIndex = 8;
            label7.Text = "Chất lượng sách:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 234);
            label6.Name = "label6";
            label6.Size = new Size(111, 39);
            label6.TabIndex = 7;
            label6.Text = "Giá sách:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 185);
            label5.Name = "label5";
            label5.Size = new Size(135, 39);
            label5.TabIndex = 6;
            label5.Text = "Ngày mượn:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 128);
            label4.Name = "label4";
            label4.Size = new Size(135, 39);
            label4.TabIndex = 5;
            label4.Text = "Mã xuất bản:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 70);
            label3.Name = "label3";
            label3.Size = new Size(124, 39);
            label3.TabIndex = 4;
            label3.Text = "Tên tác giả:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 18);
            label2.Name = "label2";
            label2.Size = new Size(100, 39);
            label2.TabIndex = 3;
            label2.Text = "Tên sách:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ThemSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 460);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemSach";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtTen;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtChatLuong;
        private TextBox txtGia;
        private TextBox txtXB;
        private TextBox txtTG;
        private Button btCancle;
        private Button btSave;
    }
}