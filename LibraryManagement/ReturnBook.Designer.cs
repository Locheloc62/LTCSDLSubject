namespace LibraryManagement
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            panel1 = new Panel();
            btExit = new Button();
            btRefresh = new Button();
            btSearchStudent = new Button();
            txtEnterEnroll = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btCancle = new Button();
            btReturn = new Button();
            DateTimePicker1 = new DateTimePicker();
            btCancel = new Button();
            btDelete = new Button();
            txtBookName = new TextBox();
            txtBookIssueDate = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btExit);
            panel1.Controls.Add(btRefresh);
            panel1.Controls.Add(btSearchStudent);
            panel1.Controls.Add(txtEnterEnroll);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 368);
            panel1.TabIndex = 0;
            // 
            // btExit
            // 
            btExit.FlatStyle = FlatStyle.Popup;
            btExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btExit.Location = new Point(138, 316);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 38);
            btExit.TabIndex = 4;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btRefresh
            // 
            btRefresh.FlatStyle = FlatStyle.Popup;
            btRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btRefresh.Location = new Point(17, 316);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(95, 38);
            btRefresh.TabIndex = 5;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // btSearchStudent
            // 
            btSearchStudent.FlatStyle = FlatStyle.Popup;
            btSearchStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btSearchStudent.Location = new Point(61, 233);
            btSearchStudent.Name = "btSearchStudent";
            btSearchStudent.Size = new Size(137, 39);
            btSearchStudent.TabIndex = 1;
            btSearchStudent.Text = "Tìm kiếm sinh viên";
            btSearchStudent.UseVisualStyleBackColor = true;
            btSearchStudent.Click += btSearchStudent_Click;
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.Location = new Point(27, 189);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(205, 27);
            txtEnterEnroll.TabIndex = 2;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 147);
            label2.Name = "label2";
            label2.Size = new Size(228, 39);
            label2.TabIndex = 3;
            label2.Text = "Xác nhận mã sinh viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(702, 368);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btCancle);
            panel2.Controls.Add(btReturn);
            panel2.Controls.Add(DateTimePicker1);
            panel2.Controls.Add(btCancel);
            panel2.Controls.Add(btDelete);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(txtBookIssueDate);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(277, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 141);
            panel2.TabIndex = 2;
            // 
            // btCancle
            // 
            btCancle.BackColor = Color.FromArgb(255, 192, 192);
            btCancle.FlatStyle = FlatStyle.Popup;
            btCancle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancle.Location = new Point(527, 86);
            btCancle.Name = "btCancle";
            btCancle.Size = new Size(95, 32);
            btCancle.TabIndex = 33;
            btCancle.Text = "Cancel";
            btCancle.UseVisualStyleBackColor = false;
            btCancle.Click += btCancle_Click;
            // 
            // btReturn
            // 
            btReturn.FlatStyle = FlatStyle.Popup;
            btReturn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btReturn.Location = new Point(527, 36);
            btReturn.Name = "btReturn";
            btReturn.Size = new Size(95, 32);
            btReturn.TabIndex = 32;
            btReturn.Text = "Return";
            btReturn.UseVisualStyleBackColor = true;
            btReturn.Click += btReturn_Click;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Location = new Point(263, 91);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(236, 27);
            DateTimePicker1.TabIndex = 24;
            // 
            // btCancel
            // 
            btCancel.FlatStyle = FlatStyle.Popup;
            btCancel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancel.Location = new Point(440, 167);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(95, 32);
            btCancel.TabIndex = 28;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.FlatStyle = FlatStyle.Popup;
            btDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(309, 167);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(95, 32);
            btDelete.TabIndex = 27;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(263, 15);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(236, 27);
            txtBookName.TabIndex = 26;
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.Location = new Point(263, 54);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.Size = new Size(236, 27);
            txtBookIssueDate.TabIndex = 25;
            // 
            // label6
            // 
            label6.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label6.Location = new Point(111, 87);
            label6.Name = "label6";
            label6.Size = new Size(135, 39);
            label6.TabIndex = 31;
            label6.Text = "Ngày trả sách:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label7.Location = new Point(122, 48);
            label7.Name = "label7";
            label7.Size = new Size(124, 39);
            label7.TabIndex = 30;
            label7.Text = "Ngày báo cáo:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label8.Location = new Point(133, 9);
            label8.Name = "label8";
            label8.Size = new Size(124, 39);
            label8.TabIndex = 29;
            label8.Text = "Tên sách:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1011, 435);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btSearchStudent;
        private TextBox txtEnterEnroll;
        private Label label2;
        private Button btExit;
        private Button btRefresh;
        private DateTimePicker DateTimePicker1;
        private Button btCancel;
        private Button btDelete;
        private TextBox txtBookName;
        private TextBox txtBookIssueDate;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btCancle;
        private Button btReturn;
    }
}