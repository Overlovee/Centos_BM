using CentosBM.Connects;
using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosBM.Forms
{
    public partial class AddEmployees : Form
    {
        DbContext db = new DbContext();
        private int roleID;
        public bool isChanged { get; set; }

        public AddEmployees(int roleID)
        {
            InitializeComponent();
            this.roleID = roleID;
            this.isChanged = false;
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (txt_FullName.Text != string.Empty &&  txt_Address.Text != string.Empty && txt_Phone.Text != string.Empty && cb_Position.Text != string.Empty && txt_UserName.Text != string.Empty && txt_Password.Text != string.Empty && txt_ConfirmPassword.Text != string.Empty)
            {
                if(txt_Password.Text != txt_ConfirmPassword.Text)
                {
                    MessageBox.Show("Password And ConfirmPassword Dissimilarity!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    db.open();
                    SqlCommand cmd = new SqlCommand("AddEmployee", db.Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FullName", txt_FullName.Text);
                    cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                    cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
                    cmd.Parameters.AddWithValue("@Position", cb_Position.Text);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("GetRoleIDByName", db.Con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@RoleName", cb_Position.Text);
                    int roleID = Convert.ToInt32(cmd2.ExecuteScalar());

                    SqlCommand cmd3 = new SqlCommand("AddOrUpdateAccount", db.Con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@Username", txt_UserName.Text);
                    cmd3.Parameters.AddWithValue("@Password", Password.Create_MD5(txt_Password.Text.Trim()));
                    cmd3.Parameters.AddWithValue("@EmployeeID", txt_LBID.Text);
                    cmd3.Parameters.AddWithValue("@RoleID", roleID);
                    int kq = cmd3.ExecuteNonQuery();
                    if(kq < 0)
                    {
                        MessageBox.Show("Create Sucesss!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        autoIDEmployees();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Create Failed! Username already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.close();
                }
            }
            else
            {
                MessageBox.Show("Please , Enter Complete Information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CustomizeComboBoxByRole(int roleID)
        {
            cb_Position.Items.Clear();
            if (roleID == 1) 
            {
                cb_Position.Items.Add("Quản Lý");
                cb_Position.Items.Add("Nhân Viên");
            }
            else if (roleID == 2)
            {
                cb_Position.Items.Add("Nhân Viên");
            }
            cb_Position.SelectedIndex = 0;
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
            txt_FullName.Clear();
            txt_Address.Clear();
            txt_UserName.Clear();
            txt_Password.Clear();
            txt_ConfirmPassword.Clear();
            txt_Phone.Clear();
        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {
            autoIDEmployees();
            autoIDAccount();
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            CustomizeComboBoxByRole(roleID);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = checkBox1.Checked;
            txt_ConfirmPassword.UseSystemPasswordChar = checkBox1.Checked;
        }
    }
}
