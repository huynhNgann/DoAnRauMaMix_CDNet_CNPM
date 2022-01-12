using RauMaMix.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RauMaMix.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get {if(instance == null) instance = new CustomerDAO();return instance; }
             private set{ instance = value; }
        }
        public List<Customer> GetListCustomer()
        {
            List<Customer> listMenu = new List<Customer>();
            string query = "select * from KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                listMenu.Add(customer);
            }
            return listMenu;
        }
        public Customer GetCustomerByID(int id)
        {
            Customer customer = null;
            string query = "Select * from KhachHang where idKh=" + id;

            return customer;

        }
      
        public bool InsertCustomer(string name,string gioitinh,string diachi,string sdt)
        {
            string query = string.Format("insert dbo.KhachHang(TenKh,GioiTinh,Diachi,SDT) values(N'{0}' , N'{1}', N'{2}', N'{3}')", name, gioitinh, diachi, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCustomer(int id,string name, string gioitinh, string diachi, string sdt)
        {
            string query = string.Format("update dbo.KhachHang set TenKh=N'{0}', GioiTinh=N'{1}', DiaChi=N'{2}', SDT='{3}' where idKh= {4} ", name, gioitinh, diachi, sdt,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCustomer(int id)
        {
            string query="delete dbo.KhachHang where idKh="+id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
