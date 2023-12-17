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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CentosBM
{
    public partial class UpdatePassword : Form
    {
        DbContext db = new DbContext();
        private string Username;
        private int Employeeid;
        public UpdatePassword(int employeeid,string username)
        {
            InitializeComponent();
            this.Employeeid = employeeid;
            this.Username = username;
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if(txt_Password.Text != string.Empty && txt_ConfirmPassword.Text != string.Empty)
            {
                if(txt_Password.Text == txt_ConfirmPassword.Text)
                {
                    try
                    {
                        db.open();
                        SqlCommand cmd = new SqlCommand("UpdatePasswordProcedure", db.Con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", Employeeid);
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@NewPassword", Password.Create_MD5(txt_Password.Text.Trim()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password updated successfully", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        txt_Password.Clear();
                        txt_ConfirmPassword.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating password: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Password And ConfirmPassword Dissimilarity");
                }
            }
            else
            {
                MessageBox.Show("Please Complete Information");
            }
        }
    }
}
