using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentosBM.Models;
using CentosBM.Connects;
using CentosBM.UserControls;
using System.IO;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CentosBM.Forms
{
    public partial class FormOrder : Form
    {
        public int customerID { get; set; }
        public MyAccount account { get; set; }
        public decimal total { get; set; }
        public List<Product> productList = new List<Product>();

        // Phương thức hoặc thuộc tính để nhận danh sách sản phẩm từ Form Home
        public void SetProductList(List<Product> products)
        {
            productList = products;
            Load_ListProduct(productList);

        }
        public FormOrder()
        {
            InitializeComponent();
            account = new MyAccount();
        }

        private void button_Addnewcustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer form = new AddNewCustomer();
            form.ShowDialog();
        }
        public void Load_Data(bool isSearched = false)
        {
            ConnectCustomer connectCustomer = new ConnectCustomer();
            Customer customer = new Customer();
            if (isSearched)
            {
                customer = connectCustomer.getCustomer(textBoxSearch.Text);
            }
            customerID = customer.CustomerID;
            textBoxFullName.Text = customer.Name;
            textBoxAddress.Text = customer.Address;
            textBoxPhone.Text = customer.Phone;
        }
        public void LoadNewCustomer(string name, string address, string phone)
        {
            textBoxFullName.Text = name;
            textBoxAddress.Text = address;
            textBoxPhone.Text = phone;
            textBoxSearch.Text = phone;
        }
        public void Load_ListProduct(List<Product> products)
        {
            foreach (Product product in products)
            {
                Panel newPanel = new Panel();
                panel_Listproduct.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                OrderProductItem item = new OrderProductItem();
                item.product = product;


                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 50;
                item.ForeColor = Color.Black;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                Load_Data(true);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_Listproduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            ConnectOrder order = new ConnectOrder();

            DateTime orderdate = dateTimePickerOrder.Value;
            string orderstatus = comboBox_OrderStatus.Text;
            string shipmentStautus = "Chờ giao hàng";
            string Orderid = "";
            int rs = 0, ts = 0;
            rs = order.CreateOrder(orderdate, total, customerID, account.EmployeeID, orderstatus, shipmentStautus);
            if (rs == 0)
            {
                MessageBox.Show("Error");
            }
            if (rs != 0)
            {
                Orderid = order.getLastOrderdetail();
                foreach (Product item in productList)
                {
                    ts = order.AddproductDetail(Orderid, item.Id, item.Quantity, item.Price);
                }
                if (ts != 0)
                {
                    MessageBox.Show("Complete !!!");
                    this.Close();
                }
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            textBox_Total.Text = total.ToString();
            dateTimePickerOrder.Value = DateTime.Now;
        }





        private void button_PrintInvoice_Click(object sender, EventArgs e)
        {
            btnExportToWord_Click(sender, e);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document (*.docx)|*.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (DocX document = DocX.Create(filePath))
                {

                    document.InsertParagraph($"Ngày đặt hàng: {dateTimePickerOrder.Value.ToShortDateString()}").FontSize(14).Alignment = Xceed.Document.NET.Alignment.right;

                    document.InsertParagraph("Centos BM").Bold().FontSize(18).Alignment = Xceed.Document.NET.Alignment.center;
                    document.InsertParagraph("HÓA ĐƠN BÁN HÀNG").Bold().FontSize(20).Alignment = Xceed.Document.NET.Alignment.center;
                    document.InsertParagraph();
                    document.InsertParagraph();

                    // Thêm thông tin khách hàng vào tài liệu
                    document.InsertParagraph($"Khách hàng: {textBoxFullName.Text}");
                    document.InsertParagraph($"Địa chỉ: {textBoxAddress.Text}");
                    document.InsertParagraph($"Điện thoại: {textBoxPhone.Text}");
                    document.InsertParagraph();
                    document.InsertParagraph();

                    // Thêm bảng thông tin sản phẩm
                    var table = document.AddTable(productList.Count + 1, 5);
                    table.Rows[0].Cells[0].Paragraphs.First().Append("Tên sản phẩm").Bold();
                    table.Rows[0].Cells[1].Paragraphs.First().Append("Đơn Vị Tính").Bold();
                    table.Rows[0].Cells[2].Paragraphs.First().Append("Giá").Bold();
                    table.Rows[0].Cells[3].Paragraphs.First().Append("Số Lượng").Bold();
                    table.Rows[0].Cells[4].Paragraphs.First().Append("Thành Tiền").Bold();

                    // Thêm danh sách sản phẩm vào bảng
                    for (int i = 0; i < productList.Count; i++)
                    {
                        table.Rows[i + 1].Cells[0].Paragraphs.First().Append(productList[i].Name);
                        table.Rows[i + 1].Cells[1].Paragraphs.First().Append(productList[i].Unit);
                        table.Rows[i + 1].Cells[2].Paragraphs.First().Append(productList[i].Price.ToString());
                        table.Rows[i + 1].Cells[3].Paragraphs.First().Append(productList[i].Quantity.ToString());
                        table.Rows[i + 1].Cells[4].Paragraphs.First().Append((productList[i].Price * productList[i].Quantity).ToString());
                    }

                    // Định dạng bảng

                    table.AutoFit = Xceed.Document.NET.AutoFit.Contents;
                    document.InsertTable(table);

                    // Thêm khoảng trắng
                    document.InsertParagraph();
                    document.InsertParagraph();
                    document.InsertParagraph($"Tổng Tiền: \t{total} VND").Bold().FontSize(15).Alignment = Xceed.Document.NET.Alignment.right;
                    document.InsertParagraph("----------------------------------------------------").Alignment = Xceed.Document.NET.Alignment.right;

                    document.InsertParagraph("Ký Tên\t\t").Bold().FontSize(15).Alignment = Xceed.Document.NET.Alignment.right;


                    // Lưu tài liệu
                    document.Save();
                }
                // Mở tệp Word sau khi lưu (nếu muốn)
                System.Diagnostics.Process.Start(filePath);
            }
        }

        private void dateTimePickerOrder_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
