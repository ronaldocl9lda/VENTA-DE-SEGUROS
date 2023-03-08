
namespace InsuranceProgram.Layers.UI.Maintenances
{
    partial class FrmCoverages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkBasicPlan = new System.Windows.Forms.CheckBox();
            this.chkVoluntaryPlan = new System.Windows.Forms.CheckBox();
            this.chkPremiumPlan = new System.Windows.Forms.CheckBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtPremium = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtGracePeriod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtMaxAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSumAssured = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NUPEventsPerYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblTotal = new System.Windows.Forms.Label();
            this.ChkSelectBasic = new System.Windows.Forms.CheckBox();
            this.BtnActivateCoverage = new System.Windows.Forms.Button();
            this.dgvBasicPlan = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgvVoluntaryPlan = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dgvPremium = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnDesactivateCoverage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TabGeneral.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPEventsPerYear)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicPlan)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntaryPlan)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPremium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage4);
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Controls.Add(this.tabPage3);
            this.TabGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(20, 28);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(911, 472);
            this.TabGeneral.TabIndex = 0;
            this.TabGeneral.SelectedIndexChanged += new System.EventHandler(this.TabGeneral_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(903, 437);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add a new Coverage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.chkBasicPlan);
            this.groupBox1.Controls.Add(this.chkVoluntaryPlan);
            this.groupBox1.Controls.Add(this.chkPremiumPlan);
            this.groupBox1.Controls.Add(this.BtnCreate);
            this.groupBox1.Controls.Add(this.TxtPremium);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtGracePeriod);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtMaxAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtSumAssured);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NUPEventsPerYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Coverage";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(565, 298);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(267, 30);
            this.TxtTotal.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(441, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 18);
            this.label11.TabIndex = 38;
            this.label11.Text = "Total:";
            // 
            // chkBasicPlan
            // 
            this.chkBasicPlan.AutoSize = true;
            this.chkBasicPlan.Location = new System.Drawing.Point(161, 87);
            this.chkBasicPlan.Name = "chkBasicPlan";
            this.chkBasicPlan.Size = new System.Drawing.Size(136, 29);
            this.chkBasicPlan.TabIndex = 37;
            this.chkBasicPlan.Text = "Basic Plan";
            this.chkBasicPlan.UseVisualStyleBackColor = true;
            // 
            // chkVoluntaryPlan
            // 
            this.chkVoluntaryPlan.AutoSize = true;
            this.chkVoluntaryPlan.Location = new System.Drawing.Point(340, 87);
            this.chkVoluntaryPlan.Name = "chkVoluntaryPlan";
            this.chkVoluntaryPlan.Size = new System.Drawing.Size(175, 29);
            this.chkVoluntaryPlan.TabIndex = 36;
            this.chkVoluntaryPlan.Text = "Voluntary Plan";
            this.chkVoluntaryPlan.UseVisualStyleBackColor = true;
            // 
            // chkPremiumPlan
            // 
            this.chkPremiumPlan.AutoSize = true;
            this.chkPremiumPlan.Location = new System.Drawing.Point(550, 87);
            this.chkPremiumPlan.Name = "chkPremiumPlan";
            this.chkPremiumPlan.Size = new System.Drawing.Size(167, 29);
            this.chkPremiumPlan.TabIndex = 35;
            this.chkPremiumPlan.Text = "Premium Plan";
            this.chkPremiumPlan.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(335, 346);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(181, 38);
            this.BtnCreate.TabIndex = 34;
            this.BtnCreate.Text = "Create Coverage";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtPremium
            // 
            this.TxtPremium.Location = new System.Drawing.Point(565, 203);
            this.TxtPremium.Name = "TxtPremium";
            this.TxtPremium.Size = new System.Drawing.Size(267, 30);
            this.TxtPremium.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(441, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 32;
            this.label10.Text = "Premium";
            // 
            // TxtGracePeriod
            // 
            this.TxtGracePeriod.Location = new System.Drawing.Point(565, 151);
            this.TxtGracePeriod.Multiline = true;
            this.TxtGracePeriod.Name = "TxtGracePeriod";
            this.TxtGracePeriod.Size = new System.Drawing.Size(267, 34);
            this.TxtGracePeriod.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Grace Period";
            // 
            // TxtMaxAmount
            // 
            this.TxtMaxAmount.Location = new System.Drawing.Point(155, 243);
            this.TxtMaxAmount.Name = "TxtMaxAmount";
            this.TxtMaxAmount.Size = new System.Drawing.Size(267, 30);
            this.TxtMaxAmount.TabIndex = 29;
            this.TxtMaxAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Max Amount";
            // 
            // TxtSumAssured
            // 
            this.TxtSumAssured.Location = new System.Drawing.Point(565, 248);
            this.TxtSumAssured.Name = "TxtSumAssured";
            this.TxtSumAssured.Size = new System.Drawing.Size(267, 30);
            this.TxtSumAssured.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sum Assured";
            // 
            // NUPEventsPerYear
            // 
            this.NUPEventsPerYear.Location = new System.Drawing.Point(178, 302);
            this.NUPEventsPerYear.Name = "NUPEventsPerYear";
            this.NUPEventsPerYear.Size = new System.Drawing.Size(120, 30);
            this.NUPEventsPerYear.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Events Per Year";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(155, 151);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(267, 57);
            this.TxtDescription.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 21;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(335, 29);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(207, 30);
            this.TxtId.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.BtnDesactivateCoverage);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.ChkSelectBasic);
            this.tabPage1.Controls.Add(this.BtnActivateCoverage);
            this.tabPage1.Controls.Add(this.dgvBasicPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Plan";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(679, 381);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(56, 24);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total";
            // 
            // ChkSelectBasic
            // 
            this.ChkSelectBasic.AutoSize = true;
            this.ChkSelectBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSelectBasic.Location = new System.Drawing.Point(39, 385);
            this.ChkSelectBasic.Name = "ChkSelectBasic";
            this.ChkSelectBasic.Size = new System.Drawing.Size(84, 24);
            this.ChkSelectBasic.TabIndex = 4;
            this.ChkSelectBasic.Text = "Select";
            this.ChkSelectBasic.UseVisualStyleBackColor = true;
            this.ChkSelectBasic.CheckedChanged += new System.EventHandler(this.ChkSelect_CheckedChanged);
            // 
            // BtnActivateCoverage
            // 
            this.BtnActivateCoverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActivateCoverage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActivateCoverage.Location = new System.Drawing.Point(193, 370);
            this.BtnActivateCoverage.Name = "BtnActivateCoverage";
            this.BtnActivateCoverage.Size = new System.Drawing.Size(207, 45);
            this.BtnActivateCoverage.TabIndex = 3;
            this.BtnActivateCoverage.Text = "Activate";
            this.BtnActivateCoverage.UseVisualStyleBackColor = true;
            this.BtnActivateCoverage.Click += new System.EventHandler(this.BtnActivateCoverage_Click);
            // 
            // dgvBasicPlan
            // 
            this.dgvBasicPlan.AllowUserToAddRows = false;
            this.dgvBasicPlan.AllowUserToDeleteRows = false;
            this.dgvBasicPlan.AllowUserToOrderColumns = true;
            this.dgvBasicPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasicPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect});
            this.dgvBasicPlan.Location = new System.Drawing.Point(22, 53);
            this.dgvBasicPlan.Name = "dgvBasicPlan";
            this.dgvBasicPlan.ReadOnly = true;
            this.dgvBasicPlan.RowHeadersWidth = 51;
            this.dgvBasicPlan.RowTemplate.Height = 24;
            this.dgvBasicPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBasicPlan.Size = new System.Drawing.Size(859, 306);
            this.dgvBasicPlan.TabIndex = 1;
            this.dgvBasicPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasicPlan_CellContentClick);
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.MinimumWidth = 6;
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.ReadOnly = true;
            this.ColSelect.Visible = false;
            this.ColSelect.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.dgvVoluntaryPlan);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(903, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Voluntary Plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(62, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 28);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Select";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgvVoluntaryPlan
            // 
            this.dgvVoluntaryPlan.AllowUserToAddRows = false;
            this.dgvVoluntaryPlan.AllowUserToDeleteRows = false;
            this.dgvVoluntaryPlan.AllowUserToOrderColumns = true;
            this.dgvVoluntaryPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoluntaryPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dgvVoluntaryPlan.Location = new System.Drawing.Point(23, 53);
            this.dgvVoluntaryPlan.Name = "dgvVoluntaryPlan";
            this.dgvVoluntaryPlan.ReadOnly = true;
            this.dgvVoluntaryPlan.RowHeadersWidth = 51;
            this.dgvVoluntaryPlan.RowTemplate.Height = 24;
            this.dgvVoluntaryPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoluntaryPlan.Size = new System.Drawing.Size(856, 305);
            this.dgvVoluntaryPlan.TabIndex = 2;
            this.dgvVoluntaryPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoluntaryPlan_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.dgvPremium);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(903, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Premium Plan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(48, 384);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 28);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Select";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dgvPremium
            // 
            this.dgvPremium.AllowUserToAddRows = false;
            this.dgvPremium.AllowUserToDeleteRows = false;
            this.dgvPremium.AllowUserToOrderColumns = true;
            this.dgvPremium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPremium.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2});
            this.dgvPremium.Location = new System.Drawing.Point(19, 53);
            this.dgvPremium.Name = "dgvPremium";
            this.dgvPremium.ReadOnly = true;
            this.dgvPremium.RowHeadersWidth = 51;
            this.dgvPremium.RowTemplate.Height = 24;
            this.dgvPremium.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPremium.Size = new System.Drawing.Size(864, 303);
            this.dgvPremium.TabIndex = 2;
            this.dgvPremium.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPremium_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnDesactivateCoverage
            // 
            this.BtnDesactivateCoverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesactivateCoverage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesactivateCoverage.Location = new System.Drawing.Point(423, 370);
            this.BtnDesactivateCoverage.Name = "BtnDesactivateCoverage";
            this.BtnDesactivateCoverage.Size = new System.Drawing.Size(207, 45);
            this.BtnDesactivateCoverage.TabIndex = 6;
            this.BtnDesactivateCoverage.Text = "Desactivate";
            this.BtnDesactivateCoverage.UseVisualStyleBackColor = true;
            this.BtnDesactivateCoverage.Click += new System.EventHandler(this.BtnDesactivate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(449, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Desactivate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(219, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Activate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(410, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Desactivate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(180, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 45);
            this.button4.TabIndex = 10;
            this.button4.Text = "Activate";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmCoverages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::InsuranceProgram.Properties.Resources._8251_jpg_wh860;
            this.ClientSize = new System.Drawing.Size(943, 506);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmCoverages";
            this.Text = "Plan";
            this.Load += new System.EventHandler(this.FrmCoverages_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPEventsPerYear)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicPlan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntaryPlan)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPremium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox ChkSelectBasic;
        private System.Windows.Forms.Button BtnActivateCoverage;
        private System.Windows.Forms.DataGridView dgvBasicPlan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridView dgvVoluntaryPlan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dgvPremium;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPremium;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtGracePeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMaxAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSumAssured;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUPEventsPerYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chkBasicPlan;
        private System.Windows.Forms.CheckBox chkVoluntaryPlan;
        private System.Windows.Forms.CheckBox chkPremiumPlan;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnDesactivateCoverage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}