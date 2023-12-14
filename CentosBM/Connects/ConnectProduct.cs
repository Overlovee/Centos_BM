using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosBM.Connects
{
    public class ConnectProduct
    {
        DbContext dbContext = new DbContext();
        public bool IsNumeric(string input)
        {
            int intResult;
            decimal decimalResult;

            if (int.TryParse(input, out intResult))
            {
                return true;
            }

            if (decimal.TryParse(input, out decimalResult))
            {
                return true;
            }

            return false;
        }
        public List<Product> getProducts()
        {
            List<Product> list = new List<Product>();
            string sql = ("Select P.ProductID, ProductName, Description, Price, P.CategoryID, S.SupplierID, Url, C.NameCategory, S.SupplierName, P.QuantityInStock " +
                "from Products P " +
                "join Images I ON P.ProductID = I.ProductID " +
                "join Categories C ON P.CategoryID = C.CategoryID " +
                "join Suppliers S ON P.SupplierID = S.SupplierID " +
                "where P.isDiscontinued = 1 " +
                "Order by Price DESC;");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Product emp = new Product();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Description = rdr.GetValue(2).ToString();
                emp.Price = decimal.Parse(rdr.GetValue(3).ToString());
                emp.CategoryID = int.Parse(rdr.GetValue(4).ToString());
                emp.SupplierID = int.Parse(rdr.GetValue(5).ToString());
                emp.Url = rdr.GetValue(6).ToString();
                emp.CategoryName = rdr.GetValue(7).ToString();
                emp.SupplierName = rdr.GetValue(8).ToString();
                emp.QuantityInStock = int.Parse(rdr.GetValue(9).ToString());
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<Product> getProducts(string search = "", string type = "")
        {
            bool isNumeric = IsNumeric(search);
            List<Product> list = new List<Product>();
            if (type == "Tất cả")
            {
                type = "";
            }
            string sql = "";
            if (isNumeric)
            {
                sql = "SELECT * FROM dbo.SearchProductsByPriceRange(N'" + type + "', 0, " + search + ") " +
                     "ORDER BY Price ASSC;";
            }
            else
            {
                sql = "SELECT * FROM dbo.SearchProducts(N'" + type + "', N'" + search + "') " +
                    "ORDER BY Price DESC;";
            }

            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Product emp = new Product();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Description = rdr.GetValue(2).ToString();
                emp.Price = decimal.Parse(rdr.GetValue(3).ToString());
                emp.CategoryID = int.Parse(rdr.GetValue(4).ToString());
                emp.SupplierID = int.Parse(rdr.GetValue(5).ToString());
                emp.Url = rdr.GetValue(6).ToString();
                emp.CategoryName = rdr.GetValue(7).ToString();
                emp.SupplierName = rdr.GetValue(8).ToString();
                emp.QuantityInStock = int.Parse(rdr.GetValue(9).ToString());

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }

        //public int addNewItem(Transaction transaction)
        //{
        //    Models.ConnectCategory connectCategory = new Models.ConnectCategory();
        //    Models.Category category = connectCategory.getDataByName(transaction.CategoryName);
        //    int rs = 0;
        //    string sql = "Set dateformat dmy INSERT INTO Transactions " +
        //        "VALUES('" + transaction.UserID + "', '"
        //        + category.CategoryID + "', '"
        //        + transaction.TransactionType + "', '"
        //        + transaction.Amount + "', CONVERT (varchar, '"
        //        + transaction.TransactionDate + "', 103), N'"
        //        + transaction.TransactionDescription + "')";

        //    rs = dbContext.ExcuteNonQuery(sql);
        //    dbContext.close();
        //    return rs;
        //}
        public int updateDataForItem(Product product)
        {
            ConnectCategory connectCategory = new ConnectCategory();
            Category category = connectCategory.getDataByName(product.CategoryName);
            ConnectSupplier connectSupplier = new ConnectSupplier();
            Supplier supplier = connectSupplier.getDataByName(product.SupplierName);
            int rs = 0;
            string sql = "EXEC UpdateProduct " +
                "@ProductID = "+ product .Id+ ", " +
                "@ProductName = N'"+ product.Name+ "', " +
                "@Description = N'"+ product .Description+ "', " +
                "@Price = "+product.Price+", " +
                "@CategoryID = "+category.Id+", " +
                "@SupplierID = " + supplier.Id + ", " +
                "@QuantityInStock = " + product.QuantityInStock + ", " +
                "@Url = N'" + product.Url+ "';";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public int deleteDataById(int id)
        {
            int rs = 0;
            string sql = "EXEC UpdateDiscontinuedStatus @ProductID = "+id+", @isDiscontinued = 0;";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
    }
}
