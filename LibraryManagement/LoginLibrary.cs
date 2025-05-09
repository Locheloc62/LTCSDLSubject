﻿using System.Data;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Data.SqlClient;

namespace LibraryManagement
{
    
    public partial class LoginLibrary : Form
    {
        //Account taikhoan=new Account();
        //AccountBLL tkbll=new AccountBLL();

        public SqlConnection con = null;
        private bool isLoginClicked = false;
        public SqlCommand cmd;
        public LoginLibrary()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LoginLibrary_KeyDown);
            this.KeyDown += new KeyEventHandler(btClose_KeyDown);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Clear();
            }
        }  
        private void PerformLogin_Admin()
        {
            isLoginClicked = true;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                
                

                    cmd.CommandText = "select * from loginTable where username ='" + txtUser.Text + "' and pass ='" + txtPass.Text + "' and role_user= 'admin'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        this.Hide();
                        DashBoard dashboard = new DashBoard();
                        dashboard.Show();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.Retry)
                        {
                            txtPass.Clear();
                            txtUser.Focus();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }
                }
        }
        
     
        private void PerformLogin_User()
        {
            isLoginClicked = true;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    cmd.CommandText = "select * from loginTable where username ='" + txtUser.Text + "' and pass ='" + txtPass.Text + "' and role_User = 'User'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        this.Hide();
                        User users = new User();
                        users.Show();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.Retry)
                        {
                            txtPass.Clear();
                            txtUser.Focus();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }
                }
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
                   
            if(rdAdmin.Checked)
            {
                isLoginClicked = true;
                PerformLogin_Admin();
            }
            else if(rdUser.Checked)
            {
                isLoginClicked = true;
                PerformLogin_User();
            }
            else
            {
                MessageBox.Show("pls check");
            }
        }
        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Clear();
            }
            // txtPass.PasswordChar = '*';
        }
        private void LoginLibrary_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isLoginClicked && e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                isLoginClicked = true;
                PerformLogin_Admin();
                PerformLogin_User();
            }
        }
        private void LoginLibrary_Load(object sender, EventArgs e)
        {

            txtPass.UseSystemPasswordChar = true;
            HidePassword.Text = "Hiện mật khẩu";
          


        }
        private void HidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (HidePassword.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Ẩn mật khẩu";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Hiện Mật khẩu";
            }
        }
        private void btClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void btSignUp_Click(object sender, EventArgs e)
        {
            Registration dk=new Registration();
            dk.Show();
            this.Hide();
        }
    }
}
