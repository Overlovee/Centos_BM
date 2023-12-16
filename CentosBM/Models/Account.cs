using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosBM.Models
{
    internal class Account
    {
        public  int Employeeid { get; set; }
        public  int Roleid { get; set; }
        public  string FirstName { get; set;}
        public  string LastName { get; set;}
        public  string Address { get; set;}
        public  string UserName { get; set;}
        public  string Position { get; set;}
        public  int phone { get; set;}
        public string password { get; set;}

        public Account()
        {
            UserName = "";
            password = "";
            Employeeid = 0;
            Roleid = 0;
        }
    }
}
