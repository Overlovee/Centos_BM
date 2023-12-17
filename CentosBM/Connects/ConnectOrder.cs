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
            list.Add("Chờ giao hàng");
            return list;
        }

        //public int addNewItem(Product product)
        //{
        //    ConnectCategory connectCategory = new ConnectCategory();
        //    Category category = connectCategory.getDataByName(product.CategoryName);
        //    ConnectSupplier connectSupplier = new ConnectSupplier();
        //    Supplier supplier = connectSupplier.getDataByName(product.SupplierName);

        //    int rs = 0;
        //    string sql = "EXEC InsertProduct " +
        //        "@ProductName = N'" + product.Name + "', " +
        //        "@Description = N'" + product.Description + "', " +
        //        "@Price = " + product.Price + ", " +
        //        "@QuantityInStock = " + product.QuantityInStock + ", " +
        //        "@Unit = N'" + product.Unit + "', " +
        //        "@Url = N'" + product.Url + "', " +
        //        "@CategoryID = " + category.Id + ", " +
        //        "@SupplierID = " + supplier.Id + ";";

        //    rs = dbContext.ExcuteNonQuery(sql);
        //    dbContext.close();

        //    sql = "SELECT dbo.FindLastInsertedProductID();";
        //    SqlDataReader rdr = dbContext.ExcuteQuery(sql);
        //    int id = 0;
        //    if (rdr.Read())
        //    {
        //        id = int.Parse(rdr.GetValue(0).ToString());
        //    }
        //    rdr.Close();
        //    return id;
        //}
        public int updateDataForItem(Order order)
        {
            int rs = 0;
            string sql = "EXEC UpdateOrder " +
                "@OrderID = '"+ order.OrderID+ "', " +
                "@CustomerName = N'"+ order.CustomerName+ "', " +
                "@CustomerPhoneNumber = '"+ order.CustomerPhoneNumber+ "', " +
                "@CustomerAddress = N'"+ order.CustomerAddress+ "', " +
                "@OrderStatus = N'"+ order.OrderStatus+ "', " +
                "@ShipmentStatus = N'"+ order.ShipmentStatus+ "';";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public int CreateOrder(DateTime Orderdate,decimal total,int customerID,int EmployeeID,string OrderStatus,string shipmentstatus)
        {
            int rs = 0;
            string sql = "EXEC AddOrder " +
                "@OrderDate = '" + Orderdate + "', " +
                "@TotalAmount = N'" + total + "', " +
                "@CustomerID = '" + customerID + "', " +
                "@EmployeeID = N'" + EmployeeID + "', " +
                "@OrderStatus = N'" + OrderStatus + "', " +
                "@ShipmentStatus = N'" + shipmentstatus + "';";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public string getLastOrderdetail()
        {
            string temp = "";
            string sql = "Select dbo.GetLastInsertedOrderID()";
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                temp = rdr.GetValue(0).ToString(); ;
            }
            dbContext.close();
            return temp;
        }
        public int AddproductDetail(string orderid,int productID,int quantity,decimal price)
        {
            int rs = 0;
            string sql = "EXEC AddOrderDetail " +
                "@OrderID = '" + orderid + "', " +
                "@ProductID = " + productID + ", " +
                "@Quantity = " + quantity + ", " +
                "@Price = " + price + ";";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public List<Order> getAllDatabymonth(int month = 0)
        {
            List<Order> list = new List<Order>();
            string sql = "Select * from Orders O WHERE MONTH(O.OrderDate) = " + month;

            sql += " ORDER BY OrderID DESC";

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
        public List<Product> getDataRevenueProductByCategory(string categoryname = "", int month = 0)
        {
            List<Product> list = new List<Product>();
            string sql = "";
            if (categoryname == "Tất cả")
            {
                sql = "SELECT * FROM dbo.GetRevenueProductByCategory(N'', " + month + ")";
            }
            else
            {
                sql = "SELECT * FROM dbo.GetRevenueProductByCategory(N'" + categoryname + "', " + month + ")";
            }

            SqlDataReader rdr = dbContext.ExcuteQuery(sql);

            while (rdr.Read())
            {
                Product emp = new Product();
                emp.Name = rdr.GetValue(0).ToString();
                emp.Quantity = int.Parse(rdr.GetValue(1).ToString());
                emp.Price = decimal.Parse(rdr.GetValue(2).ToString());
                emp.OrderID = rdr.GetValue(3).ToString();
                emp.categoryName = rdr.GetValue(4).ToString();
                emp.OrderDate = DateTime.Parse(rdr.GetValue(5).ToString());
                list.Add(emp);
            }

            rdr.Close();
            return list;
        }
    }
}
