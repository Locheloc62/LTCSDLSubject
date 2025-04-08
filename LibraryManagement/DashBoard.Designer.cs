namespace LibraryManagement
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            AddBookToolStripMenuItem = new ToolStripMenuItem();
            ViewBookToolStripMenuItem = new ToolStripMenuItem();
            StudentToolStripMenuItem = new ToolStripMenuItem();
            AddStudentToolStripMenuItem = new ToolStripMenuItem();
            ViewStudentToolStripMenuItem = new ToolStripMenuItem();
            IssueBookToolStripMenuItem = new ToolStripMenuItem();
            ReturnToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, StudentToolStripMenuItem, IssueBookToolStripMenuItem, ReturnToolStripMenuItem, completeBookDetailToolStripMenuItem, ExitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(913, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.Wheat;
            booksToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddBookToolStripMenuItem, ViewBookToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(104, 54);
            booksToolStripMenuItem.Text = "Sách";
            // 
            // AddBookToolStripMenuItem
            // 
            AddBookToolStripMenuItem.Image = (Image)resources.GetObject("AddBookToolStripMenuItem.Image");
            AddBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem";
            AddBookToolStripMenuItem.Size = new Size(254, 56);
            AddBookToolStripMenuItem.Text = "Thêm sách mới";
            AddBookToolStripMenuItem.Click += thêmSáchToolStripMenuItem_Click;
            // 
            // ViewBookToolStripMenuItem
            // 
            ViewBookToolStripMenuItem.Image = (Image)resources.GetObject("ViewBookToolStripMenuItem.Image");
            ViewBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ViewBookToolStripMenuItem.Name = "ViewBookToolStripMenuItem";
            ViewBookToolStripMenuItem.Size = new Size(254, 56);
            ViewBookToolStripMenuItem.Text = "Xem thông tin sách";
            ViewBookToolStripMenuItem.Click += xemDanhSáchSáchToolStripMenuItem_Click;
            // 
            // StudentToolStripMenuItem
            // 
            StudentToolStripMenuItem.BackColor = Color.OldLace;
            StudentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddStudentToolStripMenuItem, ViewStudentToolStripMenuItem });
            StudentToolStripMenuItem.Image = (Image)resources.GetObject("StudentToolStripMenuItem.Image");
            StudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            StudentToolStripMenuItem.Name = "StudentToolStripMenuItem";
            StudentToolStripMenuItem.Size = new Size(132, 54);
            StudentToolStripMenuItem.Text = "Sinh viên";
            // 
            // AddStudentToolStripMenuItem
            // 
            AddStudentToolStripMenuItem.Image = (Image)resources.GetObject("AddStudentToolStripMenuItem.Image");
            AddStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem";
            AddStudentToolStripMenuItem.Size = new Size(275, 56);
            AddStudentToolStripMenuItem.Text = "Thêm sinh ";
            AddStudentToolStripMenuItem.Click += thêmSinhToolStripMenuItem_Click;
            // 
            // ViewStudentToolStripMenuItem
            // 
            ViewStudentToolStripMenuItem.Image = (Image)resources.GetObject("ViewStudentToolStripMenuItem.Image");
            ViewStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ViewStudentToolStripMenuItem.Name = "ViewStudentToolStripMenuItem";
            ViewStudentToolStripMenuItem.Size = new Size(275, 56);
            ViewStudentToolStripMenuItem.Text = "xem thông tin sinh viên";
            ViewStudentToolStripMenuItem.Click += xemDanhSáchSinhViênToolStripMenuItem_Click;
            // 
            // IssueBookToolStripMenuItem
            // 
            IssueBookToolStripMenuItem.BackColor = Color.Wheat;
            IssueBookToolStripMenuItem.Image = (Image)resources.GetObject("IssueBookToolStripMenuItem.Image");
            IssueBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            IssueBookToolStripMenuItem.Name = "IssueBookToolStripMenuItem";
            IssueBookToolStripMenuItem.Size = new Size(207, 54);
            IssueBookToolStripMenuItem.Text = "Biên bản mượn sách";
            IssueBookToolStripMenuItem.Click += báoCáoVấnToolStripMenuItem_Click;
            // 
            // ReturnToolStripMenuItem
            // 
            ReturnToolStripMenuItem.BackColor = Color.OldLace;
            ReturnToolStripMenuItem.Image = (Image)resources.GetObject("ReturnToolStripMenuItem.Image");
            ReturnToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem";
            ReturnToolStripMenuItem.Size = new Size(126, 54);
            ReturnToolStripMenuItem.Text = "Trả sách";
            ReturnToolStripMenuItem.Click += trảToolStripMenuItem_Click;
            // 
            // completeBookDetailToolStripMenuItem
            // 
            completeBookDetailToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailToolStripMenuItem.Image");
            completeBookDetailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailToolStripMenuItem.Name = "completeBookDetailToolStripMenuItem";
            completeBookDetailToolStripMenuItem.Size = new Size(175, 54);
            completeBookDetailToolStripMenuItem.Text = "Chi tiết trả sách";
            completeBookDetailToolStripMenuItem.Click += completeBookDetailToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.BackColor = Color.OldLace;
            ExitToolStripMenuItem.Image = (Image)resources.GetObject("ExitToolStripMenuItem.Image");
            ExitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(111, 54);
            ExitToolStripMenuItem.Text = "Thoát";
            ExitToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(913, 458);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "DashBoard";
            Text = "DashBoard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem AddBookToolStripMenuItem;
        private ToolStripMenuItem ViewBookToolStripMenuItem;
        private ToolStripMenuItem StudentToolStripMenuItem;
        private ToolStripMenuItem AddStudentToolStripMenuItem;
        private ToolStripMenuItem ViewStudentToolStripMenuItem;
        private ToolStripMenuItem IssueBookToolStripMenuItem;
        private ToolStripMenuItem ReturnToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
    }
}