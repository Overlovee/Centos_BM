using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using CentosBM.Models;
using System.Data;
namespace CentosBM.Connects
{
    public class ConnectCategory
    {
        DbContext dbContext = new DbContext();
        public List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();
            string sql = ("Select * from Categories");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Category emp = new Category();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public int addNew(string Name)
        {
            int result = 0;
            if (!string.IsNullOrWhiteSpace(Name))
            {

                using (SqlCommand cmd = new SqlCommand("AddCategory", dbContext.Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NameCategory", Name);
                    dbContext.open();

                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
                if (result > 0)
                {
                    return 1; // Trả về 1 nếu có bản ghi bị ảnh hưởng (thêm mới thành công)
                }
                dbContext.close();

            }

            return result;
        }
        public int UpdateDataForItem(int id, string name)
        {
            int rs = 0;
            string sql = "EXEC UpdateCategoryName  " +
                "@CategoryID = " + id + "," +
                "@NewNameCategory = N'" + name + "'";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }





        //public Category getDataByID(string id)
        //{
        //    Category emp = new Category();
        //    string sql = ("Select * from Categories where ID = '" + id + "'");
        //    SqlDataReader rdr = dbContext.ExcuteQuery(sql);
        //    if (rdr.Read())
        //    {
        //        emp.CategoryID = rdr.GetValue(0).ToString();
        //        emp.CategoryName = rdr.GetValue(1).ToString();
        //        emp.CategoryType = rdr.GetValue(2).ToString();
        //        emp.CategoryImg = rdr.GetValue(3).ToString();

        //    }
        //    rdr.Close();
        //    return emp;
        //}
        public Category getDataByName(string name)
        {
            Category emp = new Category();
            string sql = "Select * from Categories where NameCategory like N'" + name + "'";
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
            }
            rdr.Close();
            return emp;
        }
        //public int addNewItem(Category category)
        //{
        //    int rs = 0;
        //    string sql = "INSERT INTO Categories VALUES('" + category.CategoryID +
        //        "', N'" + category.CategoryName +
        //        "', '" + category.CategoryType + "', '" + category.CategoryImg + "')";
        //    rs = dbContext.ExcuteNonQuery(sql);
        //    return rs;
        //}
        //public int updateDataForItem(Category category)
        //{
        //    int rs = 0;
        //    string sql = "UPDATE Categories " +
        //        "SET Category_Type = '" + category.CategoryType + "', " +
        //        "Category_Name = N'" + category.CategoryName + "', " +
        //        "Category_Img = '" + category.CategoryImg + "' " +
        //        "WHERE ID = '" + category.CategoryID + "'";
        //    rs = dbContext.ExcuteNonQuery(sql);
        //    return rs;
        //}

        //public int deleteDataById(string id)
        //{
        //    int rs = 0;
        //    string sql = "EXEC DeleteCategory @Category_ID = '" + id + "'";
        //    rs = dbContext.ExcuteNonQuery(sql);
        //    return rs;
        //}
    }
}
