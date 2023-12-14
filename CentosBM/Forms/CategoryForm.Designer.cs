namespace CentosBM.Forms
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLanguagesLoad = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6_display = new System.Windows.Forms.Label();
            this.btnAddNewLanguage_display = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.categoriesItems1 = new CentosBM.UserControls.CategoriesItems();
            this.panelLanguagesLoad.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLanguagesLoad
            // 
            this.panelLanguagesLoad.AutoScroll = true;
            this.panelLanguagesLoad.Controls.Add(this.categoriesItems1);
            this.panelLanguagesLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLanguagesLoad.Location = new System.Drawing.Point(0, 61);
            this.panelLanguagesLoad.Margin = new System.Windows.Forms.Padding(0);
            this.panelLanguagesLoad.Name = "panelLanguagesLoad";
            this.panelLanguagesLoad.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panelLanguagesLoad.Size = new System.Drawing.Size(1169, 527);
            this.panelLanguagesLoad.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panelLanguagesLoad);
            this.panel12.Controls.Add(this.tableLayoutPanel1);
            this.panel12.Location = new System.Drawing.Point(32, 126);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1171, 590);
            this.panel12.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkViolet;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6_display, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1169, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6_display
            // 
            this.label6_display.AutoSize = true;
            this.label6_display.BackColor = System.Drawing.Color.Black;
            this.label6_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_display.ForeColor = System.Drawing.Color.White;
            this.label6_display.Location = new System.Drawing.Point(0, 0);
            this.label6_display.Margin = new System.Windows.Forms.Padding(0);
            this.label6_display.Name = "label6_display";
            this.label6_display.Size = new System.Drawing.Size(1169, 61);
            this.label6_display.TabIndex = 0;
            this.label6_display.Text = "Categories";
            this.label6_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewLanguage_display
            // 
            this.btnAddNewLanguage_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLanguage_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewLanguage_display.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewLanguage_display.Location = new System.Drawing.Point(33, 27);
            this.btnAddNewLanguage_display.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewLanguage_display.Name = "btnAddNewLanguage_display";
            this.btnAddNewLanguage_display.Size = new System.Drawing.Size(152, 45);
            this.btnAddNewLanguage_display.TabIndex = 1;
            this.btnAddNewLanguage_display.Text = "Add new";
            this.btnAddNewLanguage_display.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAddNewLanguage_display);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1229, 743);
            this.panel7.TabIndex = 8;
            // 
            // categoriesItems1
            // 
            this.categoriesItems1.Location = new System.Drawing.Point(3, 3);
            this.categoriesItems1.Name = "categoriesItems1";
            this.categoriesItems1.Size = new System.Drawing.Size(1166, 102);
            this.categoriesItems1.TabIndex = 0;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 743);
            this.Controls.Add(this.panel7);
            this.Name = "CategoryForm";
            this.Text = "Category";
            this.panelLanguagesLoad.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLanguagesLoad;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6_display;
        private System.Windows.Forms.Button btnAddNewLanguage_display;
        private System.Windows.Forms.Panel panel7;
        private UserControls.CategoriesItems categoriesItems1;
    }
}