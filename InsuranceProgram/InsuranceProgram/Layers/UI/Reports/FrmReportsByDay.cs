﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceProgram.Layers.UI.Reports
{
    public partial class FrmReportsByDay : Form
    {
        public FrmReportsByDay()
        {
            InitializeComponent();
        }

        private void FrmReportsByDay_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
