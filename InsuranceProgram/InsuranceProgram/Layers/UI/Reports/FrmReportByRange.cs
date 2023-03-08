using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceProgram.Layers.UI.Reports
{
    public partial class FrmReportByRange : Form
    {
        public FrmReportByRange()
        {
            InitializeComponent();
        }

        private void FrmReportByRange_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReports.bill_by_range_date' Puede moverla o quitarla según sea necesario.
            
            this.reportViewer1.RefreshReport();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.bill_by_range_dateTableAdapter.Fill(this.DataSetReports.bill_by_range_date, dtpInitialDate.Value, dtpFinalDate.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
