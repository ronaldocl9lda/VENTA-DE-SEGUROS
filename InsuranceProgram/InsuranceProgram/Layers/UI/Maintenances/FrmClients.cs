using InsuranceProgram.Layers.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace InsuranceProgram.Layers.UI.Maintenances
{
    public partial class FrmClients : Form
    {

        private static readonly log4net.ILog _MyLogControlEventos =
            log4net.LogManager.GetLogger("MyControlEventos");


        private DateTime date = new DateTime();
        private string PreviousId;
        
        public FrmClients()
        {
            InitializeComponent();
        }

        private void DTPBirthday_ValueChanged(object sender, EventArgs e)
        {
            date = DTPBirthday.Value;
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            this.LoadCountries();
            this.ToList();
            this.Format();
            dgvClients.RowHeadersVisible = false;
        }

        private void Format()
        {
            dgvClients.Columns[9].Visible = false;
            //dgvClients.Columns[5].Visible = false;
            //dgvClients.Columns[2].Width = 300;
        }
        private void Limpiar()
        {
            TxtIdentification.Clear();
            TxtFirstName.Clear();
            TxtLastName.Clear();
            txtSearch.Clear();
            TxtAddress.Clear();
            TxtPhoneNumber.Clear();
            errorProvider1.Clear();
            PictureBox.Image.Dispose();
            TxtEmail.Clear();
            BtnBeneficiary.Visible = false;

            dgvClients.Columns[0].Visible = false;
            BtnUpdate.Visible = false;
            btnActivate.Visible = false;
            btnDeactivate.Visible = false;
            btnDelete.Visible = false;
            chkSelect.Checked = false;
        }
        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Clients Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOK(string Message)
        {
            MessageBox.Show(Message, "Clients Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadCountries()
        {
            try
            {
                CboNationality.DataSource = BLLCountries.Read();
                CboNationality.ValueMember = "id";
                CboNationality.DisplayMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ToList()
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

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                string Response = "";
                if (TxtIdentification.Text == string.Empty || CboGender.Text == string.Empty ||
                        TxtFirstName.Text == string.Empty || TxtLastName.Text == string.Empty ||
                            CboNationality.Text == string.Empty || TxtAddress.Text == string.Empty || 
                                TxtPhoneNumber.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    this.MessageError("The information is not complete");
                    errorProvider1.SetError(TxtIdentification, "Enter a number of Identification");
                    errorProvider1.SetError(TxtFirstName, "Enter the first name");
                    errorProvider1.SetError(TxtLastName, "Enter the last name");
                    errorProvider1.SetError(CboGender, "Select a gender");
                    errorProvider1.SetError(CboNationality, "Select a nationality");
                    errorProvider1.SetError(TxtPhoneNumber, "Enter a phone number");
                    errorProvider1.SetError(TxtAddress, "Enter an address");
                    errorProvider1.SetError(PictureBox, "Upload a photo");
                    errorProvider1.SetError(TxtEmail, "Enter an email");
                }
                else
                {
                    Response = BLLClient.Insert(TxtIdentification.Text.Trim(), TxtFirstName.Text.Trim(), TxtLastName.Text.Trim(),
                        Convert.ToInt32(CboNationality.SelectedValue), CboGender.Text, this.date, 
                            TxtPhoneNumber.Text.Trim(), memoryStream.GetBuffer(), TxtAddress.Text, TxtEmail.Text.Trim());
                    if (Response.Equals("OK"))
                    {
                        this.MessageOK("The client was inserted successfully!");
                        this.ToList();
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
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n"+ ex.Message, "Error");
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                PictureBox.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneral.SelectedIndex = 0;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            string Response = "";
            if (TxtIdentification.Text == string.Empty || CboGender.Text == string.Empty ||
                        TxtFirstName.Text == string.Empty || TxtLastName.Text == string.Empty ||
                            CboNationality.Text == string.Empty || TxtAddress.Text == string.Empty ||
                                TxtPhoneNumber.Text == string.Empty || TxtEmail.Text == string.Empty)
            {
                this.MessageError("The information is not complete");
                errorProvider1.SetError(TxtIdentification, "Enter a number of Identification");
                errorProvider1.SetError(TxtFirstName, "Enter the first name");
                errorProvider1.SetError(TxtLastName, "Enter the last name");
                errorProvider1.SetError(CboGender, "Select a gender");
                errorProvider1.SetError(CboNationality, "Select a nationality");
                errorProvider1.SetError(TxtPhoneNumber, "Enter a phone number");
                errorProvider1.SetError(TxtAddress, "Enter an address");
                errorProvider1.SetError(PictureBox, "Upload a photo");
                errorProvider1.SetError(TxtEmail, "Enter an email");
            }
            else
            {
                Response = BLLClient.Update(this.PreviousId, TxtIdentification.Text.Trim(), TxtFirstName.Text.Trim(), TxtLastName.Text.Trim(),
                        Convert.ToInt32(CboNationality.SelectedValue), CboGender.Text, this.date,
                            TxtPhoneNumber.Text.Trim(), memoryStream.GetBuffer(), TxtAddress.Text, TxtEmail.Text.Trim());
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

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClients.Columns["ColSelect"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dgvClients.Rows[e.RowIndex].Cells["ColSelect"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                this.Limpiar();
                BtnUpdate.Visible = true;
                BtnInsert.Visible = false;
                this.PreviousId = Convert.ToString(dgvClients.CurrentRow.Cells["Identification"].Value);
                TxtIdentification.Text = Convert.ToString(dgvClients.CurrentRow.Cells["Identification"].Value);
                TxtFirstName.Text = Convert.ToString(dgvClients.CurrentRow.Cells["FirstName"].Value);
                TxtLastName.Text = Convert.ToString(dgvClients.CurrentRow.Cells["LastName"].Value);
                CboGender.Text = Convert.ToString(dgvClients.CurrentRow.Cells["Gender"].Value);
                DTPBirthday.Value = Convert.ToDateTime(dgvClients.CurrentRow.Cells["DateBirth"].Value);
                TxtPhoneNumber.Text = Convert.ToString(dgvClients.CurrentRow.Cells["PhoneNumber"].Value);
                TxtAddress.Text = Convert.ToString(dgvClients.CurrentRow.Cells["Address"].Value);
                TxtEmail.Text = Convert.ToString(dgvClients.CurrentRow.Cells["Email"].Value);
                CboNationality.Text = Convert.ToString(dgvClients.CurrentRow.Cells["Nationality"].Value);
                FrmBeneficiaries.IdClient = Convert.ToString(dgvClients.CurrentRow.Cells["Identification"].Value);

                byte[] image = (byte[])dgvClients.CurrentRow.Cells["Photo"].Value;
                MemoryStream memoryStream = new MemoryStream(image);
                PictureBox.Image = Image.FromStream(memoryStream);
                BtnBeneficiary.Visible = true;
                tabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");

                MessageBox.Show("Please select the row to update. " + "| Error: " + ex.Message);
            }
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

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelect.Checked)
            {
                dgvClients.Columns[0].Visible = true;
                btnActivate.Visible = true;
                btnDeactivate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                dgvClients.Columns[0].Visible = false;
                btnActivate.Visible = false;
                btnDeactivate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to active this(these) Client(s)?", "Clients Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    string Id;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvClients.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Response = BLLClient.Activate(Id);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The Client: " + Convert.ToString(row.Cells[2].Value) + " was activated successfully!");

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
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to deactivate this(these) Client(s)?", "Client Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    string Id;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvClients.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Response = BLLClient.Deactivate(Id);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The Client: " + Convert.ToString(row.Cells[2].Value) + " was deactivated!");

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
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to delete this(these) Client(s)?", "Users Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    string Id;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvClients.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Response = BLLClient.Delete(Id);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The Client: " + Convert.ToString(row.Cells[2].Value) + " was deleted!");

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
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }

        private void BtnBeneficiary_Click(object sender, EventArgs e)
        {
            FrmBeneficiaries frm = new FrmBeneficiaries();
            frm.ShowDialog();
        }
    }
}
