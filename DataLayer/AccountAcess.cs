using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataTranferObject;
using System.Runtime.Remoting.Messaging;
using System.Data;
using System.Data.Common;

namespace DataLayer
{
    public class AccountAcess
    {
        
        public SqlConnection con = null;
        public SqlCommand cmd;
        private bool isLoginClicked = false;
        public SqlConnection Connect()
        {
            isLoginClicked = true;
            con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
            
            return con;
        }
        public  DataAdapter dataAdap()
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
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
            return da;
        }
    }
}

