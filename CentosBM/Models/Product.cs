using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosBM.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public string Unit { get; set; }
        public string Url { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public int QuantityInStock { get; set; }
    }
}
