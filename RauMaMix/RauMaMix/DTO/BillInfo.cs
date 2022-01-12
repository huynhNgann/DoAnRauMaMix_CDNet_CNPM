using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RauMaMix.DTO
{
    public class BillInfo
    {
        public BillInfo(int id,int idBill,int idFood,int count)
        {
            this.ID = id;
            this.IDBill = idBill;
            this.IDFood = idFood;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDBill = (int)row["idBill"];
            this.IDFood = (int)row["idFood"];
            this.Count = (int)row["count"];
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int iDFood;
        public int IDFood
        {
            get { return iDFood; }
            set { iDFood = value; }
        }
        private int iDBill;
        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
