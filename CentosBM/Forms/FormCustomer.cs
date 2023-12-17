using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentosBM.Models;
using CentosBM.Connects;
using CentosBM.UserControls;
namespace CentosBM.Forms
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            foreach (Control control in panelCustomerLoad.Controls)
            {
                control.Dispose();
            }

            panelCustomerLoad.Controls.Clear();
            ConnectCustomer connectCustomer = new ConnectCustomer();
            List<Customer> list = new List<Customer>();
            list = connectCustomer.LoadDataCustomer(textBoxSearch1.Text);

            foreach (Customer temp in list)
            {
                Panel newPanel = new Panel();
                panelCustomerLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                CustomerItem item = new CustomerItem();
                item.CustomerID = temp.CustomerID;
                item.CustomerName = temp.Name;
                item.Address = temp.Address;
                item.Phone = temp.Phone;
                item.Total = temp.Total;
                item.CustomerType = temp.CustomerType;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }
        public void Reload_Data()
        {
            foreach (Control control in panelCustomerLoad.Controls)
            {
                control.Dispose();
            }

            panelCustomerLoad.Controls.Clear();

            Load_Data();
        }
        private void panelCustomerLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch1.Text != "")
            {
                Reload_Data();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (textBoxSearch1.Text != "")
            {
                textBoxSearch1.Clear();
                Reload_Data();
            }
        }

        private void btnAddNewCustomer_display_Click(object sender, EventArgs e)
        {
            AddNewCustomer form = new AddNewCustomer();
            form.ShowDialog();
        }
    }
}
