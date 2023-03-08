using InsuranceProgram.Layers.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceProgram.Layers.UI.Maintenances
{
    public partial class FrmBeneficiaries : Form
    {
        public static string IdClient;
        private DateTime date = new DateTime();
        public FrmBeneficiaries()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            TxtIdentification.Clear();
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtPhoneNumber.Clear();

            dgvBeneficiaries.Columns[0].Visible = false;
            BtnUpdate.Visible = false;
            btnDelete.Visible = false;
            chkSelect.Checked = false;
        }
        private void Format()
        {
            
        }

        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Beneficiary Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOK(string Message)
        {
            MessageBox.Show(Message, "Beneficiary Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToList()
        {
            try
            {
                FrmClients Frm = new FrmClients();
                dgvBeneficiaries.DataSource = BLLBeneficiary.Read(IdClient);
                LblTotal.Text = "Total Beneficiaries: " + Convert.ToString(dgvBeneficiaries.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmBeneficiaries_Load(object sender, EventArgs e)
        {
            this.ToList();
            this.Format();
            dgvBeneficiaries.RowHeadersVisible = false;
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelect.Checked)
            {
                dgvBeneficiaries.Columns[0].Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
            }
        }

        private void BtnInsertBeneficiary_Click(object sender, EventArgs e)
        {
            try
            {
                string Response = "";
                if (TxtIdentification.Text == string.Empty || TxtFirstName.Text == string.Empty ||
                        TxtLastName.Text == string.Empty || TxtPhoneNumber.Text == string.Empty)
                {
                    this.MessageError("The information is not complete");
                    errorProvider1.SetError(TxtFirstName, "Enter the First Name");
                    errorProvider1.SetError(TxtLastName, "Enter the Last Name");
                    errorProvider1.SetError(TxtIdentification, "Enter the ID");
                    errorProvider1.SetError(TxtPhoneNumber, "Enter a phone number");
                }
                else
                {
                    Response = BLLBeneficiary.Insert(TxtIdentification.Text.Trim(), TxtFirstName.Text.Trim(), TxtLastName.Text.Trim(),
                        IdClient, this.date, CboRelationship.Text, TxtPhoneNumber.Text.Trim());
                    if (Response.Equals("OK"))
                    {
                        this.MessageOK("The beneficiary was inserted successfully!");
                        this.ToList();
                        this.Limpiar();
                        tabGeneral.SelectedIndex = 0;
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

        private void DTPBirthday_ValueChanged(object sender, EventArgs e)
        {
            date = DTPBirthday.Value;
        }

        private void BtnUpdateBeneficiary_Click(object sender, EventArgs e)
        {
            string Response = "";
            if (TxtIdentification.Text == string.Empty || TxtFirstName.Text == string.Empty ||
                        TxtLastName.Text == string.Empty || TxtPhoneNumber.Text == string.Empty)
            {
                this.MessageError("The information is not complete");
                errorProvider1.SetError(TxtFirstName, "Enter the First Name");
                errorProvider1.SetError(TxtLastName, "Enter the Last Name");
                errorProvider1.SetError(TxtIdentification, "Enter the ID");
                errorProvider1.SetError(TxtPhoneNumber, "Enter a phone number");
            }
            else
            {
                Response = BLLBeneficiary.Update(TxtIdentification.Text.Trim(), TxtFirstName.Text.Trim(), TxtLastName.Text.Trim(),
                        IdClient, this.date, CboRelationship.Text, TxtPhoneNumber.Text.Trim());
                if (Response.Equals("OK"))
                {
                    this.MessageOK("The Client was updated successfully!!");
                    this.ToList();
                    this.Limpiar();
                    tabGeneral.SelectedIndex = 0;
                }
                else
                {
                    this.MessageError(Response);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to delete this(these) Beneficiary(s)?", "Beneficiary Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    string Id;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvBeneficiaries.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Response = BLLBeneficiary.Delete(Id);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The Beneficiary: " + Convert.ToString(row.Cells[2].Value) + " was deleted!");

                            }
                            else
                            {
                                this.MessageError(Response);
                            }
                        }
                    }
                    this.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneral.SelectedIndex = 0;
            this.ToList();
        }

        private void dgvBeneficiaries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBeneficiaries.Columns["ColSelect"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dgvBeneficiaries.Rows[e.RowIndex].Cells["ColSelect"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void dgvBeneficiaries_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnUpdate.Visible = true;
                BtnInsert.Visible = false;
                TxtIdentification.Text = Convert.ToString(dgvBeneficiaries.CurrentRow.Cells["ID"].Value);
                TxtFirstName.Text = Convert.ToString(dgvBeneficiaries.CurrentRow.Cells["FirstName"].Value);
                TxtLastName.Text = Convert.ToString(dgvBeneficiaries.CurrentRow.Cells["LastName"].Value);
                DTPBirthday.Value = Convert.ToDateTime(dgvBeneficiaries.CurrentRow.Cells["DateOfBirth"].Value);
                CboRelationship.Text = Convert.ToString(dgvBeneficiaries.CurrentRow.Cells["Relationship"].Value);
                TxtPhoneNumber.Text = Convert.ToString(dgvBeneficiaries.CurrentRow.Cells["PhoneNumber"].Value);

                tabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select the row to update. " + "| Error: " + ex.Message);
            }
        }
    }
}
