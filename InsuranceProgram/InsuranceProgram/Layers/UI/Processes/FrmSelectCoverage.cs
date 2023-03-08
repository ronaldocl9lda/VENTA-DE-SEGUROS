using InsuranceProgram.Layers.BLL;
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

namespace InsuranceProgram.Layers.UI.Processes
{
    public partial class FrmSelectCoverage : Form
    {
        public FrmSelectCoverage()
        {
            InitializeComponent();
        }

        private void FrmSelectCoverage_Load(object sender, EventArgs e)
        {
            this.Read();
        }
        private void Read()
        {
            try
            {
                dgvCoverages.DataSource = BLLPolicy.Read(Variables.PolicyID);
                LblTotal.Text = "Total Coverages: " + Convert.ToString(dgvCoverages.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvCoverages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.CoverageAmount = Convert.ToDecimal(dgvCoverages.CurrentRow.Cells["Total"].Value);
            Variables.CoverageId = Convert.ToInt32(dgvCoverages.CurrentRow.Cells["ID"].Value);
            Variables.CoverageDescription = Convert.ToString(dgvCoverages.CurrentRow.Cells["Description"].Value);
            this.Close();
        }
    }
}
