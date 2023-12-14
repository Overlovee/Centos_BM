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
            string sql = ("Select * from Suppliers");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Supplier emp = new Supplier();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.PhoneNumber = rdr.GetValue(2).ToString();

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
            }
            rdr.Close();
            return emp;
        }
    }
}
