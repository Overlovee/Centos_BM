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

namespace CentosBM.Forms
{
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            ConnectCategory connectCate = new ConnectCategory();
            int t = connectCate.addNew(txt_NameCategory.Text);
            if (t == 1)
            {
                MessageBox.Show(" Them Thanh Cong");
                this.Close();
            }
            else

            {
                MessageBox.Show("Them khong thanh cong");
            }

        }  
    }
}
