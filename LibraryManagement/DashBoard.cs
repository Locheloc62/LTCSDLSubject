using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự mốn thoát chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thêmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSach themSach = new ThemSach();
            themSach.Show();
        }

        private void xemDanhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void thêmSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addstuednt = new AddStudent();
            addstuednt.Show();
        }

        private void xemDanhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation vSI = new ViewStudentInformation();
            vSI.Show();
        }

        private void báoCáoVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks isb=new IssueBooks();
            isb.Show();
        }
    }
}
