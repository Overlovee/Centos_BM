using CentosBM.ChildForms;
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
        public bool isDeleted { get; set; }
        public string newImg { get; set; }
        public ProductDetail()
        {
            InitializeComponent();
            product = new Product();
            isUpdated = false;
            isDeleted = false;
            newImg = "";
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
            textBoxUnit.Text = product.Unit;
            newImg = product.Url;

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
                        newImg = Path.GetFileName(df.FileName);
                        comboBoxSupplier_SelectedValueChanged(sender, e);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string role = "admin";
            if (role == "admin")
            {
                product.SupplierName = comboBoxSupplier.SelectedItem.ToString();
                product.CategoryName = comboBoxCategory.SelectedItem.ToString();
                product.Url = newImg;
                product.Name = textBoxName.Text;
                product.Price = decimal.Parse(textBoxPrice.Text);
                product.QuantityInStock = int.Parse(textBoxQuantityInStock.Text);
                product.Description = richTextBoxDescription.Text;
                product.Unit = textBoxUnit.Text;
                ConnectProduct connectProduct = new ConnectProduct();
                int kt = connectProduct.updateDataForItem(product);
                if (kt != 0)
                {
                    MessageBox.Show("Completely updating!", "", MessageBoxButtons.OK);
                    isUpdated = true;
                    this.Close();
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
                && !(newImg is null)
                && !(textBoxName.Text is null)
                && !(textBoxPrice.Text is null)
                && !(textBoxQuantityInStock.Text is null)
                && !(richTextBoxDescription.Text is null)
                && !(textBoxUnit.Text is null)

                )

            {
                if (comboBoxSupplier.SelectedItem.ToString() != product.SupplierName
                || comboBoxCategory.SelectedItem.ToString() != product.CategoryName
                || newImg != product.Url
                || textBoxName.Text != product.Name
                || textBoxPrice.Text != product.Price.ToString()
                || textBoxQuantityInStock.Text != product.QuantityInStock.ToString()
                || richTextBoxDescription.Text != product.Description
                || textBoxUnit.Text != product.Unit
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            ConnectProduct connectProduct = new ConnectProduct();
            int kt = connectProduct.deleteDataById(product.Id);
            if (kt != 0)
            {
                MessageBox.Show("Completely deleting!", "", MessageBoxButtons.OK);
                isDeleted = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cannot delete!", "", MessageBoxButtons.OK);
            }
        }

        private void textBoxQuantityInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            int count = 0;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32 && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
            if (e.KeyChar == '.')
            {
                count++;
                if (count >= 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            int count = 0;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32 && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
            if (e.KeyChar == '.')
            {
                count++;
                if (count >= 2)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
