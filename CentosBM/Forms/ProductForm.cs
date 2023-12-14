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
using CentosBM.Connects;
using CentosBM.Models;
using CentosBM.SubForms;

namespace CentosBM.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            Load_CategoryCombobox();
            Load_Data();
        }
        private void Load_CategoryCombobox()
        {
            ConnectCategory connectCategory = new ConnectCategory();
            List<Category> categories = connectCategory.GetCategories();
            comboBoxCategoryLoad.Items.Clear();
            comboBoxCategoryLoad.Items.Add("Tất cả");
            foreach (Category item in categories)
            {
                comboBoxCategoryLoad.Items.Add(item.Name);
            }
            comboBoxCategoryLoad.SelectedItem = "Tất cả";
        }
        public void Load_Data(bool isSearched = false)
        {
            ConnectProduct connectProduct = new ConnectProduct();
            List<Product> products = new List<Product>();
            if (!isSearched)
            {
                products = connectProduct.getProducts();
            }
            else
            {
                products = connectProduct.getProducts(textBoxSearch.Text, comboBoxCategoryLoad.SelectedItem.ToString());
            }

            foreach (Product pro in products)
            {
                Panel newPanel = new Panel();
                panelProductDetailLoading.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 170;

                SmallProductItem item = new SmallProductItem();
                item.product = pro;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 150;
            }
        }

        public void Reload_Data(bool isSearched = false)
        {
            foreach (Control control in panelProductDetailLoading.Controls)
            {
                control.Dispose();
            }

            panelProductDetailLoading.Controls.Clear();

            Load_Data(isSearched);
        }

        private void comboBoxCategoryLoad_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                textBoxSearch.Clear();
                comboBoxCategoryLoad.SelectedItem = "Tất cả";
                Reload_Data(false);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddingNewProductForm addingNewProductForm = new AddingNewProductForm();
            addingNewProductForm.ShowDialog();
            if (addingNewProductForm.isAdded)
            {
                Product product = new Product();
                product = addingNewProductForm.product;

                Panel newPanel = new Panel();
                panelProductDetailLoading.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 170;

                SmallProductItem item = new SmallProductItem();
                item.product = product;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 150;
            }
        }
    }
}
