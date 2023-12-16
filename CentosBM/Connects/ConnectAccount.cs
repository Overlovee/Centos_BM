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
    internal class ConnectAccount
    {
        DbContext db = new DbContext();
        public Account get(string emp)
        {
            Account ac = new Account();
            string query = "Select Username,Password,EmployeeID,RoleID from Account WHERE Username ='" + emp + "'";
            DataTable dataTable = db.getDatatable(query);
            foreach (DataRow row in dataTable.Rows)
            {
                ac.UserName = row["Username"].ToString();
                ac.password = row["Password"].ToString();
                ac.Employeeid = int.Parse(row["EmployeeID"].ToString());
                ac.Roleid = int.Parse(row["RoleID"].ToString());
            }
            return ac;
        }
    }
}
