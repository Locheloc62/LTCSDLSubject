using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class DataProvider
    {
        private SqlConnection cn;
        public DataProvider()
        {
            string cnstr= @"Data Source=.;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
            cn = new SqlConnection(cnstr);
            
        }
        public void Connect()
        {
            try
            {
                if (cn != null && cn.State==ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public void DisConnect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //private bool Login(string user,string pass)
        //{
        //    string sql = "SELECT COUNT()";
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.ExecuteScalar();
        //}
        public object MyExcuteScalar(string sql,CommandType type)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                return (cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        public SqlDataReader MyExecuteReader(string sql,CommandType type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                return cmd.ExecuteReader();
            }
            catch (SqlException ex )
            {

                throw ex;
            }
        }
    }
}

