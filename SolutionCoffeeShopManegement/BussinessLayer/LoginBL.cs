using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TransferObject; //Lây tầng TFO để lấy Account để lấy user,pass,type
using DataLayer; //Để lấy dữ liệu từ sql server

namespace BussinessLayer
{
    public class LoginBL
    {
        private LoginDL loginDL;//Khai báo đối tượng loginDL từ lớp LoginDL
        public LoginBL()//Tạo 1 constructor không tham số là 1 đối tượng mới từ LoginDL
        {
            loginDL = new LoginDL();
        }
        //Tạo 1 hàm Login có chưa tham số từ lớp Account từ tầng TFO
        public bool Login(Account account)
        {
            //Trong hàm này xử lý theo khối try-catch catch quăng lên cho tầng Presen MessagesBox ra
            try
            {
                // trả về loginDL lấy hàm Login từ DL truyền vô đt account chứ user,pass,type
                return loginDL.Login(account);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
