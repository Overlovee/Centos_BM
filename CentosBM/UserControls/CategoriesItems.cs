using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentosBM.Models;
using CentosBM.SubForms;
namespace CentosBM.UserControls
{
    public partial class CategoriesItems : UserControl
    {
        public Category category { get; set; }
        public CategoriesItems()
        {
            InitializeComponent();
            category = new Category();
        }

        public void Load_Data()
        {
            labelCategoriesName.Text = category.Name;
        }

        private void CategoriesItems_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
