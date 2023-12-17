using CentosBM.Connects;
using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        public bool isChanged { get; set; }
        public UpdateEmployees(MyAccount mc)
        {
            InitializeComponent();
            this.mc = mc;
            this.roleID = 2;
            isChanged = false;
        }

        private void Update()
        {
            db.open();
            int rs = 0;
            string sql = "exec UpdateEmployeeAndAccountStatus " + int.Parse(txt_LBID.Text) + " ,N'" + txt_FullName.Text + "',N'" + txt_UserName.Text + "',N'" + txt_Address.Text + "','" + txt_Phone.Text + "',N'" + cb_EmpStatus.SelectedItem.ToString() + "', N'" + cb_Position.SelectedItem.ToString() + "'";
            rs = db.ExcuteNonQuery(sql);
            if (rs != 0)
            {
                isChanged = true;
                MessageBox.Show("Update successful");

            }
            else
            {
                MessageBox.Show("Update failed");
            }
            db.close();
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
            txt_FullName.Text = mc.FullName;
            txt_Phone.Text = mc.Phone;
            cb_EmpStatus.Text = mc.empStatus;
            txt_Address.Text = mc.Address;
            cb_Position.SelectedItem= mc.Position;
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
                cb_Position.Items.Add("Quản Lí");
                cb_Position.Items.Add("Nhân Viên");
                cb_Position.SelectedItem = "Quản Lí";
                linkLabel1.Enabled = false;
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
                txt_FullName.Enabled = false;
                txt_Phone.Enabled = false;
                cb_Position.Enabled = false;
                cb_EmpStatus.Enabled = false;
                txt_Address.Enabled = false;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePassword fg = new UpdatePassword(mc.EmployeeID, mc.Username);
            fg.Show();
        }

        private void txt_FullName_TextChanged(object sender, EventArgs e)
        {
            if(!(txt_FullName.Text is null) && !(txt_Address.Text is null) && !(txt_Phone.Text is null) && !(txt_UserName.Text is null) && !(cb_EmpStatus.SelectedItem is null) && !(cb_Position.SelectedItem is null))
            {
                if((txt_UserName.Text != mc.Username) || (txt_Phone.Text != mc.Phone) || (txt_FullName.Text != mc.FullName) || (txt_Address.Text != mc.Address) || (cb_Position.SelectedItem.ToString() != mc.Position) || (cb_EmpStatus.SelectedItem.ToString() != mc.empStatus))
                {
                    button_Update.Enabled = true;
                }
                else
                {
                    button_Update.Enabled = false;
                }
            }
        }
    }
}
