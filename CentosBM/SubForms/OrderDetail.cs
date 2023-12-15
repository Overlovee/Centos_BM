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

namespace CentosBM.SubForms
{
    public partial class OrderDetail : Form
    {
        public Order order { get; set; }
        public bool isUpdated { get; set; }
        public bool isCanceled { get; set; }
        public OrderDetail()
        {
            InitializeComponent();
            order = new Order();
            isUpdated = false;
            isCanceled = false;
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        public void Load_Data()
        {

            ConnectEmployee connectEmployee = new ConnectEmployee();
            Employee employee = connectEmployee.getDataByID(order.EmployeeID);

            labelEmployeeID.Text = "NV" + employee.EmployeeID.ToString();
            labelEmployeeName.Text = employee.FullName;

            labelOrderID.Text = order.OrderID;
            labelOrderDate.Text = order.OrderDate.ToString("dd/MM/yyyy HH:mm");

            textBoxCustomerAddress.Text = order.CustomerAddress;
            textBoxCustomerName.Text = order.CustomerName;
            textBoxCustomerPhoneNumber.Text = order.CustomerPhoneNumber;

            comboBoxOrderStatus.Items.Clear();
            comboBoxShipmentStatus.Items.Clear();

            comboBoxShipmentStatus.Items.Add("Đã giao hàng");
            comboBoxShipmentStatus.Items.Add("Chờ giao hàng");
            if (order.ShipmentStatus == "Đã huỷ")
            {
                comboBoxShipmentStatus.Items.Add("Đã huỷ");
                comboBoxShipmentStatus.Enabled = false;
                comboBoxOrderStatus.Enabled = false;
                textBoxCustomerAddress.Enabled = false;
                textBoxCustomerName.Enabled = false;
                textBoxCustomerPhoneNumber.Enabled = false;
                btnSave.Enabled = false;
                btnCancelOrder.Enabled = false;
            }

            comboBoxShipmentStatus.SelectedItem = order.ShipmentStatus;

            if (order.ShipmentStatus != "Chờ giao hàng")
            {
                //comboBoxShipmentStatus.Enabled = true;
                textBoxCustomerAddress.Enabled = false;
                textBoxCustomerName.Enabled = false;
                textBoxCustomerPhoneNumber.Enabled = false;
            }

            comboBoxOrderStatus.Items.Add("Chưa thanh toán");
            comboBoxOrderStatus.Items.Add("Đã thanh toán");
            comboBoxOrderStatus.SelectedItem = order.OrderStatus;
            //if (order.OrderStatus == "Chưa thanh toán")
            //{
            //    comboBoxOrderStatus.Enabled = true;
            //}
            


            ConnectProduct connectProduct = new ConnectProduct();
            List<Product> list = new List<Product>();
            list = connectProduct.getProductsInOrder(order.OrderID);

            decimal total = 0;
            foreach (Product pro in list)
            {
                Panel newPanel = new Panel();
                panelOrderDetail.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 130;

                SmallOrderDetailItem item = new SmallOrderDetailItem();
                item.product = pro;
                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 120;
                total += pro.Quantity * pro.Price;
            }

            labelOrderTotal.Text = total.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxShipmentStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(comboBoxOrderStatus.SelectedItem is null)
                && !(comboBoxOrderStatus.SelectedItem is null)
                && !(textBoxCustomerName.Text == "")
                && !(textBoxCustomerAddress.Text == "")
                && !(textBoxCustomerPhoneNumber.Text == "")
                )

            {
                if (comboBoxOrderStatus.SelectedItem.ToString() != order.OrderStatus
                || comboBoxShipmentStatus.SelectedItem.ToString() != order.ShipmentStatus
                || textBoxCustomerName.Text != order.CustomerName
                || textBoxCustomerAddress.Text != order.CustomerAddress
                || textBoxCustomerPhoneNumber.Text != order.CustomerPhoneNumber
                )

                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            order.CustomerName = textBoxCustomerName.Text;
            order.CustomerAddress = textBoxCustomerAddress.Text;
            order.CustomerPhoneNumber = textBoxCustomerPhoneNumber.Text;
            order.OrderStatus = comboBoxOrderStatus.SelectedItem.ToString();
            order.ShipmentStatus = comboBoxShipmentStatus.SelectedItem.ToString();

            ConnectOrder connectOrder = new ConnectOrder();
            int kt = connectOrder.updateDataForItem(order);
            if (kt != 0)
            {
                MessageBox.Show("Completely updating!", "", MessageBoxButtons.OK);
                isUpdated = true;
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cannot update!", "", MessageBoxButtons.OK);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            order.ShipmentStatus = "Đã huỷ";
            ConnectOrder connectOrder = new ConnectOrder();
            int kt = connectOrder.updateDataForItem(order);
            if (kt != 0)
            {
                MessageBox.Show("Completely canceling!", "", MessageBoxButtons.OK);
                isCanceled = true;
                comboBoxShipmentStatus.Items.Add("Đã huỷ");
                comboBoxShipmentStatus.Enabled = false;
                comboBoxOrderStatus.Enabled = false;
                textBoxCustomerAddress.Enabled = false;
                textBoxCustomerName.Enabled = false;
                textBoxCustomerPhoneNumber.Enabled = false;
                btnSave.Enabled = false;
                btnCancelOrder.Enabled = false;
                comboBoxShipmentStatus.SelectedItem = order.ShipmentStatus;

            }
            else
            {
                MessageBox.Show("Cannot cancel!", "", MessageBoxButtons.OK);
            }
        }
    }
}
