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

namespace InsuranceProgram.Layers.UI
{
    public partial class FrmSelectPolicy : Form
    {
        public FrmSelectPolicy()
        {
            InitializeComponent();
        }

        private void Read()
        {
            try
            {
                dgvPolicies.DataSource = BLLPolicy.Read();
                LblTotal.Text = "Total Policies: " + Convert.ToString(dgvPolicies.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Format()
        {
            dgvPolicies.Columns[0].Visible = false;
        }
        private void FrmSelectPolicy_Load(object sender, EventArgs e)
        {
            this.Read();
            this.Format();
        }

        private void dgvPolicies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.PolicyID = Convert.ToInt32(dgvPolicies.CurrentRow.Cells["Code"].Value);
            Variables.PolicyDescription = Convert.ToString(dgvPolicies.CurrentRow.Cells["Description"].Value);
            this.Dispose();
        }
    }
}
