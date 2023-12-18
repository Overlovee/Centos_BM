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
using CentosBM.UserControls;
namespace CentosBM.Forms
{
    public partial class Home : Form
    {
        public MyAccount account { get; set; }
        public List<Product> productList { get; set; } = new List<Product>();
        public Home()
        {
            InitializeComponent();
            account = new MyAccount();


        }
        private void Load_CategoryCombobox()
        {
            ConnectCategory connectCategory = new ConnectCategory();
            List<Category> categories = connectCategory.GetCategories();
            comboBoxCategoryType.Items.Clear();
            comboBoxCategoryType.Items.Add("Tất cả");
            foreach (Category item in categories)
            {
                comboBoxCategoryType.Items.Add(item.Name);
            }
            comboBoxCategoryType.SelectedItem = "Tất cả";
        }
        public List<Product> AddProductOrder(Product product)
        {

            if (!productList.Any(p => p.Id == product.Id))
            {
                // Nếu chưa tồn tại, thêm vào danh sách
                productList.Add(product);
            }
            else
            {
                // Nếu đã tồn tại, tăng số lượng quantity lên 1
                Product existingProduct = productList.First(p => p.Id == product.Id);
                existingProduct.Quantity += 1;
            }
            return productList;
        }
        private void label3_display_Click(object sender, EventArgs e)
        {

        }
        public decimal total()
        {
            decimal Total = 0;
            foreach (Product product in productList)
            {
                Total = Total + (product.Quantity * product.Price);
            }
            return Total;
        }

        public void UpdateProductById(int productId, int newQuantity)
        {
            Product productToUpdate = productList.FirstOrDefault(p => p.Id == productId);

            if (productToUpdate != null)
            {
                productToUpdate.Quantity = newQuantity;
                textBox_total.Text = total().ToString();

            }
            else
            {
                Console.WriteLine($"Product with ID {productId} not found");
            }
        }
        public void DeleteProductById(int productId)
        {
            Product productToDelete = productList.FirstOrDefault(p => p.Id == productId);

            if (productToDelete != null)
            {
                productList.Remove(productToDelete);
                textBox_total.Text = total().ToString();
                load_Data_Order_Detail();
            }
            else
            {
                Console.WriteLine($"Product with ID {productId} not found");
            }
        }
        public List<Product> GetProducts()
        {
            return productList;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Load_CategoryCombobox();
            Load_Data();

        }
        public void load_Data_Order_Detail()
        {
            foreach (Control control in panel_ListProductInOrder.Controls)
            {
                control.Dispose();
            }
            panel_ListProductInOrder.Controls.Clear();
            load_Data_Order_Detail(productList);
        }
        public void load_Data_Order_Detail(List<Product> products)
        {
            foreach (Product product in products)
            {
                Panel newPanel = new Panel();
                panel_ListProductInOrder.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                OrderProductItem item = new OrderProductItem();
                item.product = product;


                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 50;
                item.ForeColor = Color.Black;
            }
            textBox_total.Text = total().ToString();
        }

        public void Load_Data(bool isSearched = false)
        {
            ConnectProduct connectProduct = new ConnectProduct();
            List<Product> list = new List<Product>();
            if (!isSearched)
            {
                list = connectProduct.getProducts();
            }
            else
            {
                list = connectProduct.getProducts(textBoxSearch.Text, comboBoxCategoryType.SelectedItem.ToString());
            }
            foreach (Product product in list)
            {
                Panel newPanel = new Panel();
                panelProducts.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                ProductItem item = new ProductItem();
                item.product = product;


                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 50;
                item.ForeColor = Color.Black;
            }
        }
        public void Reload_Data(bool isSearched = false)
        {
            foreach (Control control in panelProducts.Controls)
            {
                control.Dispose();
            }

            panelProducts.Controls.Clear();

            Load_Data(isSearched);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCategoryType_SelectedIndexChanged(object sender, EventArgs e)
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

        private void panel_ListProductInOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button_Submit_Click(object sender, EventArgs e)
        //{
        //    OrderForm form = new OrderForm();
        //    form.SetProductList(productList);
        //    form.ShowDialog();
 

        //}

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                textBoxSearch.Clear();
                comboBoxCategoryType.SelectedItem = "Tất cả";
                Reload_Data(false);
            }
        }

        private void panelProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_TotalpriceOrder_Click(object sender, EventArgs e)
        {

        }

        private void button_Submit_Click_1(object sender, EventArgs e)
        {
            List<Product> products = GetProducts();
            FormOrder form = new FormOrder();
            form.account = account;
            form.total = total();
            form.SetProductList(products);
            form.ShowDialog();

        }
    }
}
