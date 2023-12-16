using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;
using CentosBM.Models;
using CentosBM.Forms;
namespace CentosBM.UserControls
{
    public partial class OrderProductItem : UserControl
    {
        //public int Product_ID { get; set; }
        //public string Product_Name { get; set; }
        //public string Product_Img { get; set; }
        //public decimal Product_Price { get; set; }
        //public int Quantity { get; set; }
        public Product product { get; set; }
        public OrderProductItem()
        {
            InitializeComponent();
            //Product_ID = 0;
            //Product_Name = "";
            //Product_Img = "";
            //Product_Price = 0;
            //Quantity = 0;
            product = new Product();
        }

        private void labelCategoryName_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Quantity_Click(object sender, EventArgs e)
        {

        }

        private void OrderProductItem_Load(object sender, EventArgs e)
        {
            label_ProductName.Text = product.Name;
            label_Price.Text = product.Price.ToString();
            textBox_Quantity.Text = product.Quantity.ToString();
            labelTotal.Text = (product.Price * product.Quantity).ToString();

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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Quantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            if (int.TryParse(textBox_Quantity.Text, out int quantity))
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }

                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form && control.Parent is Home)
                {
                    Home f = (Home)control.Parent;
                    f.UpdateProductById(product.Id,int.Parse(textBox_Quantity.Text));
                }
                labelTotal.Text = (product.Price * product.Quantity).ToString();
            }
            else
            {
                labelTotal.Text = "Invalid Quantity";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control control = (Control)this;
            while (control.Parent != null && !(control.Parent is Form))
            {
                control = control.Parent;
            }

            // Kiểm tra xem control.Parent có phải là Form
            if (control.Parent is Form && control.Parent is Home)
            {
                Home f = (Home)control.Parent;
                f.DeleteProductById(product.Id);
            }
        }
    }
}
