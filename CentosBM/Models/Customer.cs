using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosBM.Models
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Total { get; set; }
        public string CustomerType { get; set; }

        public Customer()
        {
            CustomerID = 0;
            Name = "";
            Address = "";
            Phone = "";
            Total = 0;
            CustomerType = "";

        }
    }
}
