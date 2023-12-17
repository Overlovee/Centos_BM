
namespace CentosBM.Forms
{
    partial class FormAddCategory
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NameCategory = new System.Windows.Forms.TextBox();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txt_NameCategory);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(115, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 143);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category Name:";
            // 
            // txt_NameCategory
            // 
            this.txt_NameCategory.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameCategory.Location = new System.Drawing.Point(217, 55);
            this.txt_NameCategory.Name = "txt_NameCategory";
            this.txt_NameCategory.Size = new System.Drawing.Size(261, 40);
            this.txt_NameCategory.TabIndex = 1;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewCategory.FlatAppearance.BorderSize = 0;
            this.btnAddNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewCategory.Location = new System.Drawing.Point(125, 241);
            this.btnAddNewCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(490, 88);
            this.btnAddNewCategory.TabIndex = 9;
            this.btnAddNewCategory.Text = "Add new";
            this.btnAddNewCategory.UseVisualStyleBackColor = false;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.panel4);
            this.Name = "FormAddCategory";
            this.Text = "FormAddCategory";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NameCategory;
        private System.Windows.Forms.Button btnAddNewCategory;
    }
}