using CentosBM.Connects;
using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CentosBM.Forms
{
    public partial class MyAccountForm : Form
    {
        DbContext db = new DbContext();
        ConnectProcedureAndFunction cp;
        private MyAccount account {  get; set; }
        public bool isChanged { get; set; }
        public MyAccountForm(MyAccount account)
        {
            InitializeComponent();
            cp = new ConnectProcedureAndFunction(db.constr);
            this.account = account;
            isChanged = false;
        }
        public void DisplayUserInfo()
        {
            if (account != null)
            {
                txt_LBID.Text = account.EmployeeID.ToString();
                txt_FullName.Text = account.FullName.ToString();
                lbtext_Position.Text = account.Position.ToString();
                txt_Phone.Text = account.Phone.ToString();
                txt_UserName.Text = account.Username.ToString();
                txt_Address.Text = account.Address.ToString();
                lbtext_empStatus.Text = account.empStatus.ToString();
            }
            else
            {
                MessageBox.Show("Account not found.", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            DisplayUserInfo();
        }
        private void button_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) 
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }

                if (control.Parent is Menu)
                {
                    Menu f = (Menu)control.Parent;
                    f.Close();
                }
            }
        }

        private void lbtext_Position_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            db.open();
            int rs = 0;
            string sql = "Exec UpdateMyAccount '" + int.Parse(txt_LBID.Text) + "',N'" + txt_FullName.Text + "',N'" + txt_UserName.Text + "',N'" + txt_Address.Text + "','" + txt_Phone.Text + "'";
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

        private void txt_FullName_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_FullName.Text is null) && !(txt_Address.Text is null) && !(txt_Phone.Text is null) && !(txt_UserName.Text is null) )
            {
                if ((txt_UserName.Text != account.Username) || (txt_Phone.Text != account.Phone) || (txt_FullName.Text != account.FullName) || (txt_Address.Text != account.Address))
                {
                    button_Update.Enabled = true;
                }
                else
                {
                    button_Update.Enabled = false;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePassword fg = new UpdatePassword(account.EmployeeID, account.Username);
            fg.Show();
        }
    }
}
