
namespace RauMaMix
{
    partial class fTableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columiDFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmThanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ibtnLogout = new FontAwesome.Sharp.IconButton();
            this.ibtnCustomer = new FontAwesome.Sharp.IconButton();
            this.ibtnAccount = new FontAwesome.Sharp.IconButton();
            this.ibtnTable = new FontAwesome.Sharp.IconButton();
            this.ibtnHome = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(588, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 237);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columiDFood,
            this.columCount,
            this.clmDongia,
            this.colmThanhtien});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(13, 17);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(394, 217);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columiDFood
            // 
            this.columiDFood.Text = "ID Food";
            this.columiDFood.Width = 96;
            // 
            // columCount
            // 
            this.columCount.Text = "Count";
            this.columCount.Width = 49;
            // 
            // clmDongia
            // 
            this.clmDongia.Text = "Đơn Giá";
            // 
            // colmThanhtien
            // 
            this.colmThanhtien.Text = "Thành tiền";
            this.colmThanhtien.Width = 68;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(588, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 87);
            this.panel3.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.Location = new System.Drawing.Point(224, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(183, 26);
            this.txtTotalPrice.TabIndex = 8;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 53);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(103, 24);
            this.cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSwitchTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSwitchTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(103, 39);
            this.btnSwitchTable.TabIndex = 7;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(112, 53);
            this.nmDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(88, 20);
            this.nmDiscount.TabIndex = 4;
            this.nmDiscount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDiscount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiscount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiscount.Location = new System.Drawing.Point(112, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(103, 39);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Giảm Giá ";
            this.btnDiscount.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckOut.Location = new System.Drawing.Point(224, 38);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(183, 46);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(588, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 97);
            this.panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(224, 66);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(145, 20);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFood.Location = new System.Drawing.Point(30, 45);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(170, 41);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(224, 20);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(170, 24);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(30, 13);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(170, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpTable);
            this.panel1.Location = new System.Drawing.Point(243, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 433);
            this.panel1.TabIndex = 15;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(3, 20);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(320, 406);
            this.flpTable.TabIndex = 0;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGreen;
            this.panel5.Controls.Add(this.ibtnLogout);
            this.panel5.Controls.Add(this.ibtnCustomer);
            this.panel5.Controls.Add(this.ibtnAccount);
            this.panel5.Controls.Add(this.ibtnTable);
            this.panel5.Controls.Add(this.ibtnHome);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.ForeColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 533);
            this.panel5.TabIndex = 1;
            // 
            // ibtnLogout
            // 
            this.ibtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnLogout.FlatAppearance.BorderSize = 0;
            this.ibtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnLogout.IconColor = System.Drawing.Color.White;
            this.ibtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLogout.Location = new System.Drawing.Point(0, 473);
            this.ibtnLogout.Name = "ibtnLogout";
            this.ibtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnLogout.Size = new System.Drawing.Size(237, 60);
            this.ibtnLogout.TabIndex = 9;
            this.ibtnLogout.Text = "ĐĂNG XUẤT";
            this.ibtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnLogout.UseVisualStyleBackColor = true;
            this.ibtnLogout.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // ibtnCustomer
            // 
            this.ibtnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCustomer.FlatAppearance.BorderSize = 0;
            this.ibtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtnCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ibtnCustomer.IconColor = System.Drawing.Color.White;
            this.ibtnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCustomer.Location = new System.Drawing.Point(0, 280);
            this.ibtnCustomer.Name = "ibtnCustomer";
            this.ibtnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnCustomer.Size = new System.Drawing.Size(237, 60);
            this.ibtnCustomer.TabIndex = 8;
            this.ibtnCustomer.Text = "KHÁCH HÀNG";
            this.ibtnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCustomer.UseVisualStyleBackColor = true;
            this.ibtnCustomer.Click += new System.EventHandler(this.ibtnbill_Click);
            // 
            // ibtnAccount
            // 
            this.ibtnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAccount.FlatAppearance.BorderSize = 0;
            this.ibtnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAccount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtnAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnAccount.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnAccount.IconColor = System.Drawing.Color.White;
            this.ibtnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAccount.Location = new System.Drawing.Point(0, 220);
            this.ibtnAccount.Name = "ibtnAccount";
            this.ibtnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnAccount.Size = new System.Drawing.Size(237, 60);
            this.ibtnAccount.TabIndex = 7;
            this.ibtnAccount.Text = "TÀI KHOẢN";
            this.ibtnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAccount.UseVisualStyleBackColor = true;
            this.ibtnAccount.Click += new System.EventHandler(this.ibtnAccount_Click);
            // 
            // ibtnTable
            // 
            this.ibtnTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTable.FlatAppearance.BorderSize = 0;
            this.ibtnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtnTable.ForeColor = System.Drawing.Color.DarkGreen;
            this.ibtnTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.ibtnTable.IconColor = System.Drawing.Color.DarkGreen;
            this.ibtnTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTable.Location = new System.Drawing.Point(0, 160);
            this.ibtnTable.Name = "ibtnTable";
            this.ibtnTable.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnTable.Size = new System.Drawing.Size(237, 60);
            this.ibtnTable.TabIndex = 6;
            this.ibtnTable.Text = "QUẢN LÝ BÀN";
            this.ibtnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTable.UseVisualStyleBackColor = false;
            this.ibtnTable.Click += new System.EventHandler(this.ibtnTable_Click);
            // 
            // ibtnHome
            // 
            this.ibtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnHome.FlatAppearance.BorderSize = 0;
            this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnHome.IconColor = System.Drawing.Color.White;
            this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.Location = new System.Drawing.Point(0, 100);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnHome.Size = new System.Drawing.Size(237, 60);
            this.ibtnHome.TabIndex = 4;
            this.ibtnHome.Text = "HOME";
            this.ibtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnHome.UseVisualStyleBackColor = true;
            this.ibtnHome.Click += new System.EventHandler(this.ibtnHome_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(237, 100);
            this.panel6.TabIndex = 3;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblExit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblExit.Location = new System.Drawing.Point(992, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(34, 33);
            this.lblExit.TabIndex = 16;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(253, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "QUẢN LÝ BÀN";
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1032, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Rau Má Mix";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ColumnHeader columiDFood;
        private System.Windows.Forms.ColumnHeader columCount;
        private System.Windows.Forms.ColumnHeader clmDongia;
        private System.Windows.Forms.ColumnHeader colmThanhtien;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton ibtnLogout;
        private FontAwesome.Sharp.IconButton ibtnCustomer;
        private FontAwesome.Sharp.IconButton ibtnAccount;
        private FontAwesome.Sharp.IconButton ibtnTable;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label2;
   //     private QLRAUMAMIXDataSetTableAdapters.USP_GetListBillByDateForReportTableAdapter usP_GetListBillByDateForReportTableAdapter1;
    }
}