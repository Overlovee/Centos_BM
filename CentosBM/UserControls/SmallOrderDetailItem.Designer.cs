namespace CentosBM.UserControls
{
    partial class SmallOrderDetailItem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxProduct, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(135, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(135, 150);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProduct.Image = global::CentosBM.Properties.Resources.OngnhuauPVCnongtron_160x4_0m;
            this.pictureBoxProduct.Location = new System.Drawing.Point(11, 12);
            this.pictureBoxProduct.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(113, 126);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 1;
            this.pictureBoxProduct.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(555, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 148);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.08504F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.91496F));
            this.tableLayoutPanel3.Controls.Add(this.labelQuantity, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTotal, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(384, 148);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelQuantity.Location = new System.Drawing.Point(3, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.labelQuantity.Size = new System.Drawing.Size(113, 148);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "x 20";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTotal.Location = new System.Drawing.Point(122, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.labelTotal.Size = new System.Drawing.Size(259, 148);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "1000320 VND";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelPrice, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelCategoryName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelSupplierName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(135, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(420, 148);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Tomato;
            this.labelPrice.Location = new System.Drawing.Point(11, 105);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelPrice.Size = new System.Drawing.Size(398, 31);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "123750.00/Cái";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategoryName.ForeColor = System.Drawing.Color.Black;
            this.labelCategoryName.Location = new System.Drawing.Point(11, 74);
            this.labelCategoryName.Margin = new System.Windows.Forms.Padding(0);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelCategoryName.Size = new System.Drawing.Size(398, 31);
            this.labelCategoryName.TabIndex = 2;
            this.labelCategoryName.Text = "Tôn Hoa Sen";
            this.labelCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSupplierName.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierName.Location = new System.Drawing.Point(11, 43);
            this.labelSupplierName.Margin = new System.Windows.Forms.Padding(0);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelSupplierName.Size = new System.Drawing.Size(398, 31);
            this.labelSupplierName.TabIndex = 1;
            this.labelSupplierName.Text = "Công Ty TNHH Thương Mại Green Tech";
            this.labelSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(11, 12);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(398, 31);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tôn lạnh màu đỏ MRL03 0.45mm";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SmallOrderDetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SmallOrderDetailItem";
            this.Size = new System.Drawing.Size(939, 148);
            this.Load += new System.EventHandler(this.SmallOrderDetailItem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelQuantity;
    }
}
