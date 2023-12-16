using CentosBM.Connects;
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

namespace CentosBM.SubForms
{
    public partial class AddingNewSupplierForm : Form
    {
        public bool isSuccessful { get; set; }
        public AddingNewSupplierForm()
        {
            InitializeComponent();
            isSuccessful= false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" && textBoxPhone.Text != "")
            {
                Supplier supplier = new Supplier();
                supplier.Name = textBoxName.Text;
                supplier.PhoneNumber = textBoxPhone.Text;
                ConnectSupplier connectSupplier = new ConnectSupplier();
                int kt = connectSupplier.addNewItem(supplier);
                if (kt != 0)
                {
                    MessageBox.Show("Completely adding !", "", MessageBoxButtons.OK);
                    isSuccessful = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Can not add !", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please type all field !", "", MessageBoxButtons.OK);
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32)
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}
