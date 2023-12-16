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
    public partial class ProductItem : UserControl
    {
        //public int Product_ID { get; set; }
        //public string Product_Name { get; set; }
        //public string Product_Img { get; set; }
        //public decimal Product_Price { get; set; }
        //public int Quantity { get; set; }
        public Product product { get; set; }
        public ProductItem()
        {
            InitializeComponent();
            //Product_ID = 0;
            //Product_Name = "";
            //Product_Img = "";
            //Product_Price = 1;
            //Quantity = 1;
            product = new Product();
        }

        private void ProductItem_Load(object sender, EventArgs e)
        {
            labelProductName.Text = product.Name;

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

        private void labelCategoryName_Click(object sender, EventArgs e)
        {

        }

        public void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product temp = new Product();

            if (product.Id != 0)
            {
                temp = product;

                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }

                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form && control.Parent is Home)
                {
                    Home f = (Home)control.Parent;
                    f.AddProductOrder(product);
                    f.load_Data_Order_Detail();
                }
            }
            else
            {
                MessageBox.Show("Please enter a product ID.");
            }
        }

    }
}
