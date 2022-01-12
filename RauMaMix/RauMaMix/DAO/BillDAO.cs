﻿using RauMaMix.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RauMaMix.DAO
{
   public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        //nếu thành công thì là bill id, còn thất bạn trả về -1
        public int GetUnCheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable=" + id + "AND status=0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        

        public void DeleteBillByTableID(int id)
        {
            DataProvider.Instance.ExecuteQuery("Delete dbo.Bill Where idTable= " + id);
        }
     

        public void CheckOut(int id,int discount,float totalPrice)
        {
            string query = "UPDATE dbo.Bill set DateCheckOut= GETDATE(), status= 1, " + " discount= "+discount + ", totalPrice= "+totalPrice +" where id= " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable ", new object[] { id });
        }
        public DataTable GetListByDate(DateTime checkIn, DateTime checkOut)
        {
          return  DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut",new object[] { checkIn,checkOut});
        }
        public DataTable GetListByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkIn , @checkOut , @page ", new object[] { checkIn, checkOut ,pageNum});
        }
        public int GetNumListByPage(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut});
        }
        
        public int GetMaxBill()
        {
            try
            {
               return (int)DataProvider.Instance.ExecuteScalar("select Max(id) From dbo.Bill");
            }
            catch
            {
                return 1;
            }
          }
    }
}
