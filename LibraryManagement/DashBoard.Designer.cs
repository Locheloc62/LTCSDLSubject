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
            thêmSáchToolStripMenuItem = new ToolStripMenuItem();
            xemDanhSáchSáchToolStripMenuItem = new ToolStripMenuItem();
            sinhToolStripMenuItem = new ToolStripMenuItem();
            thêmSinhToolStripMenuItem = new ToolStripMenuItem();
            xemDanhSáchSinhViênToolStripMenuItem = new ToolStripMenuItem();
            báoCáoVấnToolStripMenuItem = new ToolStripMenuItem();
            trảToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, sinhToolStripMenuItem, báoCáoVấnToolStripMenuItem, trảToolStripMenuItem, completeBookDetailToolStripMenuItem, thoátToolStripMenuItem });
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
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmSáchToolStripMenuItem, xemDanhSáchSáchToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(104, 54);
            booksToolStripMenuItem.Text = "Sách";
            // 
            // thêmSáchToolStripMenuItem
            // 
            thêmSáchToolStripMenuItem.Image = (Image)resources.GetObject("thêmSáchToolStripMenuItem.Image");
            thêmSáchToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            thêmSáchToolStripMenuItem.Name = "thêmSáchToolStripMenuItem";
            thêmSáchToolStripMenuItem.Size = new Size(249, 56);
            thêmSáchToolStripMenuItem.Text = "Thêm sách mới";
            thêmSáchToolStripMenuItem.Click += thêmSáchToolStripMenuItem_Click;
            // 
            // xemDanhSáchSáchToolStripMenuItem
            // 
            xemDanhSáchSáchToolStripMenuItem.Image = (Image)resources.GetObject("xemDanhSáchSáchToolStripMenuItem.Image");
            xemDanhSáchSáchToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            xemDanhSáchSáchToolStripMenuItem.Name = "xemDanhSáchSáchToolStripMenuItem";
            xemDanhSáchSáchToolStripMenuItem.Size = new Size(249, 56);
            xemDanhSáchSáchToolStripMenuItem.Text = "Xem thông tin sách";
            xemDanhSáchSáchToolStripMenuItem.Click += xemDanhSáchSáchToolStripMenuItem_Click;
            // 
            // sinhToolStripMenuItem
            // 
            sinhToolStripMenuItem.BackColor = Color.OldLace;
            sinhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmSinhToolStripMenuItem, xemDanhSáchSinhViênToolStripMenuItem });
            sinhToolStripMenuItem.Image = (Image)resources.GetObject("sinhToolStripMenuItem.Image");
            sinhToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sinhToolStripMenuItem.Name = "sinhToolStripMenuItem";
            sinhToolStripMenuItem.Size = new Size(132, 54);
            sinhToolStripMenuItem.Text = "Sinh viên";
            // 
            // thêmSinhToolStripMenuItem
            // 
            thêmSinhToolStripMenuItem.Image = (Image)resources.GetObject("thêmSinhToolStripMenuItem.Image");
            thêmSinhToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            thêmSinhToolStripMenuItem.Name = "thêmSinhToolStripMenuItem";
            thêmSinhToolStripMenuItem.Size = new Size(275, 56);
            thêmSinhToolStripMenuItem.Text = "Thêm sinh ";
            thêmSinhToolStripMenuItem.Click += thêmSinhToolStripMenuItem_Click;
            // 
            // xemDanhSáchSinhViênToolStripMenuItem
            // 
            xemDanhSáchSinhViênToolStripMenuItem.Image = (Image)resources.GetObject("xemDanhSáchSinhViênToolStripMenuItem.Image");
            xemDanhSáchSinhViênToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            xemDanhSáchSinhViênToolStripMenuItem.Name = "xemDanhSáchSinhViênToolStripMenuItem";
            xemDanhSáchSinhViênToolStripMenuItem.Size = new Size(275, 56);
            xemDanhSáchSinhViênToolStripMenuItem.Text = "xem thông tin sinh viên";
            xemDanhSáchSinhViênToolStripMenuItem.Click += xemDanhSáchSinhViênToolStripMenuItem_Click;
            // 
            // báoCáoVấnToolStripMenuItem
            // 
            báoCáoVấnToolStripMenuItem.BackColor = Color.Wheat;
            báoCáoVấnToolStripMenuItem.Image = (Image)resources.GetObject("báoCáoVấnToolStripMenuItem.Image");
            báoCáoVấnToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            báoCáoVấnToolStripMenuItem.Name = "báoCáoVấnToolStripMenuItem";
            báoCáoVấnToolStripMenuItem.Size = new Size(179, 54);
            báoCáoVấnToolStripMenuItem.Text = "Báo cáo vấn đề ";
            báoCáoVấnToolStripMenuItem.Click += báoCáoVấnToolStripMenuItem_Click;
            // 
            // trảToolStripMenuItem
            // 
            trảToolStripMenuItem.BackColor = Color.OldLace;
            trảToolStripMenuItem.Image = (Image)resources.GetObject("trảToolStripMenuItem.Image");
            trảToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            trảToolStripMenuItem.Name = "trảToolStripMenuItem";
            trảToolStripMenuItem.Size = new Size(126, 54);
            trảToolStripMenuItem.Text = "Trả sách";
            // 
            // completeBookDetailToolStripMenuItem
            // 
            completeBookDetailToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailToolStripMenuItem.Image");
            completeBookDetailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailToolStripMenuItem.Name = "completeBookDetailToolStripMenuItem";
            completeBookDetailToolStripMenuItem.Size = new Size(218, 54);
            completeBookDetailToolStripMenuItem.Text = "Complete book detail";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.BackColor = Color.OldLace;
            thoátToolStripMenuItem.Image = (Image)resources.GetObject("thoátToolStripMenuItem.Image");
            thoátToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(111, 54);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
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
        private ToolStripMenuItem thêmSáchToolStripMenuItem;
        private ToolStripMenuItem xemDanhSáchSáchToolStripMenuItem;
        private ToolStripMenuItem sinhToolStripMenuItem;
        private ToolStripMenuItem thêmSinhToolStripMenuItem;
        private ToolStripMenuItem xemDanhSáchSinhViênToolStripMenuItem;
        private ToolStripMenuItem báoCáoVấnToolStripMenuItem;
        private ToolStripMenuItem trảToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}