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
using CentosBM.Forms;
using System.Data.SqlClient;
using CentosBM.Connects;
namespace CentosBM.Forms
{
    public partial class FormEditCategory : Form
    {
        public Category category { get; set; }
        DbContext dbContext = new DbContext();
       

        public FormEditCategory()
        {
            InitializeComponent();
           
        }


        private void btnSaveEditing_Click(object sender, EventArgs e)
        {
            ConnectCategory connectCategory = new ConnectCategory();
            int rowsAffected = connectCategory.UpdateDataForItem(category.Id,textBoxCategoryName.Text);
            if (rowsAffected == 0)
            {
                MessageBox.Show("Cập nhật không thành công.");
                

            }
            else
            {
                MessageBox.Show("Cập nhật thành công.");
            }
            

        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            textBoxCategoryName.Text = category.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
