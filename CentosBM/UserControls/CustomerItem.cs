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
using CentosBM.SubForms;
namespace CentosBM.UserControls
{
    public partial class CustomerItem : UserControl
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Total { get; set; }
        public string CustomerType { get; set; }
        public CustomerItem()
        {
            InitializeComponent();
        }

        private void CustomerItem_Load(object sender, EventArgs e)
        {
            labelCustomerName.Text = CustomerName.ToString();
            labelPhone.Text = Phone.ToString();
            labelTotal.Text = Total.ToString() + " " + "VND";
            label_CusType.Text = CustomerType.ToString();
        }
    }
}
