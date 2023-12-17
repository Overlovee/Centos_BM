using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        public MyAccount getDataMyAccountbyID(int id )
        {
            MyAccount mc = new MyAccount();
            SqlCommand cmd = new SqlCommand("Select * from showEmployees (@EmployeeID)", dbContext.Con);
            cmd.Parameters.AddWithValue("EmployeeID", id);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                mc.EmployeeID = int.Parse(rdr.GetValue(0).ToString());
                mc.Username = rdr.GetValue(1).ToString();
                mc.FullName = rdr.GetValue(2).ToString();
                mc.Address = rdr.GetValue(3).ToString();
                mc.Phone = rdr.GetValue(4).ToString();
                mc.Position = rdr.GetValue(5).ToString();
                mc.empStatus = rdr.GetValue(6).ToString();
                mc.Role = int.Parse(rdr.GetValue(7).ToString());
            }
            rdr.Close();
            return mc;
        }
    }
}
