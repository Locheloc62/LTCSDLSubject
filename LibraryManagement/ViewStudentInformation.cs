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
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void btVSCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRefeshMSV_TextChanged(object sender, EventArgs e)
        {

            if (txtRefeshMSV.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("D:/LTCSDL/Liberay Management System Icon and Images/Liberay Management System/search1.gif");
                pictureBox1.Image = image;
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("D:/LTCSDL/Liberay Management System Icon and Images/Liberay Management System/search.gif");
                pictureBox1.Image = image;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btVSUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
