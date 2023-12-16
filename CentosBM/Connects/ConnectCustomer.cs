using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentosBM.Models;
using System.Data.SqlClient;
namespace CentosBM.Connects
{
    internal class ConnectCustomer
    {
        DbContext dbContext = new DbContext();
        public Customer getCustomer(string search = "")
        {
            string sql = "";
            if(search != "")
            {
                sql = "SELECT * FROM dbo.FindCustomer('"+search+"')";
            }

            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            Customer emp = new Customer();

            if (rdr.Read())
            {
                emp.CustomerID = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Address = rdr.GetValue(2).ToString();
                emp.Phone = rdr.GetValue(3).ToString();
            }
            rdr.Close();
            return emp;
        }
        public int addNewCustomer(string name,string address,string phone)
        {
            int rs = 0;
            string sql = "EXEC AddCustomer  N'" + name + "',N'" + address + "',N'" + phone + "';";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }

    }
}
