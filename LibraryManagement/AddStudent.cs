using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryManagement
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();

        }

        private void btSavett_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSV.Text != "" && txtMaSV.Text != "" && txtCoSo.Text != "" && txtKhoaHoc.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
                {
                    string name = txtTenSV.Text;
                    string enroll = txtMaSV.Text;
                    string dep = txtCoSo.Text;
                    string sem = txtKhoaHoc.Text;
                    Int64 mobile = Int64.Parse(txtSDT.Text);
                    string email = txtEmail.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "insert into NewStudent (sname,enroll,dep,sem,contact,email) values (N'" + name + "',N'" + enroll + "',N'" + dep + "',N'" + sem + "'," + mobile + ",'" + email + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Đã lưu thông tin", "Lưu thông tin thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập vào ô trống!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Số điện thoại không được nhập chữ!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            txtTenSV.Clear();
            txtMaSV.Clear();
            txtCoSo.Clear();
            txtKhoaHoc.Clear();
            txtSDT.Clear();
            //txtEmail.Clear();
            txtEmail.Text = "";
        }
    }
}
