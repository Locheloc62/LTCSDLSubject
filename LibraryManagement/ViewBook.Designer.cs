namespace LibraryManagement
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtTen = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btRefresh = new Button();
            panel2 = new Panel();
            dateTimePickervb = new DateTimePicker();
            btCancel = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            txtvbChatLuong = new TextBox();
            txtvbGia = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtvbXB = new TextBox();
            txtvbTG = new TextBox();
            label5 = new Label();
            txtvbTen = new TextBox();
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 134);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(580, 35);
            label1.Name = "label1";
            label1.Size = new Size(305, 63);
            label1.TabIndex = 1;
            label1.Text = "Thông tin sách hiện có";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(436, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(527, 144);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(236, 27);
            txtTen.TabIndex = 0;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(356, 137);
            label2.Name = "label2";
            label2.Size = new Size(100, 39);
            label2.TabIndex = 10;
            label2.Text = "Tên sách:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(11, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1138, 276);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Tên sách";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "tacgia";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 128);
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Tác giả";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "xuatban";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.HeaderText = "Loại sách";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ngaygio";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 192, 128);
            Column5.DefaultCellStyle = dataGridViewCellStyle5;
            Column5.HeaderText = "Ngày mượn";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 250;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "gia";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(224, 224, 224);
            Column6.DefaultCellStyle = dataGridViewCellStyle6;
            Column6.HeaderText = "Giá tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "charluong";
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 192, 128);
            Column7.DefaultCellStyle = dataGridViewCellStyle7;
            Column7.HeaderText = "Chất lượng";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // btRefresh
            // 
            btRefresh.FlatStyle = FlatStyle.Popup;
            btRefresh.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRefresh.Location = new Point(789, 139);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(95, 32);
            btRefresh.TabIndex = 1;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(dateTimePickervb);
            panel2.Controls.Add(btCancel);
            panel2.Controls.Add(btDelete);
            panel2.Controls.Add(btUpdate);
            panel2.Controls.Add(txtvbChatLuong);
            panel2.Controls.Add(txtvbGia);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtvbXB);
            panel2.Controls.Add(txtvbTG);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtvbTen);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 461);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 246);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePickervb
            // 
            dateTimePickervb.Location = new Point(684, 36);
            dateTimePickervb.Name = "dateTimePickervb";
            dateTimePickervb.Size = new Size(236, 27);
            dateTimePickervb.TabIndex = 3;
            // 
            // btCancel
            // 
            btCancel.FlatStyle = FlatStyle.Popup;
            btCancel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancel.Location = new Point(828, 200);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(95, 32);
            btCancel.TabIndex = 8;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btDelete
            // 
            btDelete.FlatStyle = FlatStyle.Popup;
            btDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(697, 200);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(95, 32);
            btDelete.TabIndex = 7;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.FlatStyle = FlatStyle.Popup;
            btUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdate.Location = new Point(567, 200);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(95, 32);
            btUpdate.TabIndex = 6;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtvbChatLuong
            // 
            txtvbChatLuong.Location = new Point(684, 148);
            txtvbChatLuong.Name = "txtvbChatLuong";
            txtvbChatLuong.Size = new Size(236, 27);
            txtvbChatLuong.TabIndex = 5;
            // 
            // txtvbGia
            // 
            txtvbGia.Location = new Point(684, 95);
            txtvbGia.Name = "txtvbGia";
            txtvbGia.Size = new Size(236, 27);
            txtvbGia.TabIndex = 4;
            // 
            // label6
            // 
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(521, 141);
            label6.Name = "label6";
            label6.Size = new Size(135, 39);
            label6.TabIndex = 23;
            label6.Text = "Chất lượng:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(521, 83);
            label7.Name = "label7";
            label7.Size = new Size(124, 39);
            label7.TabIndex = 22;
            label7.Text = "Giá tiền:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(521, 31);
            label8.Name = "label8";
            label8.Size = new Size(124, 39);
            label8.TabIndex = 21;
            label8.Text = "Ngày mượn:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtvbXB
            // 
            txtvbXB.Location = new Point(221, 148);
            txtvbXB.Name = "txtvbXB";
            txtvbXB.Size = new Size(236, 27);
            txtvbXB.TabIndex = 2;
            // 
            // txtvbTG
            // 
            txtvbTG.Location = new Point(221, 95);
            txtvbTG.Name = "txtvbTG";
            txtvbTG.Size = new Size(236, 27);
            txtvbTG.TabIndex = 1;
            // 
            // label5
            // 
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 31);
            label5.Name = "label5";
            label5.Size = new Size(100, 39);
            label5.TabIndex = 15;
            label5.Text = "Tên sách:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtvbTen
            // 
            txtvbTen.Location = new Point(221, 38);
            txtvbTen.Name = "txtvbTen";
            txtvbTen.Size = new Size(236, 27);
            txtvbTen.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 83);
            label3.Name = "label3";
            label3.Size = new Size(124, 39);
            label3.TabIndex = 16;
            label3.Text = "Tên tác giả:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 141);
            label4.Name = "label4";
            label4.Size = new Size(135, 39);
            label4.TabIndex = 17;
            label4.Text = "Mã xuất bản:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1160, 733);
            Controls.Add(panel2);
            Controls.Add(btRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewBook";
            WindowState = FormWindowState.Maximized;
            Load += ViewBook_Load;
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
        private TextBox txtTen;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btRefresh;
        private Panel panel2;
        private Button btCancel;
        private Button btDelete;
        private Button btUpdate;
        private TextBox txtvbChatLuong;
        private TextBox txtvbGia;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtvbXB;
        private TextBox txtvbTG;
        private Label label5;
        private TextBox txtvbTen;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickervb;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}