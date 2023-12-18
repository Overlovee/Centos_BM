using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using CentosBM.Models;
using CentosBM.Connects;
namespace CentosBM.Forms
{
    public partial class Overview : Form
    {
        DbContext db = new DbContext();
        public Overview()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void Load_CategoryCombobox()
        {
            ConnectCategory connectCategory = new ConnectCategory();
            List<Category> categories = connectCategory.GetCategories();
            comboBoxCategoryType.Items.Clear();
            comboBoxCategoryType.Items.Add("Tất cả");
            foreach (Category item in categories)
            {
                comboBoxCategoryType.Items.Add(item.Name);
            }
            comboBoxCategoryType.SelectedItem = "Tất cả";
        }
        public void LoadRevenueChartByMonth()
        {
            int month = dateTimePickerOverview.Value.Month;
            ConnectOrder conO = new ConnectOrder();
            List<Order> orderList = conO.getAllDatabymonth(month);
            label_Revenue.Text = "Revenue in month: " + month;
            // Clear existing data in the chart
            chart_Revenue.Series.Clear();

            // Create a dictionary to store the total amount for each day
            Dictionary<int, decimal> dailyTotalAmounts = new Dictionary<int, decimal>();
            decimal totalAmount = 0;

            foreach (Order order in orderList)
            {
                totalAmount += order.TotalAmount;
                int dayLabel = order.OrderDate.Day;

                if (dailyTotalAmounts.ContainsKey(dayLabel))
                {
                    dailyTotalAmounts[dayLabel] += order.TotalAmount;
                }
                else
                {
                    dailyTotalAmounts.Add(dayLabel, order.TotalAmount);
                }
            }

            foreach (var dailyTotal in dailyTotalAmounts)
            {
                Series daySeries = new Series($"Day {dailyTotal.Key}");
                daySeries.ChartType = SeriesChartType.Column;

                foreach (Order order in orderList.Where(o => o.OrderDate.Day == dailyTotal.Key))
                {
                    // Sử dụng kiểu DateTime cho giá trị trục x
                    daySeries.Points.AddXY(new DateTime(order.OrderDate.Year, order.OrderDate.Month, order.OrderDate.Day), dailyTotal.Value);
                }
                daySeries.Label= dailyTotal.Value.ToString();
                chart_Revenue.Series.Add(daySeries);
            }
            chart_Revenue.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chart_Revenue.ChartAreas[0].AxisX.Interval = 1;
            chart_Revenue.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;


            label_Total.Text = totalAmount.ToString() + "VND";

            // Refresh the chart
            chart_Revenue.Update();
        }
        public void Reload_Data()
        {
            chart_Revenue.Series.Clear();
            chart_Revenue_Product.Series.Clear();
            LoadRevenueChartByMonth();
            Load_Data_Revenue_Product();
        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dateTimePickerOverview_ValueChanged(object sender, EventArgs e)
        {
            Reload_Data();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            LoadRevenueChartByMonth();
            Load_CategoryCombobox();
            Load_Data_Revenue_Product();
            dateTimePickerOverview.Value = DateTime.Now;
        }
        public void Load_Data_Revenue_Product()
        {
            ConnectOrder connectOrder = new ConnectOrder();
            string categoryName = comboBoxCategoryType.SelectedItem.ToString();
            int month = dateTimePickerOverview.Value.Month;

            List<Product> list = connectOrder.getDataRevenueProductByCategory(categoryName, month);

            // Assuming you have a chart control named 'chart_Revenue_Product' on your form
            chart_Revenue_Product.Series.Clear();
            chart_Revenue_Product.Series.Add("Revenue_Product");
            decimal total = 0;

            foreach (Product product in list)
            {
                decimal revenue = product.Quantity * product.Price;
                total += revenue;

                // Add data point with label and value to the existing series
                // Thêm điểm vào loạt dữ liệu "Revenue_Product"
                chart_Revenue_Product.Series["Revenue_Product"].Points.AddXY(product.Name, revenue);

                // Lấy chỉ số của điểm vừa thêm vào
                int pointIndex = chart_Revenue_Product.Series["Revenue_Product"].Points.Count - 1;

                // Đặt nhãn của điểm là giá trị doanh thu
                chart_Revenue_Product.Series["Revenue_Product"].Points[pointIndex].Label = $"{revenue}";

                // Đặt nhãn của trục X (AxisLabel) là tên sản phẩm
                chart_Revenue_Product.Series["Revenue_Product"].Points[pointIndex].AxisLabel = product.Name;

                // Thêm chú thích (Legend) cho loạt dữ liệu "Revenue_Product"
                chart_Revenue_Product.Series["Revenue_Product"].Points[pointIndex].LegendText = product.Name;

            }

            label_Total_Revenue_category.Text = total.ToString();
            chart_Revenue_Product.Series["Revenue_Product"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }


        private void chart_Revenue_Product_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload_Data();
        }
    }
}
