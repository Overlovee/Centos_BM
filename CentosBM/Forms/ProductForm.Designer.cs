namespace CentosBM.Forms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUserAccountsLoad = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch_display = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelMessageLoad = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.tableLayoutPanel2);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1148, 614);
            this.panel7.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelUserAccountsLoad);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 509);
            this.panel1.TabIndex = 2;
            // 
            // panelUserAccountsLoad
            // 
            this.panelUserAccountsLoad.AutoScroll = true;
            this.panelUserAccountsLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserAccountsLoad.Location = new System.Drawing.Point(0, 0);
            this.panelUserAccountsLoad.Margin = new System.Windows.Forms.Padding(0);
            this.panelUserAccountsLoad.Name = "panelUserAccountsLoad";
            this.panelUserAccountsLoad.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panelUserAccountsLoad.Size = new System.Drawing.Size(339, 507);
            this.panelUserAccountsLoad.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearch_display, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearch, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 35);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSearch_display
            // 
            this.btnSearch_display.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch_display.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch_display.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSearch_display.FlatAppearance.BorderSize = 0;
            this.btnSearch_display.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearch_display.ForeColor = System.Drawing.Color.White;
            this.btnSearch_display.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_display.Image")));
            this.btnSearch_display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_display.Location = new System.Drawing.Point(215, 0);
            this.btnSearch_display.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSearch_display.Name = "btnSearch_display";
            this.btnSearch_display.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSearch_display.Size = new System.Drawing.Size(126, 35);
            this.btnSearch_display.TabIndex = 4;
            this.btnSearch_display.Text = "Search";
            this.btnSearch_display.UseVisualStyleBackColor = false;
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
            this.btnClear.Location = new System.Drawing.Point(176, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = false;
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
            this.textBoxSearch.Size = new System.Drawing.Size(172, 35);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panelMessageLoad);
            this.panel12.Controls.Add(this.tableLayoutPanel1);
            this.panel12.Location = new System.Drawing.Point(359, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(766, 585);
            this.panel12.TabIndex = 0;
            // 
            // panelMessageLoad
            // 
            this.panelMessageLoad.AutoScroll = true;
            this.panelMessageLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMessageLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessageLoad.Location = new System.Drawing.Point(0, 35);
            this.panelMessageLoad.Margin = new System.Windows.Forms.Padding(0);
            this.panelMessageLoad.Name = "panelMessageLoad";
            this.panelMessageLoad.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panelMessageLoad.Size = new System.Drawing.Size(764, 548);
            this.panelMessageLoad.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelUserName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserName.Font = new System.Drawing.Font("Montserrat Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Black;
            this.labelUserName.Location = new System.Drawing.Point(3, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(758, 35);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "To All";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 614);
            this.Controls.Add(this.panel7);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUserAccountsLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch_display;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelMessageLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUserName;
    }
}