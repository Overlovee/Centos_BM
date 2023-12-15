using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentosBM.Forms;
using CentosBM.Models;

namespace CentosBM
{
    public partial class Menu : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Menu()
        {
            InitializeComponent();
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new ChildForms.Settings(), sender);
        }

        private void btnPaybook_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new ChildForms.Paybook(), sender);
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new ChildForms.Overview(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new ChildForms.Home(), sender);

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CategoryForm(), sender);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            
        }

        private void EmptyClickHandler(object sender, EventArgs e)
        {
            
        }
        private void AssignPermissions(string role)
        {
            //if (role == "Admin")
            //{
            //    labelIcon.Click += EmptyClickHandler;
            //    btnHome_display.Hide();
            //    btnOverview_display.Hide();
            //    btnTransaction_display.Hide();
            //    OpenChildForm(new ChildForms.Category(), btnCategory_display);
            //}
            //else
            //{
            //    btnAdminAccount_display.Hide();
            //    btnCategory_display.Hide();
            //    btnUserAccount_display.Hide();
            //    btnLanguages_display.Hide();
            //    btnCurrencies_display.Hide();
            //    goToHome();
            //}
        }
        public void Load_Form()
        {
            //Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            //user = connectUsers.getUserDataByID(user.Id);
            //this.Tag = user.Id.ToString();
            //dictionary = new Languages.LanguageDictionary(user.UserSettings.LanguageCode);
            //dictionary.SetLanguages((Control)this);
            //AssignPermissions(user.Role);
            this.Show();
        }
        public void Reload_Form()
        {
            btnHome_display.Text = "home";
            btnOverview_display.Text = "overview";
            btnCategory_display.Text = "category";
            btnOrderForm.Text = "account";
            btnShowProductForm.Text = "users";
            btnAdminAccount_display.Text = "admins";
            btnLanguages_display.Text = "manage_languages";
            btnSettings_display.Text = "settings";

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
            btnHome_display.BackColor = Color.Gray;
            btnHome_display.ForeColor = Color.White;
            btnHome_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private void btnAdminAccount_Click(object sender, EventArgs e)
        {
            
        }


        private void btnLanguages_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMessage_display_Click(object sender, EventArgs e)
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
    }

}
