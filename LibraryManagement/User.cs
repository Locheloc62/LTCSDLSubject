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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        Form currentChildForm = null;
        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            // Nếu đang có form con nào mở thì đóng nó
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;      // Cập nhật form con đang mở
            childForm.StartPosition = FormStartPosition.CenterScreen; // Cho đẹp
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(childForm);
            childForm.Show();

            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
        }
    
        private void btBookInfor_Click(object sender, EventArgs e)
        {
         
            OpenChildForm(new ViewBook()); 
           
        }
     
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự mốn thoát chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
    }
}
