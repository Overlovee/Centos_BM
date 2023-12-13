﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosBM.UserControls
{
    public partial class SmallProductItem : UserControl
    {
        public string Name { get; set; }
        public SmallProductItem()
        {
            InitializeComponent();
            Name = "Gạch";
        }

        private void SmallProductItem_Load(object sender, EventArgs e)
        {
            label1.Text = Name;
        }
    }
}
