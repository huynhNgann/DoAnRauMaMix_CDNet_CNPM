using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RauMaMix.DTO
{
    public class Customer
    {
        public Customer(int idKH,string tenKH, string gioitinh,string diachi,string sdt)
        {
            this.IDKh = idKH;
            this.TenKH = tenKH;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
        }
        public Customer(DataRow row)
        {
            this.IDKh =(int)row["idKH"];
            this.TenKH = row["tenKH"].ToString();
            this.GioiTinh = row["gioitinh"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.SDT = row["sdt"].ToString();
        }
        private string sdt;
        private string diaChi;
        private string gioiTinh;
        private string tenKH;
        private int iDKh;

        public int IDKh { get => iDKh; set => iDKh = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sdt; set => sdt = value; }
    }
}
