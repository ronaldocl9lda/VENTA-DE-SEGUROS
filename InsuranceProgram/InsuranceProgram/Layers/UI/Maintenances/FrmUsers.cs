using InsuranceProgram.Layers.BLL;
using InsuranceProgram.Layers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using log4net;
using System.Windows.Forms;
using System.Text;

namespace InsuranceProgram.Layers.UI
{
    
    public partial class FrmUsers : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
            log4net.LogManager.GetLogger("MyControlEventos");
        private string PreviousUserId;
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            this.LoadRole();
            this.ToList();
            this.Format();
            dgvUsers.RowHeadersVisible = false;
        }

        private void Format()
        {
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[5].Visible = false;
            dgvUsers.Columns[2].Width = 300;
        }
        private void Limpiar()
        {
            TxtName.Clear();
            TxtIdentification.Clear();
            txtSearch.Clear();
            TxtPassword.Clear();
            TxtIdentification.Clear();
            errorProvider1.Clear();

            dgvUsers.Columns[0].Visible = false;
            BtnUpdate.Visible = false;
            btnActivate.Visible = false;
            btnDeactivate.Visible = false;
            btnDelete.Visible = false;
            chkSelect.Checked = false;

            PictureBox.Image.Dispose();
        }
        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Users Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOK(string Message)
        {
            MessageBox.Show(Message, "Users Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadRole()
        {
            try
            {
                CboRole.DataSource = BLLRole.Read();
                CboRole.ValueMember = "ID";
                CboRole.DisplayMember = "Role";
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

        private void ToList()
        {
            try
            {
                dgvUsers.DataSource = BLLUser.Read();
                //this.Limpiar();
                LblTotal.Text = "Total Users: " + Convert.ToString(dgvUsers.Rows.Count);
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
                dgvUsers.Columns[0].Visible = true;
                btnActivate.Visible = true;
                btnDeactivate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                dgvUsers.Columns[0].Visible = false;
                btnActivate.Visible = false;
                btnDeactivate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to active this(these) User(s)?", "Users Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    int Code;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvUsers.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Code = Convert.ToInt32(row.Cells[1].Value);
                            Response = BLLUser.Activate(Code);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The User: " + Convert.ToString(row.Cells[2].Value) + " was activated successfully!");
                                
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
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns["ColSelect"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dgvUsers.Rows[e.RowIndex].Cells["ColSelect"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnUpdate.Visible = true;
                BtnInsert.Visible = false;
                this.PreviousUserId = Convert.ToString(dgvUsers.CurrentRow.Cells["ID"].Value);
                TxtIdentification.Text = Convert.ToString(dgvUsers.CurrentRow.Cells["ID"].Value);
                TxtName.Text = Convert.ToString(dgvUsers.CurrentRow.Cells["Name"].Value);
                CboRole.Text = Convert.ToString(dgvUsers.CurrentRow.Cells["ID"].Value);

                byte[] image = (byte[]) dgvUsers.CurrentRow.Cells["Photo"].Value;
                MemoryStream memoryStream = new MemoryStream(image);
                PictureBox.Image = Image.FromStream(memoryStream);

                tabGeneral.SelectedIndex = 1;
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
                MemoryStream memoryStream = new MemoryStream();
                PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                string Response = "";
                if (TxtName.Text == string.Empty || CboRole.Text == string.Empty ||
                        TxtIdentification.Text == string.Empty || TxtPassword.Text == string.Empty)
                {
                    this.MessageError("The information is not complete");
                    errorProvider1.SetError(TxtName, "Enter a name");
                    errorProvider1.SetError(CboRole, "Choose a Role for this user");
                    errorProvider1.SetError(TxtIdentification, "Enter the ID");
                    errorProvider1.SetError(TxtPassword, "Enter a password");
                    errorProvider1.SetError(PictureBox, "Upload a photo");
                }
                else
                {
                    Response = BLLUser.Insert(TxtIdentification.Text.Trim(), Convert.ToInt32(CboRole.SelectedValue),
                        TxtName.Text.Trim(), TxtPassword.Text.Trim(), memoryStream.GetBuffer());
                    if (Response.Equals("OK"))
                    {
                        this.MessageOK("The user was inserted successfully!");
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
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            string Response = "";
            if (TxtName.Text == string.Empty || CboRole.Text == string.Empty ||
                    TxtIdentification.Text == string.Empty)
            {
                this.MessageError("The information is not complete");
                errorProvider1.SetError(TxtName, "Enter a name");
                errorProvider1.SetError(CboRole, "Choose a Role for this user");
                errorProvider1.SetError(TxtIdentification, "Enter the ID");
                errorProvider1.SetError(TxtPassword, "Enter a password");
                errorProvider1.SetError(PictureBox, "Upload a photo");
            }
            else
            {
                Response = BLLUser.Update(this.PreviousUserId, TxtIdentification.Text.Trim(), Convert.ToInt32(CboRole.SelectedValue),
                    TxtName.Text.Trim(), TxtPassword.Text.Trim(), memoryStream.GetBuffer());
                if (Response.Equals("OK"))
                {
                    this.MessageOK("The user was updated successfully!!");
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUsers.DataSource = BLLUser.Search(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to deactivate this(these) User(s)?", "Users Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    int Code;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvUsers.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Code = Convert.ToInt32(row.Cells[1].Value);
                            Response = BLLUser.Deactivate(Code);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The User: " + Convert.ToString(row.Cells[2].Value) + " was deactivated!");

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
                StringBuilder msg = new StringBuilder();

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
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to delete this(these) User(s)?", "Users Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    int Code;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvUsers.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Code = Convert.ToInt32(row.Cells[1].Value);
                            Response = BLLUser.Delete(Code);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The User: " + Convert.ToString(row.Cells[2].Value) + " was deleted!");

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
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Error(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneral.SelectedIndex = 0;
        }
    }
}
