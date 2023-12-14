using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using CentosBM.Models;

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
