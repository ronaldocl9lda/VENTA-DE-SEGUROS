
namespace InsuranceProgram.Layers.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coveragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsByRangeOfDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportClientBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesByDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripReports = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.LblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenancesToolStripMenuItem,
            this.processesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.folder1;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(206, 28);
            this.signOutToolStripMenuItem.Text = "&Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(206, 28);
            this.closeProgramToolStripMenuItem.Text = "Close Program";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // maintenancesToolStripMenuItem
            // 
            this.maintenancesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.iVAToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.coveragesToolStripMenuItem,
            this.policyToolStripMenuItem});
            this.maintenancesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenancesToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.Gear;
            this.maintenancesToolStripMenuItem.Name = "maintenancesToolStripMenuItem";
            this.maintenancesToolStripMenuItem.Size = new System.Drawing.Size(151, 27);
            this.maintenancesToolStripMenuItem.Text = "Maintenances";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.User;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.usersToolStripMenuItem.Text = "&Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // iVAToolStripMenuItem
            // 
            this.iVAToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.importe;
            this.iVAToolStripMenuItem.Name = "iVAToolStripMenuItem";
            this.iVAToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.iVAToolStripMenuItem.Text = "&IVA";
            this.iVAToolStripMenuItem.Click += new System.EventHandler(this.iVAToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.cliente_b;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.clientsToolStripMenuItem.Text = "&Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // coveragesToolStripMenuItem
            // 
            this.coveragesToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.Home;
            this.coveragesToolStripMenuItem.Name = "coveragesToolStripMenuItem";
            this.coveragesToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.coveragesToolStripMenuItem.Text = "Coverages";
            this.coveragesToolStripMenuItem.Click += new System.EventHandler(this.coveragesToolStripMenuItem_Click);
            // 
            // policyToolStripMenuItem
            // 
            this.policyToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.onebit_20;
            this.policyToolStripMenuItem.Name = "policyToolStripMenuItem";
            this.policyToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.policyToolStripMenuItem.Text = "Policy";
            this.policyToolStripMenuItem.Click += new System.EventHandler(this.policyToolStripMenuItem_Click);
            // 
            // processesToolStripMenuItem
            // 
            this.processesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billingToolStripMenuItem});
            this.processesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.productos_b;
            this.processesToolStripMenuItem.Name = "processesToolStripMenuItem";
            this.processesToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.processesToolStripMenuItem.Text = "&Processes";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.agregar;
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(140, 28);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsByRangeOfDatesToolStripMenuItem,
            this.reportClientBillsToolStripMenuItem,
            this.salesByDayToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.documento;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // reportsByRangeOfDatesToolStripMenuItem
            // 
            this.reportsByRangeOfDatesToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.comprasrealizadas;
            this.reportsByRangeOfDatesToolStripMenuItem.Name = "reportsByRangeOfDatesToolStripMenuItem";
            this.reportsByRangeOfDatesToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.reportsByRangeOfDatesToolStripMenuItem.Text = "Report Bills By Range of Dates";
            this.reportsByRangeOfDatesToolStripMenuItem.Click += new System.EventHandler(this.reportsByRangeOfDatesToolStripMenuItem_Click);
            // 
            // reportClientBillsToolStripMenuItem
            // 
            this.reportClientBillsToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.group_key;
            this.reportClientBillsToolStripMenuItem.Name = "reportClientBillsToolStripMenuItem";
            this.reportClientBillsToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.reportClientBillsToolStripMenuItem.Text = "Report Client Bills";
            this.reportClientBillsToolStripMenuItem.Click += new System.EventHandler(this.reportClientBillsToolStripMenuItem_Click);
            // 
            // salesByDayToolStripMenuItem
            // 
            this.salesByDayToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.ventasrealizadas;
            this.salesByDayToolStripMenuItem.Name = "salesByDayToolStripMenuItem";
            this.salesByDayToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.salesByDayToolStripMenuItem.Text = "Sales by Day";
            this.salesByDayToolStripMenuItem.Click += new System.EventHandler(this.salesByDayToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Image = global::InsuranceProgram.Properties.Resources.ayuda1;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripReports});
            this.toolStrip.Location = new System.Drawing.Point(0, 31);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(843, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripReports
            // 
            this.toolStripReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReports.Image = global::InsuranceProgram.Properties.Resources.Reporte_2;
            this.toolStripReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReports.Name = "toolStripReports";
            this.toolStripReports.Size = new System.Drawing.Size(29, 28);
            this.toolStripReports.Text = "toolStripButton1";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUser});
            this.statusStrip.Location = new System.Drawing.Point(0, 536);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // LblUser
            // 
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(0, 16);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InsuranceProgram.Properties.Resources.hands_of_medical_doctor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Insurance Program Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel LblUser;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem processesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripReports;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coveragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsByRangeOfDatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportClientBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesByDayToolStripMenuItem;
    }
}



