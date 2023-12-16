using CentosBM.Models;
using CentosBM.SubForms;
using System;
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
    public partial class SmallSupplierItem : UserControl
    {
        public Supplier supplier { get; set; }
        public SmallSupplierItem()
        {
            InitializeComponent();
            supplier = new Supplier();
        }

        private void SmallSupplierItem_Load(object sender, EventArgs e)
        {
            labelSupplierID.Text = supplier.Id.ToString();
            labelSupplierName.Text = supplier.Name;
            labelPhone.Text = supplier.PhoneNumber;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            SupplierDetail supplierDetail = new SupplierDetail();
            supplierDetail.supplier = supplier;
            supplierDetail.ShowDialog();
            if (supplierDetail.isUpdated)
            {
                supplier = supplierDetail.supplier;
                SmallSupplierItem_Load(sender, e);
            }
            if (supplierDetail.isDeleted)
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
