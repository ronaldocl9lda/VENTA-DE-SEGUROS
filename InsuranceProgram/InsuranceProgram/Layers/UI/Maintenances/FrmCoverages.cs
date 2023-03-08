using InsuranceProgram.Layers.BLL;
using System;
using System.Windows.Forms;
using log4net;
using System.Text;

namespace InsuranceProgram.Layers.UI.Maintenances
{
    public partial class FrmCoverages : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
            log4net.LogManager.GetLogger("MyControlEventos");
        public FrmCoverages()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            TxtId.Clear();
            TxtDescription.Clear();
            TxtMaxAmount.Clear();
            TxtGracePeriod.Clear();
            TxtPremium.Clear();
            TxtSumAssured.Clear();
            errorProvider1.Clear();
            TxtTotal.Clear();

            dgvBasicPlan.Columns[0].Visible = false;
            dgvPremium.Columns[0].Visible = false;
            dgvVoluntaryPlan.Columns[0].Visible = false;

            chkBasicPlan.Checked = false;
            chkPremiumPlan.Checked = false;
            chkVoluntaryPlan.Checked = false;

            dgvBasicPlan.Columns[0].Visible = false;
            BtnActivateCoverage.Visible = false;
            BtnDesactivateCoverage.Visible = false;
            //chkSelect.Checked = false;
        }

        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Coverages Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOK(string Message)
        {
            MessageBox.Show(Message, "Coverages Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmCoverages_Load(object sender, EventArgs e)
        {
            this.Read();
            this.Limpiar();
        }
        


        private void Read()
        {
            dgvBasicPlan.DataSource = BLLPlanCoverage.Read(1);
            dgvVoluntaryPlan.DataSource = BLLPlanCoverage.Read(2);
            dgvPremium.DataSource = BLLPlanCoverage.Read(3);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string Response = "";
                string Response2 = "";
                if (TxtId.Text == string.Empty ||
                        TxtDescription.Text == string.Empty || TxtGracePeriod.Text == string.Empty ||
                            TxtPremium.Text == string.Empty || TxtMaxAmount.Text == string.Empty ||
                                NUPEventsPerYear.Value == 0 || TxtTotal.Text == string.Empty)
                {
                    this.MessageError("The information is not complete");
                    errorProvider1.SetError(TxtId, "Enter a Coverage ID");
                    errorProvider1.SetError(TxtDescription, "Enter a description of the Coverage");
                    errorProvider1.SetError(TxtGracePeriod, "Enter a Grace Period");
                    errorProvider1.SetError(TxtPremium, "Enter a Premium value");
                    errorProvider1.SetError(TxtMaxAmount, "Enter a max amount per event");
                    errorProvider1.SetError(NUPEventsPerYear, "Enter the events per year");
                    errorProvider1.SetError(TxtTotal, "Enter the total amount");
                }
                else
                {
                    Response = BLLCoverages.Insert(Convert.ToInt32(TxtId.Text), TxtDescription.Text,
                        Decimal.Parse(TxtMaxAmount.Text), Convert.ToInt32(NUPEventsPerYear.Value),
                        Convert.ToInt32(TxtGracePeriod.Text), Decimal.Parse(TxtSumAssured.Text), 
                        Decimal.Parse(TxtPremium.Text), Decimal.Parse(TxtTotal.Text));

                    if (chkBasicPlan.Checked)
                        Response2 = BLLPlanCoverage.Insert(1, Convert.ToInt32(TxtId.Text));

                    if (chkVoluntaryPlan.Checked)
                        Response2 = BLLPlanCoverage.Insert(2, Convert.ToInt32(TxtId.Text));

                    if (chkPremiumPlan.Checked)
                        Response2 = BLLPlanCoverage.Insert(3, Convert.ToInt32(TxtId.Text));

                    if (Response.Equals("OK"))
                    {
                        this.MessageOK("The Coverage was inserted successfully!");
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
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvBasicPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBasicPlan.Columns["ColSelect"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dgvBasicPlan.Rows[e.RowIndex].Cells["ColSelect"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void TabGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvVoluntaryPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVoluntaryPlan.Columns["ColSelect"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dgvVoluntaryPlan.Rows[e.RowIndex].Cells["ColSelect"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void dgvPremium_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPremium.Columns["ColSelect"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dgvPremium.Rows[e.RowIndex].Cells["ColSelect"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void ChkSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSelectBasic.Checked)
            {
                dgvBasicPlan.Columns[0].Visible = true;
                BtnActivateCoverage.Visible = true;
                BtnDesactivateCoverage.Visible = true;
            }
            else
            {
                dgvBasicPlan.Columns[0].Visible = false;
                BtnActivateCoverage.Visible = false;
                BtnDesactivateCoverage.Visible = false;
            }
        }

        private void BtnActivateCoverage_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to active this(these) Coverage(s)?", "Coverage Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    int Id;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvBasicPlan.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToInt32(row.Cells[1].Value);
                            Response = BLLCoverages.Activate(Id);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The Coverage: " + Convert.ToString(row.Cells[2].Value) + " was activated successfully!");

                            }
                            else
                            {
                                this.MessageError(Response);
                            }
                        }
                    }
                    this.Read();
                }
            }
            catch (Exception ex)
            {
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }

        private void BtnDesactivate_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to desactivate this(these) Coverage(s)?", "Coverage Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    int Id;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvBasicPlan.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToInt32(row.Cells[1].Value);
                            Response = BLLCoverages.Deactivate(Id);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The Coverage: " + Convert.ToString(row.Cells[2].Value) + " was activated successfully!");

                            }
                            else
                            {
                                this.MessageError(Response);
                            }
                        }
                    }
                    this.Read();
                }
            }
            catch (Exception ex)
            {
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }
    }
}
