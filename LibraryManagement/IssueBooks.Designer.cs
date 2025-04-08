namespace LibraryManagement
{
    partial class IssueBooks
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            comboBoxBooks = new ComboBox();
            label9 = new Label();
            btIssueBook = new Button();
            dateTimePicker = new DateTimePicker();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtSem = new TextBox();
            txtDep = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            btExit = new Button();
            btRefresh = new Button();
            pictureBox1 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            btSearch = new Button();
            txtEnrollment = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(329, 51);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 2;
            label1.Text = " Issue Books";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(152, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(comboBoxBooks);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btIssueBook);
            panel2.Controls.Add(dateTimePicker);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtSem);
            panel2.Controls.Add(txtDep);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(290, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 459);
            panel2.TabIndex = 1;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(158, 300);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(222, 28);
            comboBoxBooks.TabIndex = 24;
            // 
            // label9
            // 
            label9.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label9.Location = new Point(-5, 294);
            label9.Name = "label9";
            label9.Size = new Size(147, 39);
            label9.TabIndex = 23;
            label9.Text = "Book Name:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btIssueBook
            // 
            btIssueBook.FlatStyle = FlatStyle.Popup;
            btIssueBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btIssueBook.Location = new Point(245, 413);
            btIssueBook.Name = "btIssueBook";
            btIssueBook.Size = new Size(135, 38);
            btIssueBook.TabIndex = 19;
            btIssueBook.Text = " Issue Book";
            btIssueBook.UseVisualStyleBackColor = true;
            btIssueBook.Click += btIssueBook_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(158, 356);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(222, 27);
            dateTimePicker.TabIndex = 12;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(158, 202);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(222, 27);
            txtContact.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(222, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtSem
            // 
            txtSem.Location = new Point(158, 139);
            txtSem.Name = "txtSem";
            txtSem.ReadOnly = true;
            txtSem.Size = new Size(222, 27);
            txtSem.TabIndex = 11;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(158, 87);
            txtDep.Name = "txtDep";
            txtDep.ReadOnly = true;
            txtDep.Size = new Size(222, 27);
            txtDep.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 30);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(222, 27);
            txtName.TabIndex = 9;
            // 
            // label7
            // 
            label7.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label7.Location = new Point(-15, 352);
            label7.Name = "label7";
            label7.Size = new Size(157, 39);
            label7.TabIndex = 21;
            label7.Text = " Book Issue Date:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label6.Location = new Point(-5, 239);
            label6.Name = "label6";
            label6.Size = new Size(147, 39);
            label6.TabIndex = 20;
            label6.Text = "Student Email:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label5.Location = new Point(-5, 190);
            label5.Name = "label5";
            label5.Size = new Size(147, 39);
            label5.TabIndex = 18;
            label5.Text = "Student Contact:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label4.Location = new Point(-5, 133);
            label4.Name = "label4";
            label4.Size = new Size(157, 39);
            label4.TabIndex = 17;
            label4.Text = "Student Semester:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label3.Location = new Point(-5, 75);
            label3.Name = "label3";
            label3.Size = new Size(124, 39);
            label3.TabIndex = 15;
            label3.Text = "Department:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            label8.Location = new Point(-5, 23);
            label8.Name = "label8";
            label8.Size = new Size(135, 39);
            label8.TabIndex = 13;
            label8.Text = "Student name:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(btExit);
            panel3.Controls.Add(btRefresh);
            panel3.Controls.Add(btSearch);
            panel3.Controls.Add(txtEnrollment);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(12, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 459);
            panel3.TabIndex = 0;
            // 
            // btExit
            // 
            btExit.FlatStyle = FlatStyle.Popup;
            btExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btExit.Location = new Point(141, 356);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 38);
            btExit.TabIndex = 0;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btRefresh
            // 
            btRefresh.FlatStyle = FlatStyle.Popup;
            btRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btRefresh.Location = new Point(20, 356);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(94, 38);
            btRefresh.TabIndex = 0;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btSearch
            // 
            btSearch.FlatStyle = FlatStyle.Popup;
            btSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btSearch.Location = new Point(45, 230);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(147, 39);
            btSearch.TabIndex = 0;
            btSearch.Text = "Tìm kiếm sinh viên";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(20, 187);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(215, 27);
            txtEnrollment.TabIndex = 0;
            txtEnrollment.TextChanged += txtEnrollment_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 145);
            label2.Name = "label2";
            label2.Size = new Size(238, 39);
            label2.TabIndex = 0;
            label2.Text = "Xác nhận mã sinh viên";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 606);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btExit;
        private Button btRefresh;
        private Label label9;
        private Button btIssueBook;
        private DateTimePicker dateTimePicker;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtSem;
        private TextBox txtDep;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private ComboBox comboBoxBooks;
        private BindingSource bindingSource1;
        private Button btSearch;
        private TextBox txtEnrollment;
        private Label label2;
    }
}