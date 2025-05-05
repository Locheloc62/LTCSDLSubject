using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using DataLayer;

namespace BusinessLayer
{ 
    public class AccountBLL
    {
        AccountAcess tkacess=new AccountAcess();
        public string CheckLogin(Account account)
        {
            if(account.uSerName=="")
            {
                return "";
            }
            if(account.passWord=="")
            {
                return "";
            }
            string info=tkacess.CheckLogin(account);
            return info;
        }
    }
}
