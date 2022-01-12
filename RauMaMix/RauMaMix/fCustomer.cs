using RauMaMix.DAO;
using RauMaMix.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RauMaMix
{
    public partial class fCustomer : Form
    {
        BindingSource cusList = new BindingSource();

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        //    public virtual ICollection<Customer> Login { get; set; }
    }
        public fCustomer()
        {
            InitializeComponent();
            LoadCustomer();
            LoadListCustomer();
            AddCustomerBinding();
            dtgvCustomer.DataSource = cusList;
            //       AddCustomerBinding();

        }
#region events
        void LoadCustomer()
        {
            cusList.DataSource = CustomerDAO.Instance.GetListCustomer();
        }
        void LoadListCustomer()
        {
            dtgvCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
        }
        void AddCustomerBinding()
        {
            txtIDCustomer.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "idKh", true, DataSourceUpdateMode.Never));
            txtNameCustomer.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "tenKh", true, DataSourceUpdateMode.Never));
            txtgioiTinh.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtAdressCustomer.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtTelephoneCus.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "SDT"));
        }


      
        #endregion
        #region method
        private void ibtnHome_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.Show();

        }

        private void ibtnTable_Click(object sender, EventArgs e)
        {
            fTableManager f = new fTableManager(loginAccount);
            this.Hide();
            f.Show();
        }

      

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string ten = txtNameCustomer.Text;
            string gioiTinh = txtgioiTinh.Text;
            string diachi = txtAdressCustomer.Text;
            string sdt = txtTelephoneCus.Text;
            if (CustomerDAO.Instance.InsertCustomer(ten, gioiTinh, diachi, sdt))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khách hàng");
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.Show();
        }

        private void ibtnAccoutProfile_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.Show();

        }

       

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDCustomer.Text);
            string ten = txtNameCustomer.Text;
            string gioiTinh = txtgioiTinh.Text;
            string diachi = txtAdressCustomer.Text;
            string sdt = txtTelephoneCus.Text;
            if (CustomerDAO.Instance.UpdateCustomer(id, ten, gioiTinh, diachi, sdt))
            {
                MessageBox.Show("Cập nhật thành công");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khách hàng");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDCustomer.Text);
            if (CustomerDAO.Instance.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa khách hàng");
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fTableManager f = new fTableManager(loginAccount);
            this.Close();
            f.Show();
        }


        #endregion



    }
}
