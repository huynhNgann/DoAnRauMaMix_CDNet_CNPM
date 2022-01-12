
namespace RauMaMix
{
    partial class fReportDoanhThu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReportDoanhThu));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLRAUMAMIXXDataSet = new RauMaMix.QLRAUMAMIXXDataSet();
            this.BillInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillInfoTableAdapter = new RauMaMix.QLRAUMAMIXXDataSetTableAdapters.BillInfoTableAdapter();
            this.QLRAUMAMIXXDataSet1 = new RauMaMix.QLRAUMAMIXXDataSet1();
            this.USP_GetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_GetListBillByDateForReportTableAdapter = new RauMaMix.QLRAUMAMIXXDataSet1TableAdapters.USP_GetListBillByDateForReportTableAdapter();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QLRAUMAMIXXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLRAUMAMIXXDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListBillByDateForReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RauMaMix.Report_DoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 365);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLRAUMAMIXXDataSet
            // 
            this.QLRAUMAMIXXDataSet.DataSetName = "QLRAUMAMIXXDataSet";
            this.QLRAUMAMIXXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BillInfoBindingSource
            // 
            this.BillInfoBindingSource.DataMember = "BillInfo";
            this.BillInfoBindingSource.DataSource = this.QLRAUMAMIXXDataSet;
            // 
            // BillInfoTableAdapter
            // 
            this.BillInfoTableAdapter.ClearBeforeFill = true;
            // 
            // QLRAUMAMIXXDataSet1
            // 
            this.QLRAUMAMIXXDataSet1.DataSetName = "QLRAUMAMIXXDataSet1";
            this.QLRAUMAMIXXDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetListBillByDateForReportBindingSource
            // 
            this.USP_GetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.USP_GetListBillByDateForReportBindingSource.DataSource = this.QLRAUMAMIXXDataSet1;
            // 
            // USP_GetListBillByDateForReportTableAdapter
            // 
            this.USP_GetListBillByDateForReportTableAdapter.ClearBeforeFill = true;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(29, 25);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(206, 20);
            this.dtpkFromDate.TabIndex = 3;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(551, 25);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(215, 20);
            this.dtpkToDate.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.ForeColor = System.Drawing.Color.DarkGreen;
            this.label21.Location = new System.Drawing.Point(295, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(174, 32);
            this.label21.TabIndex = 25;
            this.label21.Text = "DOANH THU";
            // 
            // fReportDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dtpkToDate);
            this.Controls.Add(this.dtpkFromDate);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fReportDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fReportDoanhThu";
            this.Load += new System.EventHandler(this.fReportDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLRAUMAMIXXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLRAUMAMIXXDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BillInfoBindingSource;
        private QLRAUMAMIXXDataSet QLRAUMAMIXXDataSet;
        private QLRAUMAMIXXDataSetTableAdapters.BillInfoTableAdapter BillInfoTableAdapter;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateForReportBindingSource;
        private QLRAUMAMIXXDataSet1 QLRAUMAMIXXDataSet1;
        private QLRAUMAMIXXDataSet1TableAdapters.USP_GetListBillByDateForReportTableAdapter USP_GetListBillByDateForReportTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.Label label21;
    }
}