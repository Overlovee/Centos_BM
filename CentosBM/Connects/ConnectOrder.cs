using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosBM.Connects
{
    public class ConnectOrder
    {
        DbContext dbContext = new DbContext();
        public List<Order> getAllData(string search = "")
        {
            List<Order> list = new List<Order>();
            string sql = ("Select * from Orders ");
            if (search != "")
            {
                sql += " where (O.CustomerName like N'%" + search + "%' Or O.CustomerPhoneNumber like N'%" + search + "%')";
            }
            sql += " Order by OrderID DESC";
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Order emp = new Order();
                emp.ID = int.Parse(rdr.GetValue(0).ToString());
                emp.OrderID = rdr.GetValue(1).ToString();
                emp.OrderDate = DateTime.Parse(rdr.GetValue(2).ToString());
                emp.TotalAmount = decimal.Parse(rdr.GetValue(3).ToString());
                emp.CustomerID = int.Parse(rdr.GetValue(4).ToString());
                emp.EmployeeID = int.Parse(rdr.GetValue(5).ToString());
                emp.CustomerName = rdr.GetValue(6).ToString();
                emp.CustomerPhoneNumber = rdr.GetValue(7).ToString();
                emp.CustomerAddress = rdr.GetValue(8).ToString();
                emp.OrderStatus = rdr.GetValue(9).ToString();
                emp.ShipmentStatus = rdr.GetValue(10).ToString();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<Order> getData(string search = "", string status = "")
        {
            List<Order> list = new List<Order>();
            string sql = "Select * from Orders O " +
                " where (O.OrderStatus like N'" + status + "' Or O.ShipmentStatus like N'" + status + "') ";
            if (search != "")
            {
                sql += " And (O.CustomerName like N'%" + search + "%' Or O.CustomerPhoneNumber like N'%" + search + "%')";
            }
            sql += " Order by OrderID DESC";
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Order emp = new Order();
                emp.ID = int.Parse(rdr.GetValue(0).ToString());
                emp.OrderID = rdr.GetValue(1).ToString();
                emp.OrderDate = DateTime.Parse(rdr.GetValue(2).ToString());
                emp.TotalAmount = decimal.Parse(rdr.GetValue(3).ToString());
                emp.CustomerID = int.Parse(rdr.GetValue(4).ToString());
                emp.EmployeeID = int.Parse(rdr.GetValue(5).ToString());
                emp.CustomerName = rdr.GetValue(6).ToString();
                emp.CustomerPhoneNumber = rdr.GetValue(7).ToString();
                emp.CustomerAddress = rdr.GetValue(8).ToString();
                emp.OrderStatus = rdr.GetValue(9).ToString();
                emp.ShipmentStatus = rdr.GetValue(10).ToString();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<string> getOrderStatus()
        {
            List<string> list = new List<string>();
            list.Add("Chưa thanh toán");
            list.Add("Đã thanh toán");
            list.Add("Đã huỷ");
            list.Add("Đã giao hàng");
            list.Add("Chưa giao hàng");
            list.Add("Chờ giao hàng");
            return list;
        }
    }
}
