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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using CentosBM.Connects;
using CentosBM.Forms;

namespace CentosBM
{
    public partial class Login : Form
    {
        DbContext db = new DbContext();
        ConnectProcedureAndFunction cl;
        MyAccount mc = new MyAccount();
        public Login()
        {
            InitializeComponent();
            cl = new ConnectProcedureAndFunction("Data Source=.;Initial Catalog=CentosBM;Integrated Security=True");
        }


        private void Login_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                txt_lginUserName.Text = Properties.Settings.Default.UserName;
                txt_lginPassword.Text = Properties.Settings.Default.Password;
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            mc = cl.Login(txt_lginUserName.Text,txt_lginPassword.Text);
            if (mc != null)
            {
                mc.Username = txt_lginUserName.Text;
                {
                    MessageBox.Show("LogIn Successfully With Nhân Viên Rights!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Menu menuForm = new Menu();

                menuForm.account = mc;
                this.Hide();
                menuForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful. Please Check Your Login information Again.!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
