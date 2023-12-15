using CentosBM.Connects;
using CentosBM.Models;
using CentosBM.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosBM.Forms
{
    public partial class OrderForm : Form
    {
        ConnectOrder connectOrder = new ConnectOrder();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Load_OrderStatusComboBox()
        {
            List<string> list = connectOrder.getOrderStatus();
            comboBoxOrderStatusLoad.Items.Clear();
            comboBoxOrderStatusLoad.Items.Add("Tất cả");
            foreach (string item in list)
            {
                comboBoxOrderStatusLoad.Items.Add(item);
            }
            comboBoxOrderStatusLoad.SelectedItem = "Chưa thanh toán";
        }
        public void Load_Data(bool isSearched = false)
        {
            List<Order> orders = new List<Order>();
            if (!isSearched)
            {
                orders = connectOrder.getData(textBoxSearch.Text, "Chưa thanh toán");
            }
            else
            {
                if (comboBoxOrderStatusLoad.SelectedItem.ToString() == "Tất cả")
                {
                    orders = connectOrder.getAllData(textBoxSearch.Text);
                }
                else
                {
                    orders = connectOrder.getData(textBoxSearch.Text, comboBoxOrderStatusLoad.SelectedItem.ToString());
                }
                
            }

            foreach (Order order in orders)
            {
                Panel newPanel = new Panel();
                panelOrdersLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                SmallOrderItem item = new SmallOrderItem();
                item.order = order;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        public void Reload_Data(bool isSearched = false)
        {
            foreach (Control control in panelOrdersLoad.Controls)
            {
                control.Dispose();
            }

            panelOrdersLoad.Controls.Clear();

            Load_Data(isSearched);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Load_OrderStatusComboBox();
            Load_Data(false);
        }

        private void comboBoxOrderStatusLoad_SelectedValueChanged(object sender, EventArgs e)
        {
            Reload_Data(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                Reload_Data(true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                textBoxSearch.Clear();
                comboBoxOrderStatusLoad.SelectedItem = "Chưa thanh toán";
                Reload_Data(false);
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (textBoxSearch.Text != "")
                {
                    Reload_Data(true);
                }
            }
        }
    }
}
