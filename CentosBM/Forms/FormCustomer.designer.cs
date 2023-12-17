namespace CentosBM.Forms
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxSearch1 = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelCustomerLoad = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6_display = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel2);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1160, 595);
            this.panel7.TabIndex = 9;
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
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearch1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 28);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1101, 44);
            this.tableLayoutPanel2.TabIndex = 3;
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
            this.btnSearch.Location = new System.Drawing.Point(1062, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 44);
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
            this.btnClear.Location = new System.Drawing.Point(1023, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 44);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxSearch1
            // 
            this.textBoxSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearch1.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.textBoxSearch1.Multiline = true;
            this.textBoxSearch1.Name = "textBoxSearch1";
            this.textBoxSearch1.Size = new System.Drawing.Size(1019, 44);
            this.textBoxSearch1.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panelCustomerLoad);
            this.panel12.Controls.Add(this.tableLayoutPanel1);
            this.panel12.Location = new System.Drawing.Point(32, 126);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1102, 442);
            this.panel12.TabIndex = 0;
            // 
            // panelCustomerLoad
            // 
            this.panelCustomerLoad.AutoScroll = true;
            this.panelCustomerLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomerLoad.Location = new System.Drawing.Point(0, 61);
            this.panelCustomerLoad.Margin = new System.Windows.Forms.Padding(0);
            this.panelCustomerLoad.Name = "panelCustomerLoad";
            this.panelCustomerLoad.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panelCustomerLoad.Size = new System.Drawing.Size(1100, 379);
            this.panelCustomerLoad.TabIndex = 1;
            this.panelCustomerLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomerLoad_Paint);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 61);
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
            this.label6_display.Size = new System.Drawing.Size(1100, 61);
            this.label6_display.TabIndex = 0;
            this.label6_display.Text = "Customer";
            this.label6_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 595);
            this.Controls.Add(this.panel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelCustomerLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6_display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxSearch1;
    }
}