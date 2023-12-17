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
    public partial class CategoryForm : Form
    {

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        public void Load_Data(bool isSearched = false)
        {
            ConnectCategory connectCategory = new ConnectCategory();
            List<Category> categories = connectCategory.GetCategories();
            foreach (Category category in categories)
            {
                Panel newPanel = new Panel();
                panelCategoryLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                CategoriesItems item = new CategoriesItems(this);
                item.category = category;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }
        public void DeleteCategory()
        {
            panelCategoryLoad.Controls.Clear();
        }

        private void btnAddNewLanguage_display_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            formAddCategory.ShowDialog();
            Load_Data();

        }
    }
}
