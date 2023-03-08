
namespace InsuranceProgram.Layers.UI.Reports
{
    partial class FrmReportByRange
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
            this.bill_by_range_dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReports = new InsuranceProgram.Layers.UI.Reports.DataSetReports();
            this.dtpInitialDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalDate = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bill_by_range_dateTableAdapter = new InsuranceProgram.Layers.UI.Reports.DataSetReportsTableAdapters.bill_by_range_dateTableAdapter();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bill_by_range_dateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReports)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_by_range_dateBindingSource
            // 
            this.bill_by_range_dateBindingSource.DataMember = "bill_by_range_date";
            this.bill_by_range_dateBindingSource.DataSource = this.DataSetReports;
            // 
            // DataSetReports
            // 
            this.DataSetReports.DataSetName = "DataSetReports";
            this.DataSetReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpInitialDate
            // 
            this.dtpInitialDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInitialDate.Location = new System.Drawing.Point(98, 46);
            this.dtpInitialDate.Name = "dtpInitialDate";
            this.dtpInitialDate.Size = new System.Drawing.Size(271, 22);
            this.dtpInitialDate.TabIndex = 0;
            // 
            // dtpFinalDate
            // 
            this.dtpFinalDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalDate.Location = new System.Drawing.Point(469, 46);
            this.dtpFinalDate.Name = "dtpFinalDate";
            this.dtpFinalDate.Size = new System.Drawing.Size(271, 22);
            this.dtpFinalDate.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bill_by_range_dateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InsuranceProgram.Layers.UI.Reports.ReportByRange.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(923, 336);
            this.reportViewer1.TabIndex = 3;
            // 
            // bill_by_range_dateTableAdapter
            // 
            this.bill_by_range_dateTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::InsuranceProgram.Properties.Resources.lupa;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearch.Location = new System.Drawing.Point(784, 20);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(93, 65);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Initial Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Final Date";
            // 
            // FrmReportByRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InsuranceProgram.Properties.Resources._0024_S;
            this.ClientSize = new System.Drawing.Size(1001, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.dtpFinalDate);
            this.Controls.Add(this.dtpInitialDate);
            this.Name = "FrmReportByRange";
            this.Text = "Report Bills by Range of Dates";
            this.Load += new System.EventHandler(this.FrmReportByRange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_by_range_dateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInitialDate;
        private System.Windows.Forms.DateTimePicker dtpFinalDate;
        private System.Windows.Forms.Button BtnSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bill_by_range_dateBindingSource;
        private DataSetReports DataSetReports;
        private DataSetReportsTableAdapters.bill_by_range_dateTableAdapter bill_by_range_dateTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}