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

namespace CentosBM.SubForms
{
    public partial class AddingNewProductForm : Form
    {
        public AddingNewProductForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxProduct_Click(object sender, EventArgs e)
        {
            string role = "admin";
            if (role == "admin")
            {
                string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath));

                string initialDirectory = Path.Combine(projectPath, @"Images");

                using (OpenFileDialog df = new OpenFileDialog()
                {
                    Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
                    InitialDirectory = initialDirectory
                })
                {
                    if (df.ShowDialog() == DialogResult.OK)
                    {
                        pictureBoxProduct.Image = Image.FromFile(df.FileName);
                    }
                }
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
