using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosBM.UserControls
{
    public partial class SmallOrderItem : UserControl
    {
        public Order order { get; set; }
        public SmallOrderItem()
        {
            InitializeComponent();
            order = new Order();
        }

        private void SmallOrderItem_Load(object sender, EventArgs e)
        {
            labelID.Text = order.OrderID;
            labelName.Text = order.CustomerName;
            labelPhone.Text = order.CustomerPhoneNumber;
            labelDate.Text = order.OrderDate.ToString();
            labelTotal.Text = order.TotalAmount.ToString() + " VND";
            labelShipmentStatus.Text = order.ShipmentStatus;
            labelOrderStatus.Text = order.OrderStatus;
        }
    }
}
