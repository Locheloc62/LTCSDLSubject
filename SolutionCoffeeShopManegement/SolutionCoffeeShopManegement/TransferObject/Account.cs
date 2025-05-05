using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string role { get; set; }


        public Account(string Username, string Password, string Role)
        {
            this.userName = Username;
            this.password = Password;
            this.role = Role;
        }
    }
}
