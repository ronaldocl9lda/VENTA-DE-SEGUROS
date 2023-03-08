using InsuranceProgram.Layers.UI.Maintenances;
using InsuranceProgram.Layers.UI.Processes;
using InsuranceProgram.Layers.UI.Reports;
using System;
using log4net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceProgram.Layers.Persistence;

namespace InsuranceProgram.Layers.UI
{
    public partial class FrmMain : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int childFormNumber = 0;
        public string UserId;
        public int RoleId;
        public string Name;
        public string Role;
        public bool Status;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = openFileDialog.FileName;
                }
            }
            catch(Exception ex)
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

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers frm = new FrmUsers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (Variables.UserRole == 1)
            {
                maintenancesToolStripMenuItem.Visible = true;
                usersToolStripMenuItem.Visible = true;
                processesToolStripMenuItem.Visible = true;
            }
            if (Variables.UserRole == 2)
            {
                usersToolStripMenuItem.Visible = false;
            }
            if (Variables.UserRole == 3)
            {
                maintenancesToolStripMenuItem.Visible = false;
                processesToolStripMenuItem.Visible = false;
            }

            MessageBox.Show("Welcome " + this.Name);
            LblUser.Text = "USER ONLINE: " + Name;
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmLogin Frm = new FrmLogin();
            Frm.ShowDialog();
        }

        private void iVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIVA frm = new FrmIVA();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClients frm = new FrmClients();
            frm.MdiParent = this;
            frm.Show();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void coveragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCoverages frm = new FrmCoverages();
            frm.MdiParent = this;
            frm.Show();
        }

        private void policyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPolicy frm = new FrmPolicy();
            frm.MdiParent = this;
            frm.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reportsByRangeOfDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportByRange Frm = new FrmReportByRange();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void reportClientBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportByIdentification Frm = new FrmReportByIdentification();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void salesByDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportsByDay Frm = new FrmReportsByDay();
            Frm.MdiParent = this;
            Frm.Show();
        }
    }
}
