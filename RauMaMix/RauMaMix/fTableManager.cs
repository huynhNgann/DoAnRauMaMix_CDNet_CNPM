using RauMaMix.DAO;
using RauMaMix.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RauMaMix
{
    public partial class fTableManager : Form
    {
        public static Table table1;
       
        // public static int name;
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
            // LoadFoodListCategoryID(id);
        }


        #region Method

        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            flpTable.Controls.Clear();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightBlue;
                        break;
                    default:
                        btn.BackColor = Color.YellowGreen;
                        break;
                }

                flpTable.Controls.Add(btn);


            }
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodCategoryByID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";

        }

        void ShowBill(int id)
        {

            lsvBill.Items.Clear();
            List<RauMaMix.DTO.Menu> lstBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (RauMaMix.DTO.Menu item in lstBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);

            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        void btn_click(object sender, EventArgs e)
        {
           int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        #endregion
        #region Events

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* private void thôngTinCáNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
         {
             fAccountProfile f = new fAccountProfile(loginAccount);
             f.UpdateAccount += f_UpdateAccount;
             f.ShowDialog();
         }*/

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            //thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";

        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            // f.InsertTable += f_InsertTable;
            // f.DeleteTableF += f_DeleteTable;
            //f.UpdateTable += f_UpdateTable;
            f.loginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
          //  this.Hide();
            f.ShowDialog();
        }
        /* private void adminToolStripMenuItem_Click(object sender, EventArgs e)
         {
             fAdmin f = new fAdmin();
             // f.InsertTable += f_InsertTable;
             // f.DeleteTableF += f_DeleteTable;
             //f.UpdateTable += f_UpdateTable;
             f.loginAccount = LoginAccount;
             f.InsertFood += f_InsertFood;
             f.DeleteFood += f_DeleteFood;
             f.UpdateFood += f_UpdateFood;
             f.ShowDialog();

         }*/


        private void ibtnAccount_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            this.Hide();
            f.ShowDialog();
        }
        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill != null)
            {
                ShowBill((lsvBill.Tag as Table).ID);
            }
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill != null)
            {
                ShowBill((lsvBill.Tag as Table).ID);
            }
            LoadTable();
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill != null)
            {
                ShowBill((lsvBill.Tag as Table).ID);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListCategoryID(id);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int iDFood = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxBill(), iDFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, iDFood, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table1 = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table1.ID);
            int discount = (int)nmDiscount.Value;

            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hoá đơn cho bàn {0}\n Tổng tiền -(Tổng tiền/100)xGiảm giá\n=>{1}-({1}/100)x{2}={3}", table1.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table1.ID);
                    LoadTable();
                }

            }
            // LoadTable();

        }
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn{1}", id1, id2), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }


        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }








        #endregion

        private void ibtnbill_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            this.Hide();
            f.Show();

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.Show();
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void ibtnTable_Click(object sender, EventArgs e)
        {

        }
    }
    }

