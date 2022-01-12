using RauMaMix.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RauMaMix.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance =new TableDAO() ;return TableDAO.instance; }
            private set { instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableDAO() { }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<Table> GetListTable()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFood");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public bool InsertTable(string name)
        {
            string query = string.Format("insert dbo.TableFood (name, status) values(N'{0}', N'Trống')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(string name,int id)
        {
            string query = string.Format("update dbo.TABLEFOOD set name=N'{0}' Where id={1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {

            BillInfoDAO.Instance.DeleteBillByBillInfoID(id);
            BillDAO.Instance.DeleteBillByTableID(id);
          
            string query = string.Format("Delete dbo.TableFood where id={0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
    }
}
