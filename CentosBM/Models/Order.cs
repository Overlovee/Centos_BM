using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosBM.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; } = "Không";
        public string OrderStatus { get; set; } = "Chưa thanh toán";
        public string ShipmentStatus { get; set; } = "Chờ giao hàng";
    }
}
