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
using CentosBM.Forms;
using CentosBM.Models;

namespace CentosBM
{
    public partial class Menu : Form
    {
        private Button currentButton;
        private Form activeForm;
        public MyAccount account { get; set; }
        public Menu()
        {
            InitializeComponent();
            account = new MyAccount();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Gray;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Black;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.Tag = this.Tag;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTittle_display.Text = childForm.Text;
        }

        private void EmptyClickHandler(object sender, EventArgs e)
        {

        }
        private void AssignPermissions()
        {
            if (account.Role != 1 && account.Role != 2)
            {
                btnCategoryForm.Hide();
                btnManageAccountForm.Hide();
                btnSupplierForm.Hide();
            }
        }
        public void Load_Form()
        {
            AssignPermissions();
            this.Show();
        }
        public void Reload_Form()
        {
            Load_Form();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (Control btn in panelMenu.Controls)
            {
                btn.Show();
            }
            Load_Form();
        }
        private void goToHome()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            DisableButton();
            btnHomeForm.BackColor = Color.Gray;
            btnHomeForm.ForeColor = Color.White;
            btnHomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Form childForm = new Forms.Home();
            activeForm = childForm;
            childForm.Tag = this.Tag;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTittle_display.Text = childForm.Text;
            //dictionary.UpdateUIWithLanguage(lblTittle_display);
        }
        private void labelIcon_Click(object sender, EventArgs e)
        {
            goToHome();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void btnShowProductForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ProductForm(), sender);
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.OrderForm(), sender);
        }

        private void btnSupplierForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SupplierForm(), sender);
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CategoryForm(), sender);
        }

        private void btnOverviewForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Overview(), sender);
        }

        private void btnHomeForm_Click(object sender, EventArgs e)
        {
            Forms.Home form = new Forms.Home();
            form.account = this.account;
            OpenChildForm(form, sender);
        }


        private void btnManageAccountForm_Click(object sender, EventArgs e)
        {
            Forms.ManageEmployeesForm form = new Forms.ManageEmployeesForm();
            form.account = this.account;
            OpenChildForm(form, sender);
        }

        private void btnMyAccountForm_Click(object sender, EventArgs e)
        {
            string id = account.EmployeeID.ToString();
            ConnectEmployee connectEmployee = new ConnectEmployee();
            MyAccount temp = new MyAccount();
            temp = connectEmployee.getDataMyAccountbyID(int.Parse(id));

            Forms.MyAccountForm form = new Forms.MyAccountForm(temp);
            //form.role = this.account;
            OpenChildForm(form, sender);
        }

        private void button_ManageCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCustomer(), sender);
        }

        private void btnSettingForm_Click_1(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.SettingForm(), sender);
        }

    }
}
