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
    public partial class SupplierDetail : Form
    {
        public Supplier supplier { get; set; }
        public List<Product> products { get; set; }
        public bool isUpdated { get; set; }
        public bool isDeleted { get; set; }

        ConnectSupplier connectSupplier;

        public SupplierDetail()
        {
            InitializeComponent();
            products = new List<Product>();
            supplier = new Supplier();
            connectSupplier = new ConnectSupplier();
            isUpdated = false;
            isDeleted = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            supplier.Status = "Đã ngừng cung cấp";
            int kt = connectSupplier.updateDataForItem(supplier);
            if (kt != 0)
            {
                MessageBox.Show("Completely deleting!", "", MessageBoxButtons.OK);
                isDeleted = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Can not delete!", "", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(comboBoxStatus.SelectedItem is null)
                && !(textBoxName.Text is null)
                && !(textBoxPhone.Text is null)
                )
            {
                supplier.Name = textBoxName.Text;
                supplier.PhoneNumber = textBoxPhone.Text;
                string oldStatus = supplier.Status;
                supplier.Status = comboBoxStatus.SelectedItem.ToString();

                int kt = connectSupplier.updateDataForItem(supplier);
                if (kt != 0)
                {
                    MessageBox.Show("Completely updating!", "", MessageBoxButtons.OK);
                    isUpdated = true;
                    if(oldStatus != supplier.Status)
                    {
                        isDeleted= true;
                    }
                    SupplierDetail_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Can not update!", "", MessageBoxButtons.OK);
                }
            }
        }

        private void SupplierDetail_Load(object sender, EventArgs e)
        {
            textBoxName.Text = supplier.Name;
            textBoxPhone.Text = supplier.PhoneNumber;
            labelID.Text = supplier.Id.ToString();
            Load_ComboboxStatus();
            Load_ComboboxCategory();
        }

        public void Load_ComboboxCategory()
        {
            comboBoxCategory.Items.Clear();
            ConnectCategory connectCategory = new ConnectCategory();
            List<Category> categories = new List<Category>();
            categories = connectCategory.GetCategories();
            foreach (Category category in categories)
            {
                comboBoxCategory.Items.Add(category.Name);
            }
            comboBoxCategory.Items.Add("Tất cả");
            comboBoxCategory.SelectedItem = "Tất cả";
        }
        public void Load_ComboboxStatus()
        {
            comboBoxStatus.Items.Clear();
            List<string> statuses = new List<string>();
            statuses = connectSupplier.getStatus();
            foreach (string item in statuses)
            {
                comboBoxStatus.Items.Add(item);
            }
            comboBoxStatus.SelectedItem = supplier.Status;
            if (comboBoxStatus.SelectedItem.ToString() == "Đã ngừng cung cấp")
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        public void Load_Data()
        {
            ConnectProduct connectProduct = new ConnectProduct();
            List<Product> products = new List<Product>();
            products = connectProduct.getProductsOfSupplier(supplier.Id, comboBoxCategory.SelectedItem.ToString());
            foreach (Product pro in products)
            {
                Panel newPanel = new Panel();
                panelDetail.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 170;

                SmallProductItem item = new SmallProductItem();
                item.product = pro;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 150;
            }
        }

        public void Reload_Data()
        {
            foreach (Control control in panelDetail.Controls)
            {
                control.Dispose();
            }

            panelDetail.Controls.Clear();

            Load_Data();
        }

        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            Reload_Data();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!(comboBoxStatus.SelectedItem is null)
                && !(textBoxName.Text is null)
                && !(textBoxPhone.Text is null)
                )
            {
                if (comboBoxStatus.SelectedItem.ToString() != supplier.Status
                || textBoxName.Text != supplier.Name
                || textBoxPhone.Text != supplier.PhoneNumber
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
    }
}
