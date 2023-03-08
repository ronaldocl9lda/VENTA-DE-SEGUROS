
namespace InsuranceProgram.Layers.UI.Reports
{
    partial class FrmReportByIdentification
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
            this.bill_by_identificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReports = new InsuranceProgram.Layers.UI.Reports.DataSetReports();
            this.TxtClientIdentification = new System.Windows.Forms.TextBox();
            this.TxtClientName = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bill_by_identificationTableAdapter = new InsuranceProgram.Layers.UI.Reports.DataSetReportsTableAdapters.bill_by_identificationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bill_by_identificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReports)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_by_identificationBindingSource
            // 
            this.bill_by_identificationBindingSource.DataMember = "bill_by_identification";
            this.bill_by_identificationBindingSource.DataSource = this.DataSetReports;
            // 
            // DataSetReports
            // 
            this.DataSetReports.DataSetName = "DataSetReports";
            this.DataSetReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtClientIdentification
            // 
            this.TxtClientIdentification.Enabled = false;
            this.TxtClientIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClientIdentification.Location = new System.Drawing.Point(314, 44);
            this.TxtClientIdentification.Name = "TxtClientIdentification";
            this.TxtClientIdentification.Size = new System.Drawing.Size(165, 28);
            this.TxtClientIdentification.TabIndex = 0;
            // 
            // TxtClientName
            // 
            this.TxtClientName.Enabled = false;
            this.TxtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClientName.Location = new System.Drawing.Point(314, 88);
            this.TxtClientName.Name = "TxtClientName";
            this.TxtClientName.Size = new System.Drawing.Size(367, 28);
            this.TxtClientName.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::InsuranceProgram.Properties.Resources.lupa;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearch.Location = new System.Drawing.Point(713, 45);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(86, 61);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Identification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Name";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bill_by_identificationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InsuranceProgram.Layers.UI.Reports.ReportByIdentification.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 138);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(921, 354);
            this.reportViewer1.TabIndex = 5;
            // 
            // bill_by_identificationTableAdapter
            // 
            this.bill_by_identificationTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportByIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InsuranceProgram.Properties.Resources.Factura_electrónica;
            this.ClientSize = new System.Drawing.Size(945, 504);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtClientName);
            this.Controls.Add(this.TxtClientIdentification);
            this.Name = "FrmReportByIdentification";
            this.Text = "Report Bills By Identification";
            this.Load += new System.EventHandler(this.FrmReportByIdentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_by_identificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtClientIdentification;
        private System.Windows.Forms.TextBox TxtClientName;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bill_by_identificationBindingSource;
        private DataSetReports DataSetReports;
        private DataSetReportsTableAdapters.bill_by_identificationTableAdapter bill_by_identificationTableAdapter;
    }
}