namespace LibraryManagement
{
    partial class ViewStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInformation));
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btVSRefresh = new Button();
            txtRefeshMSV = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtVNamHoc = new TextBox();
            btVSCancel = new Button();
            btVSDelete = new Button();
            btVSUpdate = new Button();
            txtVEmail = new TextBox();
            txtVSDT = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtVCoSo = new TextBox();
            txtVMaSV = new TextBox();
            label5 = new Label();
            txtVTenSV = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 166);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(412, 64);
            label9.Name = "label9";
            label9.Size = new Size(240, 52);
            label9.TabIndex = 2;
            label9.Text = "Sinh viên";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(377, 14);
            label1.Name = "label1";
            label1.Size = new Size(257, 61);
            label1.TabIndex = 1;
            label1.Text = "Thông tin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btVSRefresh
            // 
            btVSRefresh.FlatStyle = FlatStyle.Popup;
            btVSRefresh.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btVSRefresh.Location = new Point(637, 184);
            btVSRefresh.Name = "btVSRefresh";
            btVSRefresh.Size = new Size(95, 32);
            btVSRefresh.TabIndex = 16;
            btVSRefresh.Text = "Refresh";
            btVSRefresh.UseVisualStyleBackColor = true;
            btVSRefresh.Click += btVSRefresh_Click;
            // 
            // txtRefeshMSV
            // 
            txtRefeshMSV.Location = new Point(379, 188);
            txtRefeshMSV.Name = "txtRefeshMSV";
            txtRefeshMSV.Size = new Size(236, 27);
            txtRefeshMSV.TabIndex = 15;
            txtRefeshMSV.TextChanged += txtRefeshMSV_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 181);
            label2.Name = "label2";
            label2.Size = new Size(165, 39);
            label2.TabIndex = 14;
            label2.Text = "Mã sinh viên:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 264);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(txtVNamHoc);
            panel2.Controls.Add(btVSCancel);
            panel2.Controls.Add(btVSDelete);
            panel2.Controls.Add(btVSUpdate);
            panel2.Controls.Add(txtVEmail);
            panel2.Controls.Add(txtVSDT);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtVCoSo);
            panel2.Controls.Add(txtVMaSV);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtVTenSV);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 497);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 223);
            panel2.TabIndex = 18;
            // 
            // txtVNamHoc
            // 
            txtVNamHoc.Location = new Point(650, 20);
            txtVNamHoc.Name = "txtVNamHoc";
            txtVNamHoc.Size = new Size(236, 27);
            txtVNamHoc.TabIndex = 41;
            // 
            // btVSCancel
            // 
            btVSCancel.FlatStyle = FlatStyle.Popup;
            btVSCancel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btVSCancel.Location = new Point(748, 178);
            btVSCancel.Name = "btVSCancel";
            btVSCancel.Size = new Size(95, 32);
            btVSCancel.TabIndex = 45;
            btVSCancel.Text = "Cancel";
            btVSCancel.UseVisualStyleBackColor = true;
            btVSCancel.Click += btVSCancel_Click;
            // 
            // btVSDelete
            // 
            btVSDelete.FlatStyle = FlatStyle.Popup;
            btVSDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btVSDelete.Location = new Point(616, 178);
            btVSDelete.Name = "btVSDelete";
            btVSDelete.Size = new Size(95, 32);
            btVSDelete.TabIndex = 44;
            btVSDelete.Text = "Delete";
            btVSDelete.UseVisualStyleBackColor = true;
            btVSDelete.Click += btVSDelete_Click;
            // 
            // btVSUpdate
            // 
            btVSUpdate.FlatStyle = FlatStyle.Popup;
            btVSUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btVSUpdate.Location = new Point(484, 178);
            btVSUpdate.Name = "btVSUpdate";
            btVSUpdate.Size = new Size(95, 32);
            btVSUpdate.TabIndex = 43;
            btVSUpdate.Text = "Update";
            btVSUpdate.UseVisualStyleBackColor = true;
            btVSUpdate.Click += btVSUpdate_Click;
            // 
            // txtVEmail
            // 
            txtVEmail.Location = new Point(650, 130);
            txtVEmail.Name = "txtVEmail";
            txtVEmail.Size = new Size(236, 27);
            txtVEmail.TabIndex = 41;
            // 
            // txtVSDT
            // 
            txtVSDT.Location = new Point(650, 77);
            txtVSDT.Name = "txtVSDT";
            txtVSDT.Size = new Size(236, 27);
            txtVSDT.TabIndex = 40;
            // 
            // label6
            // 
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(509, 123);
            label6.Name = "label6";
            label6.Size = new Size(135, 39);
            label6.TabIndex = 39;
            label6.Text = "Email:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(495, 70);
            label7.Name = "label7";
            label7.Size = new Size(157, 39);
            label7.TabIndex = 38;
            label7.Text = "Số điện thoại:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(510, 13);
            label8.Name = "label8";
            label8.Size = new Size(124, 39);
            label8.TabIndex = 37;
            label8.Text = "Năm học:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVCoSo
            // 
            txtVCoSo.Location = new Point(187, 130);
            txtVCoSo.Name = "txtVCoSo";
            txtVCoSo.Size = new Size(236, 27);
            txtVCoSo.TabIndex = 36;
            // 
            // txtVMaSV
            // 
            txtVMaSV.Location = new Point(187, 77);
            txtVMaSV.Name = "txtVMaSV";
            txtVMaSV.Size = new Size(236, 27);
            txtVMaSV.TabIndex = 35;
            // 
            // label5
            // 
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 13);
            label5.Name = "label5";
            label5.Size = new Size(135, 39);
            label5.TabIndex = 31;
            label5.Text = "Tên sinh viên:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVTenSV
            // 
            txtVTenSV.Location = new Point(187, 20);
            txtVTenSV.Name = "txtVTenSV";
            txtVTenSV.Size = new Size(236, 27);
            txtVTenSV.TabIndex = 34;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 65);
            label3.Name = "label3";
            label3.Size = new Size(124, 39);
            label3.TabIndex = 32;
            label3.Text = "Mã sinh viên:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 118);
            label4.Name = "label4";
            label4.Size = new Size(135, 39);
            label4.TabIndex = 33;
            label4.Text = "Cơ sở:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewStudentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(968, 732);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btVSRefresh);
            Controls.Add(txtRefeshMSV);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStudentInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentInformation";
            Load += ViewStudentInformation_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btVSRefresh;
        private TextBox txtRefeshMSV;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtVEmail;
        private TextBox txtVSDT;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtVCoSo;
        private TextBox txtVMaSV;
        private Label label5;
        private TextBox txtVTenSV;
        private Label label3;
        private Label label4;
        private TextBox txtVNamHoc;
        private Button btVSCancel;
        private Button btVSDelete;
        private Button btVSUpdate;
        private Label label9;
    }
}