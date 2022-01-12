using RauMaMix.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RauMaMix.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "Select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
        public Category GetCategoryID(int id)
        {
            Category category = null;
            string query = "select * from FoodCategory where id=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;


        }
        public bool InsertCateGory(string name)
        {
            string query = string.Format("insert dbo.FoodCategory (name) values(N'{0}')",name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCateGory(int id,string name)
        {
            string query = string.Format("update dbo.FoodCategory set name=N'{0}' where id={1}", name,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCateGory(int id)
        {
            BillInfoDAO.Instance.DeleteBillByBillInfoID(id);
            BillDAO.Instance.DeleteBillByTableID(id);
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(id);
            FoodDAO.Instance.DeleteCategoryByIdFood(id);
            string query = string.Format("Delete FoodCategory where id={0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
      

    }
}
