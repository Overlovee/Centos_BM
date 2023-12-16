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
    public partial class UpdateEmployees : Form
    {
        DbContext db = new DbContext();
        MyAccount mc = new MyAccount();
        private int roleID;
        private string EmployeesID;
        private string username;
        private string FirstName;
        private string LastName;
        private string Phone;
        private string Position;
        private string EmpStatus;
        private string Address;
        public UpdateEmployees(string employeesid, string username,string firstname,string lastname,string phone,string position,string emp,string address,int roleID)
        {
            InitializeComponent();
            this.EmployeesID = employeesid;
            this.username = username;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Phone = phone;
            this.Address = address;
            this.Position = position;
            this.EmpStatus = emp;
            this.roleID = roleID;

            txt_UserName.Text = username;
            txt_LBID.Text = employeesid;
            txt_FirstName.Text = firstname;
            txt_LastName.Text = lastname;
            txt_Phone.Text = phone;
            cb_Position.Text = position;
            txt_EmpStatus.Text = emp;
            txt_Address.Text = address;
        }
        private void Update()
        {
            db.open();
            SqlCommand cmd = new SqlCommand("UpdateEmployeeAndAccountStatus", db.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", txt_LBID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txt_FirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txt_LastName.Text);
            cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
            cmd.Parameters.AddWithValue("@Position", cb_Position.Text);
            cmd.Parameters.AddWithValue("@EmpStatus", txt_EmpStatus.Text);
            cmd.Parameters.AddWithValue("@Username", txt_UserName.Text);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Update successful");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }
        private void button_Update_Click(object sender, EventArgs e)
        {

            Update();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void UpdateEmployees_Load(object sender, EventArgs e)
        {
            CustomizeComboBoxByRole(roleID);
        }
        private void CustomizeComboBoxByRole(int roleID)
        {
            cb_Position.Items.Clear();
            if (roleID == 1)
            {
                cb_Position.Items.Add("Admin");
                cb_Position.Items.Add("Quản Lý");
                cb_Position.Items.Add("Nhân Viên");
            }
            else if (roleID == 2)
            {
                cb_Position.Items.Add("Quản Lý");
                cb_Position.Items.Add("Nhân Viên");
            }
            else if (roleID == 3)
            {
                cb_Position.Items.Add("Nhân Viên");
            }
            cb_Position.SelectedIndex = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePassword fg = new UpdatePassword(EmployeesID, username);
            fg.Show();
        }
    }
}
