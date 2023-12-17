
namespace CentosBM.UserControls
{
    partial class CategoriesItems
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
            this.btnEditing = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.labelCategoriesName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditing, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCategoriesName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 52);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnEditing
            // 
            this.btnEditing.BackColor = System.Drawing.Color.Black;
            this.btnEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEditing.FlatAppearance.BorderSize = 0;
            this.btnEditing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditing.ForeColor = System.Drawing.Color.White;
            this.btnEditing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditing.Location = new System.Drawing.Point(305, 8);
            this.btnEditing.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(87, 36);
            this.btnEditing.TabIndex = 34;
            this.btnEditing.Text = "Edit";
            this.btnEditing.UseVisualStyleBackColor = false;
            this.btnEditing.Click += new System.EventHandler(this.btnEditing_Click_1);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.DeepPink;
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(206, 8);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(85, 36);
            this.btnDetail.TabIndex = 33;
            this.btnDetail.Text = "Details";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDeleting_Click);
            // 
            // labelCategoriesName
            // 
            this.labelCategoriesName.AutoSize = true;
            this.labelCategoriesName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCategoriesName.ForeColor = System.Drawing.Color.Black;
            this.labelCategoriesName.Location = new System.Drawing.Point(0, 0);
            this.labelCategoriesName.Margin = new System.Windows.Forms.Padding(0);
            this.labelCategoriesName.Name = "labelCategoriesName";
            this.labelCategoriesName.Size = new System.Drawing.Size(199, 52);
            this.labelCategoriesName.TabIndex = 31;
            this.labelCategoriesName.Text = "Gạch";
            this.labelCategoriesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoriesItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CategoriesItems";
            this.Size = new System.Drawing.Size(407, 58);
            this.Load += new System.EventHandler(this.CategoriesItems_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label labelCategoriesName;
    }
}
