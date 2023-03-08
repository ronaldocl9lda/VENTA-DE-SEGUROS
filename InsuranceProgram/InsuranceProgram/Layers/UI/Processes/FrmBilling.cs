using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using InsuranceProgram.Layers.BLL;
using InsuranceProgram.Layers.Persistence;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using log4net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceProgram.Layers.UI.Processes
{
    public partial class FrmBilling : Form
    {
        private DataTable DtDetail = new DataTable();
        private static readonly log4net.ILog _MyLogControlEventos =
            log4net.LogManager.GetLogger("MyControlEventos");

        //Signature
        public Image Firma;
        float PointX = 0;
        float PointY = 0;

        float LastX = 0;
        float LastY = 0;

        public FrmBilling()
        {
            InitializeComponent();
        }

        private void Format()
        {
            dgvBilling.Columns[0].Visible = false;
            dgvBilling.Columns[2].Width = 400;
            dgvDetails.Columns[0].Width = 200;
            dgvDetails.Columns[0].HeaderText = "Policy ID";
            dgvDetails.Columns[1].Width = 200;
            dgvDetails.Columns[1].HeaderText = "Coverage ID";
            dgvDetails.Columns[2].Width = 400;
            dgvDetails.Columns[2].HeaderText = "Coverage Description";
        }
        private void Limpiar()
        {
            TxtIDClient.Clear();
            TxtClientName.Clear();
            TxtSubtotal.Clear();
            TxtTotalTax.Clear();
            TxtTotalDollars.Clear();
            TxtIDPolicy.Clear();
            TxtPolicyDescription.Clear();
            errorProvider1.Clear();

            dgvBilling.Columns[0].Visible = false;
            btnCancel.Visible = false;
            chkSelect.Checked = false;
        }

        
        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOK(string Message)
        {
            MessageBox.Show(Message, "Billing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Read()
        {
            try
            {
                dgvBilling.DataSource = BLLBill.Read();
                LblTotal.Text = "Total Bills: " + Convert.ToString(dgvBilling.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            this.Read();
            this.CreateTable();
            this.GetTypeOfChange();
            BtnAddCoverage.Enabled = false;
            this.Format();
        }

        private void AddDetail(int PolicyId, string Description, decimal Amount, int CoverageId)
        {
            bool Add = true;

            foreach (DataRow row in DtDetail.Rows)
            {
                if (Convert.ToInt32(row["CoverageId"]) == CoverageId)
                {
                    Add = false;
                    MessageBox.Show("The Coverage has been already added");
                }
            }

            if (Add == true)
            {
                DataRow Row = DtDetail.NewRow();
                Row["PolicyId"] = PolicyId;
                Row["Description"] = Description;
                Row["Amount"] = Amount;
                Row["CoverageId"] = CoverageId;
                this.DtDetail.Rows.Add(Row);
                this.CalculateTotal();
            }
            
        }

        private void CalculateTotal()
        {
            decimal Total_Dollars = 0;
            decimal Total_Colones = 0;
            decimal Subtotal = 0;
            decimal TotalTax = 0;

            if (dgvDetails.Rows.Count == 0)
            {
                Subtotal = 0;
            }
            else
            {
                foreach (DataRow row in DtDetail.Rows)
                {
                    Subtotal += Convert.ToDecimal(row["Amount"]);
                }
            }

            TotalTax = Subtotal * (Convert.ToDecimal(BLL_IVA.GetIVA()) / 100);
            Total_Dollars = Subtotal + TotalTax;
            Total_Colones = Total_Dollars * (decimal)BCCR.GetTypeOfChange().venta;
            
            TxtSubtotal.Text = Subtotal.ToString("#0.00#");
            TxtTotalTax.Text = (Total_Dollars - Subtotal).ToString("#0.00#");
            TxtTotalDollars.Text = Total_Dollars.ToString("#0.00#");
            TxtTotalColones.Text = Total_Colones.ToString("#0.00#");
        }

        private void GetTypeOfChange()
        {
            LblDate.Text = Convert.ToString(BCCR.GetTypeOfChange().fecha);
            LblBuy.Text = Convert.ToString(BCCR.GetTypeOfChange().compra);
            LblSell.Text = Convert.ToString(BCCR.GetTypeOfChange().venta);
        }


        private void CreateTable()
        {
            this.DtDetail.Columns.Add("PolicyId", System.Type.GetType("System.Int32"));
            this.DtDetail.Columns.Add("CoverageId", System.Type.GetType("System.Int32"));
            this.DtDetail.Columns.Add("Description", System.Type.GetType("System.String"));
            this.DtDetail.Columns.Add("Amount", System.Type.GetType("System.Decimal"));

            dgvDetails.DataSource = this.DtDetail;

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvBilling.DataSource = BLLClient.Search(txtSearch.Text);
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
                dgvBilling.Columns[0].Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                dgvBilling.Columns[0].Visible = false;
                btnCancel.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private StringBuilder EmailBody()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nClient Name: " + Variables.ClientName);
            sb.Append("\nIdentification: " + Variables.ClientId);
            sb.Append("\n\n");
            sb.Append("\nPolicy Description: " + Variables.PolicyDescription);
            sb.Append("\nPolicy ID: " + Variables.PolicyID);
            sb.Append("\n\n");
            foreach(DataRow row in DtDetail.Rows)
            {
                sb.Append("\nCoverage ID: " + row["CoverageId"].ToString());
                sb.Append("\nCoverage Description: " + row["Description"].ToString());
                sb.Append("\nAmount: $" + row["Amount"].ToString());
                sb.Append("\n");
            }
            sb.Append("\nSubtotal: $" + TxtSubtotal.Text);
            sb.Append("\nTax: $" + TxtTotalTax.Text);
            sb.Append("\n\nTotal Dollars: $" + TxtTotalDollars.Text);
            sb.Append("\nTotal Colones: ₡" + TxtTotalColones.Text);

            return sb;
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Save Signature
                Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(bmp, panel1.Bounds);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] result = new byte[ms.Length];
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                ms.Read(result, 0, result.Length);

                //Save Identification Photo
                MemoryStream memoryStream = new MemoryStream();
                PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                string Response = "";
                string typeOfCard = "";
                if (TxtIDPolicy.Text == string.Empty || TxtIDClient.Text == string.Empty ||
                        dgvDetails.Rows.Count == 0 || (RdoVisa.Checked == false && RdoMasterCard.Checked == false && RdoAmericanExpress.Checked == false)
                    || TxtIdentificationFile.Text == string.Empty)
                {
                    this.MessageError("The information is not complete");
                    errorProvider1.SetError(BtnSearchClient, "Select a Client");
                    errorProvider1.SetError(BtnSearchPolicy, "Select a Policy");
                    errorProvider1.SetError(BtnAddCoverage, "Add a Coverage");
                    errorProvider1.SetError(RdoVisa, "Select a type of card");
                    errorProvider1.SetError(RdoMasterCard, "Select a type of card");
                    errorProvider1.SetError(RdoAmericanExpress, "Select a type of card");
                    errorProvider1.SetError(BtnUpload, "Upload the Client identification");
                }
                else
                {
                    if (RdoVisa.Checked)
                        typeOfCard = RdoVisa.Text;
                    if (RdoMasterCard.Checked)
                        typeOfCard = RdoMasterCard.Text;
                    if (RdoAmericanExpress.Checked)
                        typeOfCard = RdoAmericanExpress.Text;


                    EmailSender emailSender = new EmailSender();

                    Response = BLLBill.Insert(Variables.UserId, TxtIDClient.Text, typeOfCard,
                        Convert.ToDecimal(TxtTotalDollars.Text), Convert.ToDecimal(TxtTotalColones.Text),
                        DtDetail, memoryStream.GetBuffer(), ms.GetBuffer()) ;
                    if (Response.Equals("OK"))
                    {
                        this.MessageOK("The bill was inserted successfully!");
                        emailSender.SendEmail(this.EmailBody(), DateTime.Now, Variables.ClientEmail);
                        this.MessageOK("An email with the Bill has been sent to the Client");
                        this.Limpiar();
                        this.Read();
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

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Option;
                Option = MessageBox.Show("Do you really want to cancel this(these) Bill(s)?", "Bill Maintenance", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Option == DialogResult.OK)
                {
                    int Id;
                    string Response = "";

                    foreach (DataGridViewRow row in dgvBilling.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToInt32(row.Cells[1].Value);
                            Response = BLLBill.Cancel(Id);

                            if (Response.Equals("OK"))
                            {
                                this.MessageOK("The Bill: #" + Convert.ToString(row.Cells[1].Value) + " was cancelled!");

                            }
                            else
                            {
                                MessageBox.Show("We are only able to cancel bill that are made the same day");
                            }
                        }
                    }
                    this.Read();
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

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dgvBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBilling.Columns["ColSelect"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dgvBilling.Rows[e.RowIndex].Cells["ColSelect"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtIDClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
        {
            FrmSelectClient Frm = new FrmSelectClient();
            Frm.ShowDialog();
            TxtIDClient.Text = Variables.ClientId;
            TxtClientName.Text = Variables.ClientName;
        }

        private void TxtClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPolicyDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearchPolicy_Click(object sender, EventArgs e)
        {
            FrmSelectPolicy Frm = new FrmSelectPolicy();
            Frm.ShowDialog();
            TxtIDPolicy.Text = Convert.ToString(Variables.PolicyID);
            TxtPolicyDescription.Text = Variables.PolicyDescription;
            BtnAddCoverage.Enabled = true;
        }

        private void LoadPolicy()
        {
            
        }

        private void TxtIDPolicy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotalTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddCoverage_Click(object sender, EventArgs e)
        {
            FrmSelectCoverage Frm = new FrmSelectCoverage();
            Frm.ShowDialog();
            this.AddDetail(Variables.PolicyID, Variables.CoverageDescription, Variables.CoverageAmount, Variables.CoverageId);
        }

        private void dgvDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.CalculateTotal();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                PictureBox.Image = Image.FromFile(openFile.FileName);
                TxtIdentificationFile.Text = openFile.FileName;
            }
        }

        private void dgvBilling_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int BillID = Convert.ToInt32(dgvBilling.CurrentRow.Cells["Bill_ID"].Value);
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(BillID.ToString(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream memoryStream = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, memoryStream);

            var imageTemporal = new Bitmap(memoryStream);
            var ImageQR = new Bitmap(imageTemporal, new Size(new Point(200, 200)));

            PBqrCode.BackgroundImage = ImageQR;

            ImageQR.Save("image.png", ImageFormat.Png);
        }

        private void BtnSaveQR_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = (Image)PBqrCode.BackgroundImage.Clone();
                SaveFileDialog saveQR = new SaveFileDialog();
                saveQR.AddExtension = true;
                saveQR.Filter = "Image PNG (*.png)|*.png";
                saveQR.ShowDialog();

                if (!string.IsNullOrEmpty(saveQR.FileName))
                {
                    image.Save(saveQR.FileName, ImageFormat.Png);
                }

                image.Dispose();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = panel1.CreateGraphics();
            G.DrawLine(Pens.Black, PointX, PointY, LastX, LastY);
            LastX = PointX;
            LastY = PointY;
        }

        private void BtnSignature_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastX = e.X;
            LastY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointX = e.X;
                PointY = e.Y;
                panel1_Paint(this, null);
            }
        }
    }
}
