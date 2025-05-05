namespace LibraryManagement
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            panel1 = new Panel();
            btExit = new Button();
            btBookInfor = new Button();
            pnlMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btExit);
            panel1.Controls.Add(btBookInfor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 522);
            panel1.TabIndex = 0;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Red;
            btExit.FlatStyle = FlatStyle.Popup;
            btExit.Font = new Font("Calibri", 12F, FontStyle.Italic);
            btExit.ForeColor = Color.Yellow;
            btExit.Location = new Point(38, 168);
            btExit.Name = "btExit";
            btExit.Size = new Size(161, 91);
            btExit.TabIndex = 2;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btBookInfor
            // 
            btBookInfor.BackColor = Color.Yellow;
            btBookInfor.FlatStyle = FlatStyle.Popup;
            btBookInfor.Font = new Font("Calibri", 12F, FontStyle.Italic);
            btBookInfor.ForeColor = Color.Green;
            btBookInfor.Location = new Point(38, 22);
            btBookInfor.Name = "btBookInfor";
            btBookInfor.Size = new Size(161, 95);
            btBookInfor.TabIndex = 0;
            btBookInfor.Text = "Thông tin sách";
            btBookInfor.UseVisualStyleBackColor = false;
            btBookInfor.Click += btBookInfor_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackgroundImage = (Image)resources.GetObject("pnlMain.BackgroundImage");
            pnlMain.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(250, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(732, 522);
            pnlMain.TabIndex = 1;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 522);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btExit;
        private Button btBookInfor;
        private Panel pnlMain;
    }
}