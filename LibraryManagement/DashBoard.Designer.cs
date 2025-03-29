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
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, sinhToolStripMenuItem, báoCáoVấnToolStripMenuItem, trảToolStripMenuItem, completeBookDetailToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmSáchToolStripMenuItem, xemDanhSáchSáchToolStripMenuItem });
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(54, 24);
            booksToolStripMenuItem.Text = "Sách";
            // 
            // thêmSáchToolStripMenuItem
            // 
            thêmSáchToolStripMenuItem.Name = "thêmSáchToolStripMenuItem";
            thêmSáchToolStripMenuItem.Size = new Size(224, 26);
            thêmSáchToolStripMenuItem.Text = "Thêm sách mới";
            // 
            // xemDanhSáchSáchToolStripMenuItem
            // 
            xemDanhSáchSáchToolStripMenuItem.Name = "xemDanhSáchSáchToolStripMenuItem";
            xemDanhSáchSáchToolStripMenuItem.Size = new Size(224, 26);
            xemDanhSáchSáchToolStripMenuItem.Text = "Xem thông tin sách";
            // 
            // sinhToolStripMenuItem
            // 
            sinhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmSinhToolStripMenuItem, xemDanhSáchSinhViênToolStripMenuItem });
            sinhToolStripMenuItem.Name = "sinhToolStripMenuItem";
            sinhToolStripMenuItem.Size = new Size(82, 24);
            sinhToolStripMenuItem.Text = "Sinh viên";
            // 
            // thêmSinhToolStripMenuItem
            // 
            thêmSinhToolStripMenuItem.Name = "thêmSinhToolStripMenuItem";
            thêmSinhToolStripMenuItem.Size = new Size(245, 26);
            thêmSinhToolStripMenuItem.Text = "Thêm sinh ";
            // 
            // xemDanhSáchSinhViênToolStripMenuItem
            // 
            xemDanhSáchSinhViênToolStripMenuItem.Name = "xemDanhSáchSinhViênToolStripMenuItem";
            xemDanhSáchSinhViênToolStripMenuItem.Size = new Size(245, 26);
            xemDanhSáchSinhViênToolStripMenuItem.Text = "xem thông tin sinh viên";
            // 
            // báoCáoVấnToolStripMenuItem
            // 
            báoCáoVấnToolStripMenuItem.Name = "báoCáoVấnToolStripMenuItem";
            báoCáoVấnToolStripMenuItem.Size = new Size(129, 24);
            báoCáoVấnToolStripMenuItem.Text = "Báo cáo vấn đề ";
            // 
            // trảToolStripMenuItem
            // 
            trảToolStripMenuItem.Name = "trảToolStripMenuItem";
            trảToolStripMenuItem.Size = new Size(76, 24);
            trảToolStripMenuItem.Text = "Trả sách";
            // 
            // completeBookDetailToolStripMenuItem
            // 
            completeBookDetailToolStripMenuItem.Name = "completeBookDetailToolStripMenuItem";
            completeBookDetailToolStripMenuItem.Size = new Size(168, 24);
            completeBookDetailToolStripMenuItem.Text = "Complete book detail";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(61, 24);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DashBoard";
            Text = "DashBoard";
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