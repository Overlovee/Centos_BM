using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosBM.Connects
{
    public class ConnectEmployee
    {
        DbContext dbContext = new DbContext();
        public Employee getDataByID(int id = 1)
        {
            Employee emp = new Employee();
            string sql = "Select * from Employees where EmployeeID = "+id+" ";
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.EmployeeID = int.Parse(rdr.GetValue(0).ToString());
                emp.FullName = rdr.GetValue(1).ToString();
                emp.Address = rdr.GetValue(2).ToString();
                emp.Phone = rdr.GetValue(3).ToString();
                emp.Position = rdr.GetValue(4).ToString();
                emp.EmpStatus = rdr.GetValue(5).ToString();
            }
            rdr.Close();
            return emp;
        }
    }
}
