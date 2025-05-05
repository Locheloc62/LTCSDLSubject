using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TransferObject;

namespace DataLayer
{
    public class LoginDL:DataProvider
    {
        public bool Login(Account account)
        {
            string sql = "SELECT COUNT(Username) FROM Users WHERE Username ='"+account.userName+"' and Password ='"+account.password+"'";
            try
            { 
               return (int)MyExcuteScalar(sql, CommandType.Text)>0;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
