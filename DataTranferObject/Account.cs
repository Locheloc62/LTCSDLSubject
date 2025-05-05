using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DataTranferObject
{
    public class Account
    {
        public string uSerName { get; set; }
        public string passWord { get; set; }
        public string role_User { get; set; }
        public Account(string user, string pass, string role) 
        {
            this.uSerName = user;
            this.passWord = pass;
            this.role_User = role;
        }
    }
    
}
