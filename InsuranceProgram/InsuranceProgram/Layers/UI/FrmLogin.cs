using InsuranceProgram.Layers.BLL;
using InsuranceProgram.Layers.Persistence;
using InsuranceProgram.Layers.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace InsuranceProgram
{
    public partial class FrmLogin : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
            log4net.LogManager.GetLogger("MyControlEventos");
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataTable Table = new DataTable();
                Table = BLLUser.Login(TxtIdentification.Text, TxtPassword.Text);
                if (Table.Rows.Count <= 0)
                {
                    MessageBox.Show("The email or the Password are incorrect", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(Table.Rows[0][4]) == false)
                    {
                        MessageBox.Show("This User is not active", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FrmMain Frm = new FrmMain();
                        Frm.UserId = Table.Rows[0][0].ToString();
                        Variables.UserId = Table.Rows[0][0].ToString();
                        Frm.Name = Convert.ToString(Table.Rows[0][3]);
                        Frm.Status = Convert.ToBoolean(Table.Rows[0][4]);
                        Frm.RoleId = Convert.ToInt32(Table.Rows[0][1]);
                        Variables.UserRole = Frm.RoleId = Convert.ToInt32(Table.Rows[0][1]); 

                        Frm.Show();
                        this.Hide();
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
