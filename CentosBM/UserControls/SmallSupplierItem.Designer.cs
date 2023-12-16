namespace CentosBM.UserControls
{
    partial class SmallSupplierItem
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
            this.labelPhone = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.labelSupplierID = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSupplierID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSupplierName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 58);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.Black;
            this.labelPhone.Location = new System.Drawing.Point(418, 0);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelPhone.Size = new System.Drawing.Size(160, 58);
            this.labelPhone.TabIndex = 48;
            this.labelPhone.Text = "012312743";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPhone.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.Black;
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(588, 10);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(10);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(100, 38);
            this.btnDetail.TabIndex = 47;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // labelSupplierID
            // 
            this.labelSupplierID.AutoSize = true;
            this.labelSupplierID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierID.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierID.Location = new System.Drawing.Point(0, 0);
            this.labelSupplierID.Margin = new System.Windows.Forms.Padding(0);
            this.labelSupplierID.Name = "labelSupplierID";
            this.labelSupplierID.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelSupplierID.Size = new System.Drawing.Size(80, 58);
            this.labelSupplierID.TabIndex = 45;
            this.labelSupplierID.Text = "1";
            this.labelSupplierID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSupplierID.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierName.Location = new System.Drawing.Point(80, 0);
            this.labelSupplierName.Margin = new System.Windows.Forms.Padding(0);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelSupplierName.Size = new System.Drawing.Size(338, 58);
            this.labelSupplierName.TabIndex = 42;
            this.labelSupplierName.Text = "Công Ty TNHH Thương Mại Green Tech";
            this.labelSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSupplierName.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // SmallSupplierItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(700, 60);
            this.Name = "SmallSupplierItem";
            this.Size = new System.Drawing.Size(698, 58);
            this.Load += new System.EventHandler(this.SmallSupplierItem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label labelSupplierID;
        private System.Windows.Forms.Label labelSupplierName;
    }
}
