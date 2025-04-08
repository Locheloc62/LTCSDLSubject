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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text != "" && txtTG.Text != "" && txtXB.Text != "" && txtGia.Text != "" && txtChatLuong.Text != "")
                {
                    string tenSach = txtTen.Text;
                    string tacGia = txtTG.Text;
                    string xuatBan = txtXB.Text;
                    string ngayMuon = dateTimePicker1.Text;
                    Int64 gia = Int64.Parse(txtGia.Text);
                    Int64 chatLuong = Int64.Parse(txtChatLuong.Text);

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "insert into NewBook values (N'" + tenSach + "',N'" + tacGia + "',N'" + xuatBan + "','" + ngayMuon + "'," + gia + "," + chatLuong + ")";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Đã lưu dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTen.Clear();
                    txtTG.Clear();
                    txtXB.Clear();
                    txtGia.Clear();
                    txtChatLuong.Clear();
                }
                else
                {
                    MessageBox.Show("Không được để trống vui lòng nhập vào ô trống!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập giá và chất lượng là số!!", "Lỗi form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự mốn thoát chứ? Dữ liệu sẽ bị xóa!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
