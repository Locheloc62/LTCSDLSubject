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
        Form currentChildForm = null;
        private void OpenChildForm(Form childForm)
        {
            // Nếu đang có form con nào mở thì đóng nó
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;      // Cập nhật form con đang mở
            childForm.StartPosition = FormStartPosition.CenterScreen; // Cho đẹp
            childForm.Show();
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
            OpenChildForm(new AddBook());

        }

        private void xemDanhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewBook());
        }

        private void thêmSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStudent());
        }

        private void xemDanhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentInformation());
        
        }

        private void báoCáoVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IssueBooks());
        
        }

        private void trảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReturnBook());
        
        }

        private void completeBookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CompleteBookDetails());
        }
    
    }
}
