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
    public partial class ManageEmployeesForm : Form
    {
        DbContext db = new DbContext();
        ConnectProcedureAndFunction cn1;
        private int roleID;

        public ManageEmployeesForm(int roleID)
        {
            InitializeComponent();
            cn1 = new ConnectProcedureAndFunction(db.constr);
            this.roleID = roleID;
            LoadEmployeeAccountData();
        }

        private void ManageEmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to exit?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
        private void ManageEmployeesForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadEmployeeAccountData()
        {
            dataGridView.DataSource = cn1.GetEmployeeAccountData(roleID);
        }
        private void button_Register_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddEmployees addEmployeesForm = new AddEmployees(roleID);
            addEmployeesForm.ShowDialog();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            //UpdateEmployees myform = new UpdateEmployees();

            

            //myform.ShowDialog();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                string Employees = row.Cells["EmployeeID"].Value.ToString();
                string username = row.Cells["Username"].Value.ToString();
                string firstname = row.Cells["FirstName"].Value.ToString();
                string lastname = row.Cells["LastName"].Value.ToString();
                string Phone = row.Cells["Phone"].Value.ToString();
                string Position = row.Cells["Position"].Value.ToString();
                string empStatus = row.Cells["empStatus"].Value.ToString();
                string address = row.Cells["Address"].Value.ToString();

                UpdateEmployees up = new UpdateEmployees(Employees,username, firstname, lastname, Phone, Position, empStatus,address,roleID);
                up.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text;
            List<MyAccount> searchResult = cn1.SearchEmployees(keyword);
            dataGridView.DataSource = searchResult;
        }
    }
}
