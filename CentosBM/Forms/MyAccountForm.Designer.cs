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
            this.button_Logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbtext_empStatus = new System.Windows.Forms.Label();
            this.lbtext_Position = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_LBID = new System.Windows.Forms.Label();
            this.LB_EmloyeeID = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Logout.Location = new System.Drawing.Point(368, 317);
            this.button_Logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(158, 40);
            this.button_Logout.TabIndex = 15;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbtext_empStatus);
            this.panel2.Controls.Add(this.lbtext_Position);
            this.panel2.Controls.Add(this.button_Logout);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_LBID);
            this.panel2.Controls.Add(this.LB_EmloyeeID);
            this.panel2.Controls.Add(this.txt_Phone);
            this.panel2.Controls.Add(this.txt_Address);
            this.panel2.Controls.Add(this.txt_UserName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button_Update);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_FullName);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 396);
            this.panel2.TabIndex = 16;
            // 
            // lbtext_empStatus
            // 
            this.lbtext_empStatus.AutoSize = true;
            this.lbtext_empStatus.Location = new System.Drawing.Point(477, 162);
            this.lbtext_empStatus.Name = "lbtext_empStatus";
            this.lbtext_empStatus.Size = new System.Drawing.Size(16, 16);
            this.lbtext_empStatus.TabIndex = 29;
            this.lbtext_empStatus.Text = "...";
            // 
            // lbtext_Position
            // 
            this.lbtext_Position.AutoSize = true;
            this.lbtext_Position.Location = new System.Drawing.Point(477, 23);
            this.lbtext_Position.Name = "lbtext_Position";
            this.lbtext_Position.Size = new System.Drawing.Size(16, 16);
            this.lbtext_Position.TabIndex = 28;
            this.lbtext_Position.Text = "...";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(381, 218);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 16);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ChangePassword";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(372, 163);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "EmpStatus";
            // 
            // txt_LBID
            // 
            this.txt_LBID.AutoSize = true;
            this.txt_LBID.Location = new System.Drawing.Point(114, 27);
            this.txt_LBID.Name = "txt_LBID";
            this.txt_LBID.Size = new System.Drawing.Size(16, 16);
            this.txt_LBID.TabIndex = 24;
            this.txt_LBID.Text = "...";
            // 
            // LB_EmloyeeID
            // 
            this.LB_EmloyeeID.AutoSize = true;
            this.LB_EmloyeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EmloyeeID.Location = new System.Drawing.Point(45, 27);
            this.LB_EmloyeeID.Name = "LB_EmloyeeID";
            this.LB_EmloyeeID.Size = new System.Drawing.Size(47, 25);
            this.LB_EmloyeeID.TabIndex = 22;
            this.LB_EmloyeeID.Text = "ID : ";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_Phone.Location = new System.Drawing.Point(467, 81);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Phone.Multiline = true;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(239, 32);
            this.txt_Phone.TabIndex = 21;
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_FullName_TextChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_Address.Location = new System.Drawing.Point(117, 218);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(239, 32);
            this.txt_Address.TabIndex = 19;
            this.txt_Address.TextChanged += new System.EventHandler(this.txt_FullName_TextChanged);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_UserName.Location = new System.Drawing.Point(117, 151);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(239, 32);
            this.txt_UserName.TabIndex = 17;
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_FullName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(21, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(394, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Position";
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Update.Location = new System.Drawing.Point(172, 317);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(148, 40);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(394, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(21, 230);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Address";
            // 
            // txt_FullName
            // 
            this.txt_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.txt_FullName.Location = new System.Drawing.Point(117, 81);
            this.txt_FullName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_FullName.Multiline = true;
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(239, 32);
            this.txt_FullName.TabIndex = 5;
            this.txt_FullName.TextChanged += new System.EventHandler(this.txt_FullName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(21, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "FullName";
            // 
            // MyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 432);
            this.Controls.Add(this.panel2);
            this.Name = "MyAccountForm";
            this.Text = "MyAccountForm";
            this.Load += new System.EventHandler(this.MyAccountForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_LBID;
        private System.Windows.Forms.Label LB_EmloyeeID;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbtext_empStatus;
        private System.Windows.Forms.Label lbtext_Position;
    }
}