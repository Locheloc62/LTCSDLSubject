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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btSearchStudent_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "select * from ISBook where std_enroll = '" + txtEnterEnroll.Text + "' and book_return_date IS NULL ";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            da.Fill(ds);
                            if (ds.Tables[0].Rows.Count != 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                                dataGridView1.Font = new Font("Segoe UI", 10);
                            }
                            else
                            {
                                dataGridView1.DataSource = null;
                                MessageBox.Show("invalid ID or No Book Issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnterEnroll.Clear();
        }
        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookName.Text = bname;
            txtBookName.Font = new Font("Segoe UI", 10);
            txtBookIssueDate.Text = bdate;
            txtBookIssueDate.Font = new Font("Segoe UI", 10);
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "update ISBook set book_return_date = N'" + DateTimePicker1.Text + "' where std_enroll = N'" + txtEnterEnroll.Text + "' and id = " + rowid + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Return Succesful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnBook_Load(this, null);
                }
            }
        }

        private void txtEnterEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterEnroll.Text != "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnroll.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }
    }
}
