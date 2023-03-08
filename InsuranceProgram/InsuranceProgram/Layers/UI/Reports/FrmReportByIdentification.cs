using InsuranceProgram.Layers.Persistence;
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
    public partial class FrmReportByIdentification : Form
    {
        public FrmReportByIdentification()
        {
            InitializeComponent();
        }

        private void FrmReportByIdentification_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReports.bill_by_identification' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'DataSetReports.bill_by_identification' Puede moverla o quitarla según sea necesario.


            this.reportViewer1.RefreshReport();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FrmSelectClient Frm = new FrmSelectClient();
            Frm.ShowDialog();
            TxtClientIdentification.Text = Variables.ClientId;
            TxtClientName.Text = Variables.ClientName;

            this.bill_by_identificationTableAdapter.Fill(this.DataSetReports.bill_by_identification, TxtClientIdentification.Text);
            this.reportViewer1.RefreshReport();
        }

    }
}
