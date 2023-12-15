﻿using CentosBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosBM.UserControls
{
    public partial class SmallOrderDetailItem : UserControl
    {
        public Product product { get; set; }
        public SmallOrderDetailItem()
        {
            InitializeComponent();
            product = new Product();
        }

        private void SmallOrderDetailItem_Load(object sender, EventArgs e)
        {
            Load_Data();

        }
        public void Load_Data()
        {
            labelName.Text = product.Name;
            labelSupplierName.Text = product.SupplierName;
            labelCategoryName.Text = product.CategoryName;
            labelPrice.Text = product.Price.ToString() + " /" + product.Unit;
            labelQuantity.Text = "x" + product.Quantity.ToString();
            labelTotal.Text = (product.Quantity * product.Price).ToString() + " VND";
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
    }
}
