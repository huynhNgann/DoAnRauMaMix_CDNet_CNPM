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
    public partial class fReportDoanhThu : Form
    {
        public fReportDoanhThu()
        {
            InitializeComponent();
        }

        private void fReportDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLRAUMAMIXXDataSet1.USP_GetListBillByDateForReport' table. You can move, or remove it, as needed.
            this.USP_GetListBillByDateForReportTableAdapter.Fill(this.QLRAUMAMIXXDataSet1.USP_GetListBillByDateForReport, dtpkFromDate.Value, dtpkToDate.Value);
            // TODO: This line of code loads data into the 'QLRAUMAMIXXDataSet.BillInfo' table. You can move, or remove it, as needed.
            this.BillInfoTableAdapter.Fill(this.QLRAUMAMIXXDataSet.BillInfo);

            this.reportViewer1.RefreshReport();
        }
    }
}
