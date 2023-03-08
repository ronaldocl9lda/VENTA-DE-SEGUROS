using InsuranceProgram.Layers.BLL;
using System;
using log4net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceProgram.Layers.UI.Maintenances
{
    public partial class FrmPolicy : Form
    {
        private int PreviousCode;
        private static readonly log4net.ILog _MyLogControlEventos =
            log4net.LogManager.GetLogger("MyControlEventos");
        public FrmPolicy()
        {
            InitializeComponent();
        }
        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Policy Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOK(string Message)
        {
            MessageBox.Show(Message, "Policy Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadRole()
        {
            try
            {
                CboPlan.DataSource = BLLPlan.Read();
                CboPlan.ValueMember = "ID";
                CboPlan.DisplayMember = "Description";
            }
            catch (Exception ex)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }
        private void FrmPolicy_Load(object sender, EventArgs e)
        {
            this.LoadRole();
            this.Read();
            this.Limpiar();
        }

        private void Limpiar()
        {
            TxtCode.Clear();
            TxtDescription.Clear();
            CboPlan.SelectedIndex = -1;

            dgvPolicy.Columns[0].Visible = false;
            BtnUpdate.Visible = false;
            btnActivate.Visible = false;
            btnDeactivate.Visible = false;
            btnDelete.Visible = false;
            chkSelect.Checked = false;
            BtnInsert.Visible = true;
        }

        private void Read()
        {
            try
            {
                dgvPolicy.DataSource = BLLPolicy.Read();
                LblTotal.Text = "Total Policies: " + Convert.ToString(dgvPolicy.Rows.Count);
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string Response = "";
                if (TxtCode.Text == string.Empty || CboPlan.Text == string.Empty ||
                        TxtDescription.Text == string.Empty)
                {
                    this.MessageError("The information is not complete");
                    errorProvider1.SetError(TxtCode, "Enter an identification code");
                    errorProvider1.SetError(TxtDescription, "Enter the description");
                    errorProvider1.SetError(CboPlan, "Select a plan");
                }
                else
                {
                    Response = BLLPolicy.Insert(Convert.ToInt32(TxtCode.Text), TxtDescription.Text.Trim(), Convert.ToInt32(CboPlan.SelectedValue));
                    if (Response.Equals("OK"))
                    {
                        this.MessageOK("The policy was inserted successfully!");
                        this.Read();
                        this.Limpiar();
                    }
                    else
                    {
                        this.MessageError(Response);
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelect.Checked)
            {
                dgvPolicy.Columns[0].Visible = true;
                btnActivate.Visible = true;
                btnDeactivate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                dgvPolicy.Columns[0].Visible = false;
                btnActivate.Visible = false;
                btnDeactivate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void dgvPolicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPolicy.Columns["ColSelect"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dgvPolicy.Rows[e.RowIndex].Cells["ColSelect"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void dgvPolicy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnUpdate.Visible = true;
                BtnInsert.Visible = false;
                this.PreviousCode = Convert.ToInt32(dgvPolicy.CurrentRow.Cells["Code"].Value);
                TxtCode.Text = Convert.ToString(dgvPolicy.CurrentRow.Cells["Code"].Value);
                TxtDescription.Text = Convert.ToString(dgvPolicy.CurrentRow.Cells["Description"].Value);
                CboPlan.Text = Convert.ToString(dgvPolicy.CurrentRow.Cells["TypeOfPlan"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select the row to update. " + "| Error: " + ex.Message);
            }
        }
    }
}
