namespace CentosBM.Forms
{
    partial class Overview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerOverview = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart_Revenue_Product = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxCategoryType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Total_Revenue_category = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Revenue = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label8_display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue_Product)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.83761F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.16239F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerOverview, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1170, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePickerOverview
            // 
            this.dateTimePickerOverview.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePickerOverview.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerOverview.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOverview.Location = new System.Drawing.Point(899, 0);
            this.dateTimePickerOverview.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerOverview.MaxDate = new System.DateTime(2055, 7, 22, 0, 0, 0, 0);
            this.dateTimePickerOverview.Name = "dateTimePickerOverview";
            this.dateTimePickerOverview.Size = new System.Drawing.Size(271, 32);
            this.dateTimePickerOverview.TabIndex = 2;
            this.dateTimePickerOverview.Value = new System.DateTime(2023, 9, 30, 0, 0, 0, 0);
            this.dateTimePickerOverview.ValueChanged += new System.EventHandler(this.dateTimePickerOverview_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.chart_Revenue_Product);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.chart_Revenue);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 643);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chart_Revenue_Product
            // 
            this.chart_Revenue_Product.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart_Revenue_Product.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.chart_Revenue_Product.ChartAreas.Add(chartArea1);
            this.chart_Revenue_Product.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart_Revenue_Product.Legends.Add(legend1);
            this.chart_Revenue_Product.Location = new System.Drawing.Point(0, 445);
            this.chart_Revenue_Product.Name = "chart_Revenue_Product";
            this.chart_Revenue_Product.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Revenue_Product";
            this.chart_Revenue_Product.Series.Add(series1);
            this.chart_Revenue_Product.Size = new System.Drawing.Size(1144, 289);
            this.chart_Revenue_Product.TabIndex = 3;
            this.chart_Revenue_Product.Text = "chart1";
            this.chart_Revenue_Product.Click += new System.EventHandler(this.chart_Revenue_Product_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxCategoryType, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_Total_Revenue_category, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 367);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1144, 78);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // comboBoxCategoryType
            // 
            this.comboBoxCategoryType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategoryType.DropDownHeight = 200;
            this.comboBoxCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoryType.FormattingEnabled = true;
            this.comboBoxCategoryType.IntegralHeight = false;
            this.comboBoxCategoryType.Items.AddRange(new object[] {
            "Gach",
            "da"});
            this.comboBoxCategoryType.Location = new System.Drawing.Point(575, 4);
            this.comboBoxCategoryType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCategoryType.Name = "comboBoxCategoryType";
            this.comboBoxCategoryType.Size = new System.Drawing.Size(566, 33);
            this.comboBoxCategoryType.TabIndex = 3;
            this.comboBoxCategoryType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Revenue_category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Total_Revenue_category
            // 
            this.label_Total_Revenue_category.AutoSize = true;
            this.label_Total_Revenue_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Total_Revenue_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total_Revenue_category.ForeColor = System.Drawing.Color.Black;
            this.label_Total_Revenue_category.Location = new System.Drawing.Point(572, 39);
            this.label_Total_Revenue_category.Margin = new System.Windows.Forms.Padding(0);
            this.label_Total_Revenue_category.Name = "label_Total_Revenue_category";
            this.label_Total_Revenue_category.Size = new System.Drawing.Size(572, 39);
            this.label_Total_Revenue_category.TabIndex = 4;
            this.label_Total_Revenue_category.Text = "0";
            this.label_Total_Revenue_category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart_Revenue
            // 
            this.chart_Revenue.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart_Revenue.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea2.Name = "ChartArea1";
            this.chart_Revenue.ChartAreas.Add(chartArea2);
            this.chart_Revenue.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart_Revenue.Legends.Add(legend2);
            this.chart_Revenue.Location = new System.Drawing.Point(0, 78);
            this.chart_Revenue.Name = "chart_Revenue";
            this.chart_Revenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            this.chart_Revenue.Series.Add(series2);
            this.chart_Revenue.Size = new System.Drawing.Size(1144, 289);
            this.chart_Revenue.TabIndex = 1;
            this.chart_Revenue.Text = "chart1";
            this.chart_Revenue.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label_Revenue, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_Total, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8_display, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1144, 78);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label_Revenue
            // 
            this.label_Revenue.AutoSize = true;
            this.label_Revenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Revenue.ForeColor = System.Drawing.Color.Black;
            this.label_Revenue.Location = new System.Drawing.Point(0, 0);
            this.label_Revenue.Margin = new System.Windows.Forms.Padding(0);
            this.label_Revenue.Name = "label_Revenue";
            this.label_Revenue.Size = new System.Drawing.Size(572, 39);
            this.label_Revenue.TabIndex = 4;
            this.label_Revenue.Text = "Revenue";
            this.label_Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.ForeColor = System.Drawing.Color.Black;
            this.label_Total.Location = new System.Drawing.Point(572, 39);
            this.label_Total.Margin = new System.Windows.Forms.Padding(0);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(572, 39);
            this.label_Total.TabIndex = 4;
            this.label_Total.Text = "0";
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8_display
            // 
            this.label8_display.AutoSize = true;
            this.label8_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8_display.ForeColor = System.Drawing.Color.Black;
            this.label8_display.Location = new System.Drawing.Point(0, 39);
            this.label8_display.Margin = new System.Windows.Forms.Padding(0);
            this.label8_display.Name = "label8_display";
            this.label8_display.Size = new System.Drawing.Size(572, 39);
            this.label8_display.TabIndex = 3;
            this.label8_display.Text = "Total :";
            this.label8_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1196, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue_Product)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Revenue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_Revenue;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label8_display;
        private System.Windows.Forms.DateTimePicker dateTimePickerOverview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Total_Revenue_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Revenue_Product;
        private System.Windows.Forms.ComboBox comboBoxCategoryType;
    }
}