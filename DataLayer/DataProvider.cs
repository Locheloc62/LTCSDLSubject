using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataTranferObject;

namespace DataLayer
{

    public class DataProvider
    {
        public static SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
            return con;
        }
    }
    public class DatabaseAcess
    {
        public static string checkLogic(Account taikhoan)
        {
            string user = null;
            SqlConnection con = DataProvider.Connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_login",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", taikhoan.uSerName);
            cmd.Parameters.AddWithValue("@password",taikhoan.passWord);
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                while (reader.Read())
                {
                    user = reader.GetString(1);
                    return user;
                }
                reader.Close();
                con.Close();
            }
            else
            {
                return "Tài khoản hoặc mặt khẩu khônng chính xác";
            }
            return user;
        }
    }
}
