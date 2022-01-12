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
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource category = new BindingSource();

       
        public Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fAdmin()
        {
            InitializeComponent();
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            dtgvCategory.DataSource = category;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadAccount();
            LoadTable();
         // LoadListCustomer();
            LoadListFood();
            LoadListTable();
         //   LoadListCustomer();
            LoadListCategory();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbCategory);
            AddTableBinding();
            //AddCustomerBinding();
            AddAccountBinding();
            AddCategoryFoodBinding();
        }


        #region Method
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
   

        void LoadTable()
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
        }
        void LoadListTable()
        {
            dtgvTable.DataSource = TableDAO.Instance.GetListTable();
        }
        void LoadListCategory()
        {
            dtgvCategory.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void AddTableBinding()
        {
            txtTableNAme.DataBindings.Add(new Binding("Text",dtgvTable.DataSource,"name", true, DataSourceUpdateMode.Never));
            txtIDTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtStatusTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
        
        
        
        

        
       
        void AddAccountBinding()
        {
            txtNameAccount.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayAccount.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txtTypeAccount.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));

        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void LoadDateTimePickerBill()
        { 
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);

        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource= BillDAO.Instance.GetListByDate(checkIn, checkOut);

        }
       

        void AddFoodBinding()
        {
            txtNameFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name",true,DataSourceUpdateMode.Never));
            txtIDFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value",dtgvFood.DataSource,"Price", true, DataSourceUpdateMode.Never));
        }
        void AddCategoryFoodBinding()
        {
            txtIDCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id"));
            txtNameCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name"));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddAccount(string userName, string displayName,int type)
        {
            if(AccountDAO.Instance.InsertAccount(userName,displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();

        }
        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();

        }
        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa tài khoản hiện tại");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccount();

        }
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPass(userName))
            {
                MessageBox.Show("Đặt mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt mật khẩu thất bại");
            }
            LoadAccount();
        }

        #endregion
        #region Events
       
        private void iconButton1_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtSearchFoodName.Text);
        }
       
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {
           

        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtNameFood.Text;
            int categoryID = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            if(FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txtNameFood.Text;
            int categoryID = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txtIDFood.Text);
            if (FoodDAO.Instance.UpdateFood(id,name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }

        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDFood.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if(deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá thức ăn");
            }

        }
        private void txtIDFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryID(id);
                    cbCategory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbCategory.SelectedIndex = index;

                }
            }
            catch { }
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txtNameAccount.Text;
            string displayName = txtDisplayAccount.Text;
            int type =(int) txtTypeAccount.Value;
            AddAccount(userName, displayName, type);
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtNameAccount.Text;
           
            DeleteAccount(userName);
        }

        private void btnEditAcount_Click(object sender, EventArgs e)
        {
            string userName = txtNameAccount.Text;
            string displayName = txtDisplayAccount.Text;
            int type = (int)txtTypeAccount.Value;
            EditAccount(userName, displayName, type);
        }
        private void btnResetPassAccount_Click(object sender, EventArgs e)
        {
            string userName = txtNameAccount.Text;
            ResetPass(userName);
           
        }
        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void btnSearCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }
        
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txtTableNAme.Text;
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadListTable();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm bàn");
            }
            
        }
      /* private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDTable.Text);
            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadListTable();
                if (deleteTableF != null)
                {
                    deleteTableF(this, new EventArgs());
                }

            }
            else
            {
                MessageBox.Show("Lỗi khi xóa bàn");
            }
            LoadTable();
        }
      */
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtNameCategory.Text;
            if (CategoryDAO.Instance.InsertCateGory(name))
            {
                MessageBox.Show("Thêm doanh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Thêm doanh mục không thành công");
                    
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txtTableNAme.Text;
            int id = Convert.ToInt32(txtIDTable.Text);
            if (TableDAO.Instance.UpdateTable(name,id))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadListTable();
                if (deleteTableF != null)
                {
                    deleteTableF(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Sửa khi thêm bàn");
            }
            LoadTable();
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txtIDCategory.Text;
            int id = Convert.ToInt32(txtIDCategory.Text);
            if (CategoryDAO.Instance.UpdateCateGory(id,name))
            {
                MessageBox.Show("Thêm doanh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm doanh mục");
            }
        }
       private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDCategory.Text);
            if (CategoryDAO.Instance.DeleteCateGory(id))
            {
                MessageBox.Show("Xóa doanh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa doanh mục");
            }
        }
        
      
        
        private void txtIDCustomer_TextChanged(object sender, EventArgs e)
        {
          

        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
      
     
        private event EventHandler deleteTableF;
        public event EventHandler DeleteTableF
        {
            add { deleteTableF += value; }
            remove { deleteTableF -= value; }
        }
        private event EventHandler deletecate;
        public event EventHandler DeleteTcate
        {
            add { deletecate += value; }
            remove { deletecate -= value; }
        }
        private void btnDeleTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDTable.Text);
            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadListTable();
                if (deleteTableF != null)
                {
                    deleteTableF(this, new EventArgs());
                }

            }
            else
            {
                MessageBox.Show("Xóa bàn không thành công");
            }
            LoadTable();
        }
       



        #endregion

        private void FirstBill_Click(object sender, EventArgs e)
        {
            txtPageBill.Text = "1";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumListByPage(dtpkFromDate.Value, dtpkToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
                lastPage++;
            txtPageBill.Text = lastPage.ToString();
        }

        private void txtPageBill_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txtPageBill.Text));
        }

        private void btnPevioursBill_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageBill.Text);
            if (page > 1)
                page--;
            txtPageBill.Text = page.ToString();
        }

        private void btnNextPageBill_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumListByPage(dtpkFromDate.Value, dtpkToDate.Value);
            if (page <sumRecord)
                page++;
            txtPageBill.Text = page.ToString();
        }

        
     

      

        private void iconButton6_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Close();
            f.Show();
        }

        private void ibtnTable_Click(object sender, EventArgs e)
        {
            fTableManager f = new fTableManager(loginAccount);
            this.Close();
            f.Show();
        }

        private void ibntCustomer_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            this.Hide();
            f.Show();
        }

     

        private void ibtnAccoutProfile_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            this.Hide();
            f.Show();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

     //       this.reportViewer1.RefreshReport();
        //    this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            fReportDoanhThu f = new fReportDoanhThu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDeleCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDCategory.Text);
            if (CategoryDAO.Instance.DeleteCateGory(id))
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadListCategory();
                if (deletecate != null)
                {
                    deletecate(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Xóa bàn không thành công");
            }
            LoadListCategory();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
