using CentosBM.Connects;
using CentosBM.Models;
using CentosBM.UserControls;
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
    public partial class AddingNewProductForm : Form
    {
        public Product product { get; set; }
        public bool isAdded { get; set; }
        public AddingNewProductForm()
        {
            InitializeComponent();
            product = new Product();
            isAdded = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        comboBoxSupplier_SelectedValueChanged(sender, e);
                    }
                }
            }
        }

        private void textBoxPrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32 && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void textBoxQuantityInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32)
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(comboBoxSupplier.SelectedItem is null)
                && !(comboBoxCategory.SelectedItem is null)
                && !(product.Url == "")
                && !(textBoxName.Text == "")
                && !(textBoxPrice.Text == "")
                && !(textBoxQuantityInStock.Text == "")
                && !(richTextBoxDescription.Text == "")
                && !(textBoxUnit.Text == "")
                )

            {
                product.SupplierName = comboBoxSupplier.SelectedItem.ToString();
                product.CategoryName = comboBoxCategory.SelectedItem.ToString();
                product.Name = textBoxName.Text;
                product.Price = decimal.Parse(textBoxPrice.Text);
                product.QuantityInStock = int.Parse(textBoxQuantityInStock.Text);
                product.Description = richTextBoxDescription.Text;
                product.Unit = textBoxUnit.Text;
                ConnectProduct connectProduct = new ConnectProduct();
                int id = connectProduct.addNewItem(product);

                if (id != 0)
                {
                    product.Id = id;
                    MessageBox.Show("Completely adding!", "", MessageBoxButtons.OK);
                    isAdded = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot add!", "", MessageBoxButtons.OK);
                }
            }
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
            comboBoxCategory.Items.Add("Thêm mới");
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
            comboBoxSupplier.Items.Add("Thêm mới");
        }
        private void AddingNewProductForm_Load(object sender, EventArgs e)
        {
            Load_CategoryCombobox();
            Load_ComboBoxSupplier();
        }

        private void comboBoxSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((comboBoxSupplier.SelectedItem is null)
                || (comboBoxCategory.SelectedItem is null)
                || (product.Url == "")
                || (textBoxName.Text == "")
                || (textBoxPrice.Text == "")
                || (textBoxQuantityInStock.Text == "")
                || (richTextBoxDescription.Text == "")
                || (textBoxUnit.Text == "")
                )

            {

                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
    }
}
