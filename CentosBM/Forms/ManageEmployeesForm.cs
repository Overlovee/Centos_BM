﻿using CentosBM.Connects;
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
        private Employee emp;
        public MyAccount account {  get; set; }
        public ManageEmployeesForm()
        {
            InitializeComponent();
            cn1 = new ConnectProcedureAndFunction(db.constr);
            account = new MyAccount();
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
            LoadEmployeeAccountData();
        }
        private void LoadEmployeeAccountData()
        {
            dataGridView.DataSource = cn1.GetEmployeeAccountData(account.Role);
        }
        private void button_Register_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddEmployees addEmployeesForm = new AddEmployees(account.Role);
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
                string id = row.Cells["EmployeeID"].Value.ToString();
                ConnectEmployee connectEmployee = new ConnectEmployee();

                MyAccount temp = new MyAccount();
                temp = connectEmployee.getDataMyAccountbyID(int.Parse(id));

                UpdateEmployees up = new UpdateEmployees(temp);
                up.roleID = account.Role;
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
