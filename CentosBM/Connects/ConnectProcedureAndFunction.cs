using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentosBM.Models;
using System.Windows.Forms;

namespace CentosBM.Connects
{
    internal class ConnectProcedureAndFunction
    {
        DbContext db = new DbContext();
        MyAccount mc = new MyAccount();
        Password ps = new Password();
        private string connect;
        public string Username { get; set; }
        public string Password { get; set; }
        public ConnectProcedureAndFunction(string connect)
        {
            this.connect = connect;
        }
        public MyAccount Login(string username, string password)
        {
            try
            {
                db.open();
                SqlCommand cmd = new SqlCommand("LoginProcedure", db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                   if (reader.Read())
                   {
                        MyAccount temp = new MyAccount();
                        temp.EmployeeID = Convert.ToInt32(reader["EmployeeID"].ToString());
                        temp.FullName = reader["FullName"].ToString();
                        temp.Address = reader["Address"].ToString();
                        temp.Phone = reader["Phone"].ToString();
                        temp.Position = reader["Position"].ToString();
                        temp.empStatus = reader["empStatus"].ToString();
                        temp.Role = Convert.ToInt32(reader["RoleID"]);
                        return temp;
                   }
                   else
                   {
                        MessageBox.Show("This Username Has Retired");
                        
                   }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                
            }
            db.close();
            return null;
        }
        public MyAccount GetMyAccountInfo(string username)
        {
            try
            {
                db.open();
                using (SqlCommand cmd = new SqlCommand("GetEmployeeAccountInfo", db.Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new MyAccount
                            {
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                Username = reader["Username"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Position = reader["Position"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            db.close();
            return null;
        }
        public DataTable GetEmployeeAccountData(int roleID)
        {
            db.open();
            using (SqlCommand command = new SqlCommand("GetEmployeeAccountData", db.Con))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@RoleID", roleID);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    db.close();
                    return dataTable;
                }

            }
        }
        
    }
}
