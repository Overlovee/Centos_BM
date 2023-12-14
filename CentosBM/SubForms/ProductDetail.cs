using CentosBM.Connects;
using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosBM.SubForms
{
    public partial class ProductDetail : Form
    {
        public Product product { get; set; }
        public bool isUpdated { get; set; }
        public ProductDetail()
        {
            InitializeComponent();
            product = new Product();
            isUpdated = false;
        }

        private void Load_CategoryCombobox()
        {
            ConnectCategory connectCategory = new ConnectCategory();
            List<Category> categories = connectCategory.GetCategories();
            comboBoxCategory.Items.Clear();
            foreach (Category item in categories)
            {
                comboBoxCategory.Items.Add(item.Name);
            }
            comboBoxCategory.SelectedItem = product.CategoryName;
        }
        private void Load_ComboBoxSupplier()
        {
            ConnectSupplier connectSupplier = new ConnectSupplier();
            List<Supplier> suppliers = connectSupplier.getSuppliers();
            comboBoxSupplier.Items.Clear();
            foreach (Supplier item in suppliers)
            {
                comboBoxSupplier.Items.Add(item.Name);
            }
            comboBoxSupplier.SelectedItem = product.SupplierName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Load_Data()
        {
            textBoxName.Text = product.Name;
            textBoxPrice.Text = product.Price.ToString();
            richTextBoxDescription.Text = product.Description;
            textBoxQuantityInStock.Text = product.QuantityInStock.ToString();
            string imagePath = product.Url;

            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath));
            if (!imagePath.Contains("\\"))
            {
                imagePath = Path.Combine(projectPath, @"Images", imagePath);
            }

            if (File.Exists(imagePath))
            {
                pictureBoxProduct.Image = System.Drawing.Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxProduct.Image = CentosBM.Properties.Resources.categories;
            }
            Load_CategoryCombobox();
            Load_ComboBoxSupplier();
        }
        private void ProductDetail_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void pictureBoxProduct_Click(object sender, EventArgs e)
        {
            string role = "admin";
            if (role == "admin")
            {
                string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath));

                string initialDirectory = Path.Combine(projectPath, @"Images");

                using (OpenFileDialog df = new OpenFileDialog()
                {
                    Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
                    InitialDirectory = initialDirectory
                })
                {
                    if (df.ShowDialog() == DialogResult.OK)
                    {
                        pictureBoxProduct.Image = Image.FromFile(df.FileName);
                        product.Url = Path.GetFileName(df.FileName);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string role = "admin";
            if (role == "admin")
            {
                ConnectProduct connectProduct = new ConnectProduct();
                int kt = connectProduct.updateDataForItem(product);
                if (kt != 0)
                {
                    MessageBox.Show("Completely updating!", "", MessageBoxButtons.OK);
                    isUpdated = true;
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot update!", "", MessageBoxButtons.OK);
                }
            }
        }

        private void comboBoxSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(comboBoxSupplier.SelectedItem is null)
                && !(comboBoxCategory.SelectedItem is null)
                //&& !(cbbTimeFormat.SelectedItem is null)
                /*&& !(cbbOverviewDisplayMode.SelectedItem is null)*/)
            {
                if (comboBoxSupplier.SelectedItem.ToString() != product.SupplierName
                || comboBoxCategory.SelectedItem.ToString() != product.CategoryName
                //|| cbbTimeFormat.SelectedItem.ToString() != userSetting.TimeFormat
                /*|| cbbOverviewDisplayMode.SelectedItem.ToString() != userSetting.OverviewDisplayMode*/)
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
