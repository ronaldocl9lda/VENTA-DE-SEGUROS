using InsuranceProgram.Layers.BLL;
using InsuranceProgram.Layers.DAL;
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
    public partial class FrmIVA : Form
    {
        public FrmIVA()
        {
            InitializeComponent();
        }

        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "IVA Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOK(string Message)
        {
            MessageBox.Show(Message, "IVA Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmIVA_Load(object sender, EventArgs e)
        {
            TxtIVA.Text = BLL_IVA.GetIVA().ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string Response = "";
            if (TxtIVA.Text == string.Empty)
            {
                this.MessageError("The information is not complete");
                errorProvider1.SetError(TxtIVA, "Enter the new value");
            }
            else
            {
                Response = BLL_IVA.Update(float.Parse(TxtIVA.Text));
                if (Response.Equals("OK"))
                {
                    this.MessageOK("The IVA was updated successfully!!");
                }
                else
                {
                    this.MessageError(Response);
                }
            }
        }
    }
}
