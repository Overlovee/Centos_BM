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
using CentosBM.Forms;
namespace CentosBM.Forms
{
    public partial class AddNewCustomer : Form
    {
        public string fullname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            ConnectCustomer customer = new ConnectCustomer();
            fullname = textBoxFullName.Text;
            address = textBoxAddress.Text;
            phone = textBoxPhone.Text;
            int rs = 0;
            rs = customer.addNewCustomer(fullname, address, phone);
            if (rs == 0)
            {
                MessageBox.Show("Error");
            }
            if(rs != 0)
            {
                MessageBox.Show("Complete !!!");
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }

                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form && control.Parent is FormOrder)
                {
                    FormOrder f = (FormOrder)control.Parent;
                    f.LoadNewCustomer(fullname, address, phone);
                }
                this.Close();
            }
        }
    }
}
