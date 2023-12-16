namespace CentosBM.UserControls
{
    partial class OrderProductItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProduct.Image = global::CentosBM.Properties.Resources.categories;
            this.pictureBoxProduct.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxProduct.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(44, 50);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBoxProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(56, 62);
            this.panel1.MinimumSize = new System.Drawing.Size(56, 62);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(56, 62);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(234, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 68);
            this.label1.TabIndex = 8;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Controls.Add(this.labelTotal, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Price, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_ProductName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(606, 68);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(353, 0);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(111, 68);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Price.ForeColor = System.Drawing.Color.Black;
            this.label_Price.Location = new System.Drawing.Point(117, 0);
            this.label_Price.Margin = new System.Windows.Forms.Padding(0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(117, 68);
            this.label_Price.TabIndex = 15;
            this.label_Price.Text = "Price";
            this.label_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_ProductName.ForeColor = System.Drawing.Color.Black;
            this.label_ProductName.Location = new System.Drawing.Point(0, 0);
            this.label_ProductName.Margin = new System.Windows.Forms.Padding(0);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(117, 68);
            this.label_ProductName.TabIndex = 14;
            this.label_ProductName.Text = "Product Name";
            this.label_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_Quantity);
            this.panel2.Location = new System.Drawing.Point(254, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 68);
            this.panel2.TabIndex = 17;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Quantity.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Quantity.Location = new System.Drawing.Point(0, 16);
            this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Quantity.Multiline = true;
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(99, 23);
            this.textBox_Quantity.TabIndex = 13;
            this.textBox_Quantity.TextChanged += new System.EventHandler(this.textBox_Quantity_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(467, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 62);
            this.panel3.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(18, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "OrderProductItem";
            this.Size = new System.Drawing.Size(662, 68);
            this.Load += new System.EventHandler(this.OrderProductItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}
