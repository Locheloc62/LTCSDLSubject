using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Registration : Form
    {
        public SqlConnection con = new SqlConnection();

        public Registration()
        {
            InitializeComponent();
        }

        private void btRegis_Click(object sender, EventArgs e)
        {

            String rname = txtName.Text;
            String ruser = txtUser.Text;
            String rpass = txtPass.Text;
            String rpassword = txtrepass.Text;
            String remail = txtEmail.Text;
            if (txtUser.Text == "" && txtUser.Text == "" && txtPass.Text == "" && txtrepass.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Hãy nhập vào ô trống!");
            }
            else if (rpass != rpassword)
            {
                MessageBox.Show("Mật khẩu không khớp", " vui lòng nhập lại!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Insert into LoginTable values (N'" + ruser + "','" + rpass + "','" + rname + "','" + remail + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Tạo tài khoản thành công", "Sucessed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtUser.Clear();
                txtPass.Clear();
                txtrepass.Clear();
                txtEmail.Clear();

                LoginLibrary lg = new LoginLibrary();
                lg.Show();
                this.Hide();
            }
        }

        private void HidePassWordRegis_CheckedChanged(object sender, EventArgs e)
        {
            if (HidePassWordRegis.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtrepass.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Ẩn mật khẩu";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtrepass.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Hiện Mật khẩu";
            }
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtrepass.UseSystemPasswordChar = true;
            HidePassWordRegis.Text = "Hiện mật khẩu";
        }
    }
}
