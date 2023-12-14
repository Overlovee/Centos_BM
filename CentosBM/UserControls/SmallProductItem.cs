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
using CentosBM.Forms;
using CentosBM.Models;
using CentosBM.SubForms;

namespace CentosBM.UserControls
{
    public partial class SmallProductItem : UserControl
    {
        public Product product { get; set; }
        public SmallProductItem()
        {
            InitializeComponent();
            product = new Product();
        }

        private void SmallProductItem_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        public void Load_Data()
        {
            labelName.Text = product.Name;
            labelSupplierName.Text = product.SupplierName;
            labelCategoryName.Text = product.CategoryName;
            labelPrice.Text = product.Price.ToString() + " /" + product.Unit;
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

        private void pictureBoxProduct_Click(object sender, EventArgs e)
        {
            ProductDetail productDetail = new ProductDetail();
            productDetail.product = product;
            productDetail.ShowDialog();
            if (productDetail.isUpdated)
            {
                product = productDetail.product;
                Load_Data();
            }
            if (productDetail.isDeleted)
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Panel))
                {
                    control = control.Parent;
                }

                if (control.Parent is Panel)
                {
                    control.Parent.Dispose();
                }
            }
        }
    }
}
