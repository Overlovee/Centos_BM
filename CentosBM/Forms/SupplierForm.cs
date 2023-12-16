using CentosBM.Connects;
using CentosBM.Models;
using CentosBM.SubForms;
using CentosBM.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CentosBM.Forms
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            Load_ComboboxStatus();
            Load_Data();
        }
        public void Load_ComboboxStatus()
        {
            comboBoxStatus.Items.Clear();
            ConnectSupplier connectSupplier = new ConnectSupplier();
            List<string> statuses = new List<string>();
            statuses = connectSupplier.getStatus();
            foreach (string item in statuses)
            {
                comboBoxStatus.Items.Add(item);
            }
            comboBoxStatus.Items.Add("Tất cả");
            comboBoxStatus.SelectedItem = "Đang cung cấp";
        }

        public void Load_Data()
        {
            foreach (Control control in panelSupplierLoading.Controls)
            {
                control.Dispose();
            }

            panelSupplierLoading.Controls.Clear();

            ConnectSupplier connectSupplier = new ConnectSupplier();
            List<Supplier> list = new List<Supplier>();
            list = connectSupplier.getSuppliers(textBoxSearch.Text, comboBoxStatus.SelectedItem.ToString());

            foreach (Supplier temp in list)
            {
                Panel newPanel = new Panel();
                panelSupplierLoading.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                SmallSupplierItem item = new SmallSupplierItem();
                item.supplier = temp;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        public void Reload_Data()
        {
            Load_Data();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                Reload_Data();
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (textBoxSearch.Text != "")
                {
                    Reload_Data();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                textBoxSearch.Clear();
                Reload_Data();
            }
        }

        private void comboBoxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            Reload_Data();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddingNewSupplierForm addingNewSupplierForm = new AddingNewSupplierForm();
            addingNewSupplierForm.ShowDialog();
            if(addingNewSupplierForm.isSuccessful)
            {
                Reload_Data();
            }
        }
    }
}
