using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            if (MessageBox.Show("Nếu bạn thoát dữ liệu sẽ không có sự cập nhật!", "Bạn chắc chứ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }
        private void txtRefeshMSV_TextChanged(object sender, EventArgs e)
        {

            if (txtRefeshMSV.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("D:/LTCSDL/Liberay Management System Icon and Images/Liberay Management System/search1.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + txtRefeshMSV.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("D:/LTCSDL/Liberay Management System Icon and Images/Liberay Management System/search.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    panel2.Visible = true;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select * from NewStudent where stuid = " + bid + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                    txtVTenSV.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtVMaSV.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtVCoSo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtVNamHoc.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtVSDT.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtVEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Không thể thao tác ngoài khu vực", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Không thể thao tác ngoài khu vực", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btVSUpdate_Click(object sender, EventArgs e)
        {

            string sname = txtVTenSV.Text;
            string enroll = txtVMaSV.Text;
            string dep = txtVCoSo.Text;
            string sem = txtVNamHoc.Text;
            Int64 contact = Int64.Parse(txtVSDT.Text);
            string semail = txtVEmail.Text;
            if (MessageBox.Show("Dữ liệu đã được cập nhật trên hệ thống!", "Thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set sname = N'" + sname + "',enroll=N'" + enroll + "',dep = N'" + dep + "',sem=N'" + sem + "',contact = " + contact + ",email='" + semail + "' where stuid= " + rowid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewStudentInformation_Load(this, null);//tro lai trang chu
            }
        }
        private void btVSRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentInformation_Load(this, null);//tro lai trang chu
        }
        private void btVSDelete_Click(object sender, EventArgs e)
        //Coppy của update sửa lại
        {
            if (MessageBox.Show("Dữ liệu sẽ xóa trên hệ thống!", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where  stuid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewStudentInformation_Load(this, null);//tro lai trang chu
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
