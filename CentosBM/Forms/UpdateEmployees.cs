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
        private MyAccount mc {  get; set; }
        public int roleID;
        //private string EmployeesID;
        //private string username;
        //private string FirstName;
        //private string LastName;
        //private string Phone;
        //private string Position;
        //private string EmpStatus;
        //private string Address;
        public UpdateEmployees(MyAccount mc)
        {
            InitializeComponent();
            this.mc = mc;
            //this.EmployeesID = employeesid;
            //this.username = username;
            //this.FirstName = firstname;
            //this.LastName = lastname;
            //this.Phone = phone;
            //this.Address = address;
            //this.Position = position;
            //this.EmpStatus = emp;
            this.roleID = 2;

            
        }
        private void Update()
        {
            db.open();
            SqlCommand cmd = new SqlCommand("UpdateEmployeeAndAccountStatus", db.Con);
            //Storeprocedure dang dung nhưng 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", txt_LBID.Text);
            cmd.Parameters.AddWithValue("@Username", txt_UserName.Text);
            cmd.Parameters.AddWithValue("@FullName", txt_FirstName.Text);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);

            cmd.Parameters.AddWithValue("@Position", cb_Position.Text);
            //Chưa update được role cho account, cần lấy role id từ cái cb_posiotin combobox để thay role
            // store procedurre tên là UpdateEmployeeAndAccountStatus
            cmd.Parameters.AddWithValue("@EmpStatus", txt_EmpStatus.Text);
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
            CustomizeComboBoxByRole();
            txt_UserName.Text = mc.Username;
            txt_LBID.Text = mc.EmployeeID.ToString();
            txt_FirstName.Text = mc.FullName;
            txt_Phone.Text = mc.Phone;
            txt_EmpStatus.Text = mc.empStatus;
            txt_Address.Text = mc.Address;
        }
        private void CustomizeComboBoxByRole()
        {
            cb_Position.Items.Clear();
            if (mc.Role == 1)
            {
                cb_Position.Items.Add("Admin");
                cb_Position.SelectedItem = "Admin";
            }
            else if (mc.Role >= 2)
            {
                cb_Position.Items.Add("Quản Lý");
                cb_Position.Items.Add("Nhân Viên");
                cb_Position.SelectedItem = "Quản Lý";
            }

            if (roleID != 1)
            {
                cb_Position.Enabled = false;
            }
            if(roleID == mc.Role)
            {
                cb_Position.Enabled = false;
                txt_UserName.Enabled = false;
                txt_LBID.Enabled = false;
                txt_FirstName.Enabled = false;
                txt_LastName.Enabled = false;
                txt_Phone.Enabled = false;
                cb_Position.Enabled = false;
                txt_EmpStatus.Enabled = false;
                txt_Address.Enabled = false;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePassword fg = new UpdatePassword(mc.EmployeeID, mc.Username);
            fg.Show();
        }
    }
}
