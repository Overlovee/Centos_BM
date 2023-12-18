namespace CentosBM.Forms
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.label_Orderdate = new System.Windows.Forms.Label();
            this.button_Addnewcustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_PrintInvoice = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBox_OrderStatus = new System.Windows.Forms.ComboBox();
            this.label7_display = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label3_display = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2_display = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label1_display = new System.Windows.Forms.Label();
            this.panel_Listproduct = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.button_Addnewcustomer);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button_PrintInvoice);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btn_CheckOut);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 577);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.dateTimePickerOrder);
            this.panel9.Controls.Add(this.label_Orderdate);
            this.panel9.Location = new System.Drawing.Point(637, 11);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(496, 51);
            this.panel9.TabIndex = 15;
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerOrder.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePickerOrder.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrder.Location = new System.Drawing.Point(198, 7);
            this.dateTimePickerOrder.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerOrder.MaxDate = new System.DateTime(2029, 3, 8, 0, 0, 0, 0);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(298, 32);
            this.dateTimePickerOrder.TabIndex = 2;
            this.dateTimePickerOrder.Value = new System.DateTime(2023, 10, 30, 0, 0, 0, 0);
            // 
            // label_Orderdate
            // 
            this.label_Orderdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Orderdate.AutoSize = true;
            this.label_Orderdate.ForeColor = System.Drawing.Color.Black;
            this.label_Orderdate.Location = new System.Drawing.Point(3, 12);
            this.label_Orderdate.Name = "label_Orderdate";
            this.label_Orderdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Orderdate.Size = new System.Drawing.Size(109, 26);
            this.label_Orderdate.TabIndex = 0;
            this.label_Orderdate.Text = "Orderdate";
            // 
            // button_Addnewcustomer
            // 
            this.button_Addnewcustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Addnewcustomer.FlatAppearance.BorderSize = 0;
            this.button_Addnewcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Addnewcustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Addnewcustomer.Location = new System.Drawing.Point(30, 11);
            this.button_Addnewcustomer.Margin = new System.Windows.Forms.Padding(2);
            this.button_Addnewcustomer.Name = "button_Addnewcustomer";
            this.button_Addnewcustomer.Size = new System.Drawing.Size(221, 51);
            this.button_Addnewcustomer.TabIndex = 14;
            this.button_Addnewcustomer.Text = "Add new customer";
            this.button_Addnewcustomer.UseVisualStyleBackColor = false;
            this.button_Addnewcustomer.Click += new System.EventHandler(this.button_Addnewcustomer_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 78);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 44);
            this.tableLayoutPanel2.TabIndex = 13;
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
            this.btnSearch.Location = new System.Drawing.Point(1064, 0);
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
            this.btnClear.Location = new System.Drawing.Point(1025, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 44);
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
            this.textBoxSearch.Size = new System.Drawing.Size(1021, 44);
            this.textBoxSearch.TabIndex = 0;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Cancel.Location = new System.Drawing.Point(643, 468);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(490, 88);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.textBox_Total);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(643, 144);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 87);
            this.panel5.TabIndex = 10;
            // 
            // textBox_Total
            // 
            this.textBox_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Total.ForeColor = System.Drawing.Color.Black;
            this.textBox_Total.Location = new System.Drawing.Point(177, 23);
            this.textBox_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(294, 32);
            this.textBox_Total.TabIndex = 4;
            this.textBox_Total.TextChanged += new System.EventHandler(this.textBox_Total_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total :";
            // 
            // button_PrintInvoice
            // 
            this.button_PrintInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PrintInvoice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_PrintInvoice.FlatAppearance.BorderSize = 0;
            this.button_PrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PrintInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_PrintInvoice.Location = new System.Drawing.Point(643, 356);
            this.button_PrintInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.button_PrintInvoice.Name = "button_PrintInvoice";
            this.button_PrintInvoice.Size = new System.Drawing.Size(490, 88);
            this.button_PrintInvoice.TabIndex = 11;
            this.button_PrintInvoice.Text = "Print an invoice";
            this.button_PrintInvoice.UseVisualStyleBackColor = false;
            this.button_PrintInvoice.Click += new System.EventHandler(this.button_PrintInvoice_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.comboBox_OrderStatus);
            this.panel8.Controls.Add(this.label7_display);
            this.panel8.Location = new System.Drawing.Point(30, 468);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(589, 87);
            this.panel8.TabIndex = 9;
            // 
            // comboBox_OrderStatus
            // 
            this.comboBox_OrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_OrderStatus.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_OrderStatus.FormattingEnabled = true;
            this.comboBox_OrderStatus.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.comboBox_OrderStatus.Location = new System.Drawing.Point(177, 21);
            this.comboBox_OrderStatus.Name = "comboBox_OrderStatus";
            this.comboBox_OrderStatus.Size = new System.Drawing.Size(391, 34);
            this.comboBox_OrderStatus.TabIndex = 1;
            // 
            // label7_display
            // 
            this.label7_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7_display.AutoSize = true;
            this.label7_display.ForeColor = System.Drawing.Color.Black;
            this.label7_display.Location = new System.Drawing.Point(3, 29);
            this.label7_display.Name = "label7_display";
            this.label7_display.Size = new System.Drawing.Size(125, 26);
            this.label7_display.TabIndex = 0;
            this.label7_display.Text = "Orderstatus";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CheckOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CheckOut.FlatAppearance.BorderSize = 0;
            this.btn_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CheckOut.Location = new System.Drawing.Point(643, 247);
            this.btn_CheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(490, 88);
            this.btn_CheckOut.TabIndex = 8;
            this.btn_CheckOut.Text = "Check out";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxPhone);
            this.panel4.Controls.Add(this.label3_display);
            this.panel4.Location = new System.Drawing.Point(30, 356);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 87);
            this.panel4.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPhone.ForeColor = System.Drawing.Color.Black;
            this.textBoxPhone.Location = new System.Drawing.Point(177, 26);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(391, 32);
            this.textBoxPhone.TabIndex = 4;
            // 
            // label3_display
            // 
            this.label3_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3_display.AutoSize = true;
            this.label3_display.ForeColor = System.Drawing.Color.Black;
            this.label3_display.Location = new System.Drawing.Point(3, 29);
            this.label3_display.Name = "label3_display";
            this.label3_display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3_display.Size = new System.Drawing.Size(75, 26);
            this.label3_display.TabIndex = 0;
            this.label3_display.Text = "Phone";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxAddress);
            this.panel3.Controls.Add(this.label2_display);
            this.panel3.Location = new System.Drawing.Point(30, 248);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 87);
            this.panel3.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddress.Location = new System.Drawing.Point(177, 25);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(391, 32);
            this.textBoxAddress.TabIndex = 3;
            // 
            // label2_display
            // 
            this.label2_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2_display.AutoSize = true;
            this.label2_display.ForeColor = System.Drawing.Color.Black;
            this.label2_display.Location = new System.Drawing.Point(3, 28);
            this.label2_display.Name = "label2_display";
            this.label2_display.Size = new System.Drawing.Size(92, 26);
            this.label2_display.TabIndex = 0;
            this.label2_display.Text = "Address";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxFullName);
            this.panel2.Controls.Add(this.label1_display);
            this.panel2.Location = new System.Drawing.Point(30, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 87);
            this.panel2.TabIndex = 0;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFullName.ForeColor = System.Drawing.Color.Black;
            this.textBoxFullName.Location = new System.Drawing.Point(177, 24);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(391, 32);
            this.textBoxFullName.TabIndex = 1;
            // 
            // label1_display
            // 
            this.label1_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_display.AutoSize = true;
            this.label1_display.ForeColor = System.Drawing.Color.Black;
            this.label1_display.Location = new System.Drawing.Point(3, 29);
            this.label1_display.Name = "label1_display";
            this.label1_display.Size = new System.Drawing.Size(112, 26);
            this.label1_display.TabIndex = 0;
            this.label1_display.Text = "Full Name";
            // 
            // panel_Listproduct
            // 
            this.panel_Listproduct.AutoScroll = true;
            this.panel_Listproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Listproduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Listproduct.Location = new System.Drawing.Point(0, 625);
            this.panel_Listproduct.Name = "panel_Listproduct";
            this.panel_Listproduct.Size = new System.Drawing.Size(1162, 229);
            this.panel_Listproduct.TabIndex = 2;
            this.panel_Listproduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Listproduct_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 577);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 48);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1152, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "List product";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1188, 806);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel_Listproduct);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrder";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7_display;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3_display;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2_display;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label1_display;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_PrintInvoice;
        private System.Windows.Forms.Panel panel_Listproduct;
        private System.Windows.Forms.ComboBox comboBox_OrderStatus;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label_Orderdate;
        private System.Windows.Forms.Button button_Addnewcustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}