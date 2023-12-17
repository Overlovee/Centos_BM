namespace CentosBM.Forms
{
    partial class MyAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbtext_ID = new System.Windows.Forms.Label();
            this.lbtext_FirstName = new System.Windows.Forms.Label();
            this.lbtext_Address = new System.Windows.Forms.Label();
            this.lbtext_Phone = new System.Windows.Forms.Label();
            this.lbtext_UserName = new System.Windows.Forms.Label();
            this.lbtext_Position = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserName :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Position :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbtext_ID
            // 
            this.lbtext_ID.AutoSize = true;
            this.lbtext_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext_ID.Location = new System.Drawing.Point(228, 89);
            this.lbtext_ID.Name = "lbtext_ID";
            this.lbtext_ID.Size = new System.Drawing.Size(25, 22);
            this.lbtext_ID.TabIndex = 7;
            this.lbtext_ID.Text = "...";
            // 
            // lbtext_FirstName
            // 
            this.lbtext_FirstName.AutoSize = true;
            this.lbtext_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext_FirstName.Location = new System.Drawing.Point(303, 142);
            this.lbtext_FirstName.Name = "lbtext_FirstName";
            this.lbtext_FirstName.Size = new System.Drawing.Size(25, 22);
            this.lbtext_FirstName.TabIndex = 8;
            this.lbtext_FirstName.Text = "...";
            // 
            // lbtext_Address
            // 
            this.lbtext_Address.AutoSize = true;
            this.lbtext_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext_Address.Location = new System.Drawing.Point(282, 259);
            this.lbtext_Address.Name = "lbtext_Address";
            this.lbtext_Address.Size = new System.Drawing.Size(25, 22);
            this.lbtext_Address.TabIndex = 10;
            this.lbtext_Address.Text = "...";
            // 
            // lbtext_Phone
            // 
            this.lbtext_Phone.AutoSize = true;
            this.lbtext_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext_Phone.Location = new System.Drawing.Point(586, 86);
            this.lbtext_Phone.Name = "lbtext_Phone";
            this.lbtext_Phone.Size = new System.Drawing.Size(25, 22);
            this.lbtext_Phone.TabIndex = 11;
            this.lbtext_Phone.Text = "...";
            // 
            // lbtext_UserName
            // 
            this.lbtext_UserName.AutoSize = true;
            this.lbtext_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext_UserName.Location = new System.Drawing.Point(303, 200);
            this.lbtext_UserName.Name = "lbtext_UserName";
            this.lbtext_UserName.Size = new System.Drawing.Size(25, 22);
            this.lbtext_UserName.TabIndex = 12;
            this.lbtext_UserName.Text = "...";
            // 
            // lbtext_Position
            // 
            this.lbtext_Position.AutoSize = true;
            this.lbtext_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext_Position.Location = new System.Drawing.Point(598, 142);
            this.lbtext_Position.Name = "lbtext_Position";
            this.lbtext_Position.Size = new System.Drawing.Size(25, 22);
            this.lbtext_Position.TabIndex = 13;
            this.lbtext_Position.Text = "...";
            this.lbtext_Position.Click += new System.EventHandler(this.lbtext_Position_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Logout.Location = new System.Drawing.Point(328, 317);
            this.button_Logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(158, 40);
            this.button_Logout.TabIndex = 15;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // MyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 399);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.lbtext_Position);
            this.Controls.Add(this.lbtext_UserName);
            this.Controls.Add(this.lbtext_Phone);
            this.Controls.Add(this.lbtext_Address);
            this.Controls.Add(this.lbtext_FirstName);
            this.Controls.Add(this.lbtext_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyAccountForm";
            this.Text = "MyAccountForm";
            this.Load += new System.EventHandler(this.MyAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbtext_ID;
        private System.Windows.Forms.Label lbtext_FirstName;
        private System.Windows.Forms.Label lbtext_Address;
        private System.Windows.Forms.Label lbtext_Phone;
        private System.Windows.Forms.Label lbtext_UserName;
        private System.Windows.Forms.Label lbtext_Position;
        private System.Windows.Forms.Button button_Logout;
    }
}