using RauMaMix.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RauMaMix.DAO
{
   public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO();return BillInfoDAO.instance; }
            set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("Delete dbo.BillInfo Where idFood= " + id);
        }
        public void DeleteBillByBillInfoID(int id)
        {
            DataProvider.Instance.ExecuteQuery("Delete dbo.BillInfo Where idBill= " + id);

        }
       
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> lstBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill="+id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                lstBillInfo.Add(info);
            }
            return lstBillInfo;
        }
        public void InsertBillInfo (int idBill,int idFood,int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { idBill,idFood,count});
        }



    }
}
