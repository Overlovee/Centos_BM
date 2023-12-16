using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CentosBM.Models;
using System.Collections;
using System.Runtime.Remoting.Lifetime;

namespace CentosBM
{
    public partial class Register : Form
    {
        DbContext db = new DbContext();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Đóng form
                e.Cancel = true;
                //
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if(txt_FirstName.Text != string.Empty &&  txt_LastName.Text != string.Empty && txt_Address.Text != string.Empty && txt_Phone.Text != string.Empty && cb_Position.Text != string.Empty && txt_UserName.Text != string.Empty && txt_Password.Text != string.Empty && txt_ConfirmPassword.Text != string.Empty)
            {
                db.open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Accounts WHERE Username = '" + txt_UserName.Text + "'", db.Con);
                cmd.Parameters.AddWithValue("Username",txt_UserName.Text);
                int Count = (int)cmd.ExecuteScalar();
                if (Count > 0)
                {
                    MessageBox.Show("Information UserName Already Exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_Password.Text != txt_ConfirmPassword.Text)
                {
                    MessageBox.Show("Password And ConfirmPassword Dissimilarity!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    db.open();
                    SqlCommand cmdAddEmployee = new SqlCommand("INSERT INTO Employees (FirstName, LastName, Address, Phone, Position) VALUES (@FirstName, @LastName, @Address, @Phone, @Position); SELECT SCOPE_IDENTITY();", db.Con);
                    cmdAddEmployee.Parameters.AddWithValue("@FirstName", txt_FirstName.Text);
                    cmdAddEmployee.Parameters.AddWithValue("@LastName", txt_LastName.Text);
                    cmdAddEmployee.Parameters.AddWithValue("@Address", txt_Address.Text);
                    cmdAddEmployee.Parameters.AddWithValue("@Phone", txt_Phone.Text);
                    cmdAddEmployee.Parameters.AddWithValue("@Position", cb_Position.Text);
                    int employeeID = Convert.ToInt32(cmdAddEmployee.ExecuteScalar());

                    SqlCommand cmdGetRoleID = new SqlCommand("SELECT RoleID FROM Roles WHERE Name = @Name;", db.Con);
                    cmdGetRoleID.Parameters.AddWithValue("@Name", cb_Position.Text);
                    int roleID = Convert.ToInt32(cmdGetRoleID.ExecuteScalar());

                    SqlCommand cmdAddAccount = new SqlCommand("INSERT INTO Accounts (Username, Password, EmployeeID, RoleID) VALUES (@Username, @Password, @EmployeeID, @RoleID);", db.Con);

                    cmdAddAccount.Parameters.AddWithValue("@Username", txt_UserName.Text);
                    cmdAddAccount.Parameters.AddWithValue("@Password", txt_Password.Text);
                    cmdAddAccount.Parameters.AddWithValue("@EmployeeID", txt_LBID.Text);
                    cmdAddAccount.Parameters.AddWithValue("@RoleID", roleID);
                    int kq = cmdAddAccount.ExecuteNonQuery();
                    if (kq > 0)
                        MessageBox.Show("Create Sucesss!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Create Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    db.close();
                }
                db.close();
            }
            else
            {
                MessageBox.Show("Please , Enter Complete Information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                        
        }
        private void autoIDEmployees()
        {
            string query = "select max(EmployeeID) from Employees";
            DataSet ds = db.GetData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txt_LBID.Text = (num + 1).ToString();
            }
        }
        private void autoIDAccount()
        {
            string query = "select max(AccountID) from Accounts";
            DataSet ds = db.GetData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
        }
        private void ClearAll()
        {
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Address.Clear();
            txt_UserName.Clear();
            txt_Password.Clear();
            txt_ConfirmPassword.Clear();
            txt_Phone.Clear();
        }
        //
        private void Register_Load(object sender, EventArgs e)
        {
            autoIDEmployees();
            autoIDAccount();
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = checkBox1.Checked;
            txt_ConfirmPassword.UseSystemPasswordChar = checkBox1.Checked;
        }
    }
}
