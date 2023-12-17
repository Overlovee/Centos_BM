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
        public MyAccount account {  get; set; }
        public MyAccountForm()
        {
            InitializeComponent();
            cp = new ConnectProcedureAndFunction(db.constr);
            account = new MyAccount();
        }
        public void DisplayUserInfo()
        {
            if (account != null)
            {
                lbtext_ID.Text = account.EmployeeID.ToString();
                lbtext_FirstName.Text = account.FullName.ToString();
                lbtext_Position.Text = account.Position.ToString();
                lbtext_Phone.Text = account.Phone.ToString();
                lbtext_UserName.Text = account.Username.ToString();
                lbtext_Address.Text = account.Address.ToString();
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
    }
}
