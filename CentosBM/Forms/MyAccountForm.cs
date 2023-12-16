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
        private string loggedInUsername;
        ConnectProcedureAndFunction cp;
        private Form menuForm;
        public MyAccountForm(string username, Form menuForm)
        {
            InitializeComponent();
            cp = new ConnectProcedureAndFunction(db.constr);
            loggedInUsername = username;
            DisplayUserInfo();
            this.menuForm = menuForm;
        }
        public void DisplayUserInfo()
        {
            MyAccount employeeAccountInfo = cp.GetMyAccountInfo(loggedInUsername);

            if (employeeAccountInfo != null)
            {
                lbtext_ID.Text = employeeAccountInfo.EmployeeID.ToString();
                lbtext_FirstName.Text = employeeAccountInfo.FirstName.ToString();
                lbtext_LastName.Text = employeeAccountInfo.LastName.ToString();
                lbtext_Position.Text = employeeAccountInfo.Position.ToString();
                lbtext_Phone.Text = employeeAccountInfo.Phone.ToString();
                lbtext_UserName.Text = employeeAccountInfo.Username.ToString();
                lbtext_Address.Text = employeeAccountInfo.Address.ToString();
            }
            else
            {
                MessageBox.Show("Account not found.", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            
        }
        private void button_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) 
            {
                this.Close();
                menuForm.Close();
                Login login = new Login();
                login.Show();
            }
            
        }
    }
}
