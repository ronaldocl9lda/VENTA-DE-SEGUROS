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
    public partial class FrmSelectClient : Form
    {
        public FrmSelectClient()
        {
            InitializeComponent();
        }

        private void Read()
        {
            try
            {
                dgvClients.DataSource = BLLClient.Read();
                LblTotal.Text = "Total Clients: " + Convert.ToString(dgvClients.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Format()
        {
            dgvClients.Columns[0].Visible = false;
        }
        private void FrmSelectPolicy_Load(object sender, EventArgs e)
        {
            this.Read();
            this.Format();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvClients.DataSource = BLLClient.Search(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvBilling_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.ClientId = Convert.ToString(dgvClients.CurrentRow.Cells["Identification"].Value);
            Variables.ClientName = Convert.ToString(dgvClients.CurrentRow.Cells["FirstName"].Value) + " " + Convert.ToString(dgvClients.CurrentRow.Cells["LastName"].Value);
            Variables.ClientEmail = Convert.ToString(dgvClients.CurrentRow.Cells["Email"].Value);
            this.Close();
        }
    }
}
