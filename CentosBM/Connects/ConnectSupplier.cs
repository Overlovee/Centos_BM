using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CentosBM.Connects
{
    public class ConnectSupplier
    {
        DbContext dbContext = new DbContext();
        public List<Supplier> getSuppliers()
        {
            List<Supplier> list = new List<Supplier>();
            string sql = ("Select * from Suppliers Order by SupplierID DESC");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Supplier emp = new Supplier();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.PhoneNumber = rdr.GetValue(2).ToString();
                emp.Status = rdr.GetValue(3).ToString();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<Supplier> getSuppliers(string search = "", string status = "")
        {
            List<Supplier> list = new List<Supplier>();
            string sql = "";
            if (status == "Tất cả")
            {
                status = "";
            }

            if (status == "")
            {
                sql = "Select * from Suppliers ";
            }
            else
            {
                sql = "Select * from Suppliers " +
                "where " +
                "Status like N'" + status + "' ";
            }

            if (search != "")
            {
                if (status == "")
                {
                    sql += " where SupplierName like N'%" + search + "%' Or Phone like '%" + search + "%'  ";
                }
                else
                {
                    sql += " And SupplierName like N'%" + search + "%' Or Phone like '%" + search + "%'  ";
                }
            }

            sql += "Order by SupplierID DESC";
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Supplier emp = new Supplier();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.PhoneNumber = rdr.GetValue(2).ToString();
                emp.Status = rdr.GetValue(3).ToString();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public Supplier getDataByName(string name)
        {
            Supplier emp = new Supplier();
            string sql = "Select * from Suppliers where SupplierName like N'" + name + "'";
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.PhoneNumber = rdr.GetValue(2).ToString();
                emp.Status = rdr.GetValue(3).ToString();
            }
            rdr.Close();
            return emp;
        }

        public List<string> getStatus()
        {
            List<string> list = new List<string>();
            list.Add("Đang cung cấp");
            list.Add("Đã ngừng cung cấp");
            return list;
        }


        public int updateDataForItem(Supplier supplier)
        {
            int rs = 0;
            string sql = "EXEC UpdateSupplier " +
                "@SupplierID = " + supplier.Id + ", " +
                "@SupplierName = N'" + supplier.Name + "', " +
                "@Phone = '" + supplier.PhoneNumber + "', " +
                "@Status = N'" + supplier.Status + "';";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public int addNewItem(Supplier suppliert)
        {
            int rs = 0;
            string sql = "EXEC AddSupplier " +
                "@SupplierName = N'"+suppliert.Name+"', " +
                "@Phone = '"+suppliert.PhoneNumber+"', " +
                "@Status = N'"+suppliert.Status+"';";

            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
    }
}
