namespace CentosBM.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label9 = new System.Windows.Forms.Label();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.panel_ListProductInOrder = new System.Windows.Forms.Panel();
            this.comboBoxCategoryType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.panel_Total = new System.Windows.Forms.Panel();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.Label_Total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(0, -70);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(457, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total Income and Expenses this month";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelProducts
            // 
            this.panelProducts.AutoScroll = true;
            this.panelProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProducts.Location = new System.Drawing.Point(0, 46);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(327, 628);
            this.panelProducts.TabIndex = 14;
            this.panelProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProducts_Paint);
            // 
            // panel_ListProductInOrder
            // 
            this.panel_ListProductInOrder.AutoScroll = true;
            this.panel_ListProductInOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ListProductInOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ListProductInOrder.Location = new System.Drawing.Point(327, 46);
            this.panel_ListProductInOrder.Name = "panel_ListProductInOrder";
            this.panel_ListProductInOrder.Size = new System.Drawing.Size(986, 544);
            this.panel_ListProductInOrder.TabIndex = 15;
            this.panel_ListProductInOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ListProductInOrder_Paint);
            // 
            // comboBoxCategoryType
            // 
            this.comboBoxCategoryType.DropDownHeight = 200;
            this.comboBoxCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoryType.FormattingEnabled = true;
            this.comboBoxCategoryType.IntegralHeight = false;
            this.comboBoxCategoryType.Items.AddRange(new object[] {
            "Gach",
            "da"});
            this.comboBoxCategoryType.Location = new System.Drawing.Point(9, 9);
            this.comboBoxCategoryType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCategoryType.Name = "comboBoxCategoryType";
            this.comboBoxCategoryType.Size = new System.Drawing.Size(318, 33);
            this.comboBoxCategoryType.TabIndex = 1;
            this.comboBoxCategoryType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.comboBoxCategoryType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 46);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearch, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(368, 9);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(923, 30);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(884, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Lavender;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(845, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(841, 30);
            this.textBoxSearch.TabIndex = 0;
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Submit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Submit.FlatAppearance.BorderSize = 0;
            this.button_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Submit.Location = new System.Drawing.Point(327, 622);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(986, 52);
            this.button_Submit.TabIndex = 15;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click_1);
            // 
            // panel_Total
            // 
            this.panel_Total.Controls.Add(this.textBox_total);
            this.panel_Total.Controls.Add(this.Label_Total);
            this.panel_Total.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Total.Location = new System.Drawing.Point(327, 590);
            this.panel_Total.Name = "panel_Total";
            this.panel_Total.Size = new System.Drawing.Size(986, 32);
            this.panel_Total.TabIndex = 16;
            // 
            // textBox_total
            // 
            this.textBox_total.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_total.Location = new System.Drawing.Point(753, 0);
            this.textBox_total.Multiline = true;
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(233, 32);
            this.textBox_total.TabIndex = 1;
            // 
            // Label_Total
            // 
            this.Label_Total.AutoSize = true;
            this.Label_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Total.Location = new System.Drawing.Point(0, 0);
            this.Label_Total.Name = "Label_Total";
            this.Label_Total.Size = new System.Drawing.Size(71, 26);
            this.Label_Total.TabIndex = 0;
            this.Label_Total.Text = "Total: ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 674);
            this.Controls.Add(this.panel_ListProductInOrder);
            this.Controls.Add(this.panel_Total);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_Total.ResumeLayout(false);
            this.panel_Total.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panel_ListProductInOrder;
        private System.Windows.Forms.ComboBox comboBoxCategoryType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Panel panel_Total;
        private System.Windows.Forms.Label Label_Total;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}