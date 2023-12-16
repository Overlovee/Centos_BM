﻿using System;
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
                Password ps = new Password();
                SqlCommand cmd = new SqlCommand("LoginProcedure", db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                   if (reader.Read())
                   {
                        string result = reader["Result"].ToString();
                        if (result == "Success")
                        {
                            int role = Convert.ToInt32(reader["RoleID"]);
                            return new MyAccount { Username = username, Role = role };
                        }
                        else
                        {
                            MessageBox.Show("Username Stopped working");
                            
                        }
                   }
                   else
                   {
                        MessageBox.Show("Read data failed");
                        
                   }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                
            }
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
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
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
                    return dataTable;
                }

            }
        }
        public List<MyAccount> SearchEmployees(string keyword)
        {
            List<MyAccount> result = new List<MyAccount>();
            try
            {
                db.open();
                SqlCommand cmd = new SqlCommand("SearchEmployeesProcedure", db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", keyword);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MyAccount employee = new MyAccount
                        {
                            EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                            Username = reader["Username"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Address = reader["Address"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Position = reader["Position"].ToString(),
                            empStatus = reader["empStatus"].ToString()
                        };
                        result.Add(employee);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching employees: " + ex.Message);
            }
            db.close();
            return result;
        }
    }
}