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
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString= @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from ISBook where book_return_date is null";
            SqlDataAdapter da1=new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            cmd.CommandText = "select * from ISBook where book_return_date is not null";
            SqlDataAdapter da2=new SqlDataAdapter(cmd);
            DataSet ds2=new DataSet();
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];

        }
    }
}
