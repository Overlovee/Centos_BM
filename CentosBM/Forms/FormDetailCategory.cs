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
using CentosBM.SubForms;
using CentosBM.Forms;
using System.Data.SqlClient;
namespace CentosBM.Forms
{
    public partial class FormDetailCategory : Form
    {
        DbContext dbContext = new DbContext();
        public Category category { get; set; }
        public FormDetailCategory()
        {
            InitializeComponent();
        }

        private void FormDetailCategory_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM dbo.GetProductsByCategory(@CategoryID)";
            using (SqlCommand cmd = new SqlCommand(sql, dbContext.Con))
            {
                dbContext.open();
                cmd.Parameters.AddWithValue("@CategoryID", category.Id);

                // Sử dụng SqlDataAdapter để lấy dữ liệu vào DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hiển thị dữ liệu trên DataGridView
                dataGridView1.DataSource = dt;
            }
            label1.Text = label1.Text + category.Name;
        }
    }
}
