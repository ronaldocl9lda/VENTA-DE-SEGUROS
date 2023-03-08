
namespace InsuranceProgram.Layers.UI.Processes
{
    partial class FrmBilling
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoAmericanExpress = new System.Windows.Forms.RadioButton();
            this.RdoMasterCard = new System.Windows.Forms.RadioButton();
            this.RdoVisa = new System.Windows.Forms.RadioButton();
            this.TxtClientName = new System.Windows.Forms.TextBox();
            this.BtnSearchClient = new System.Windows.Forms.Button();
            this.TxtIDClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnSaveQR = new System.Windows.Forms.Button();
            this.PBqrCode = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblSell = new System.Windows.Forms.Label();
            this.LblBuy = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTotalColones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.TxtIdentificationFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAddCoverage = new System.Windows.Forms.Button();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtTotalTax = new System.Windows.Forms.TextBox();
            this.TxtTotalDollars = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.TxtPolicyDescription = new System.Windows.Forms.TextBox();
            this.BtnSearchPolicy = new System.Windows.Forms.Button();
            this.TxtIDPolicy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBqrCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(367, 556);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(147, 36);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(153, 556);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(147, 36);
            this.BtnCreate.TabIndex = 5;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.RdoAmericanExpress);
            this.groupBox1.Controls.Add(this.RdoMasterCard);
            this.groupBox1.Controls.Add(this.RdoVisa);
            this.groupBox1.Controls.Add(this.TxtClientName);
            this.groupBox1.Controls.Add(this.BtnSearchClient);
            this.groupBox1.Controls.Add(this.TxtIDClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(875, 121);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Header";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RdoAmericanExpress
            // 
            this.RdoAmericanExpress.AutoSize = true;
            this.RdoAmericanExpress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RdoAmericanExpress.Location = new System.Drawing.Point(489, 84);
            this.RdoAmericanExpress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdoAmericanExpress.Name = "RdoAmericanExpress";
            this.RdoAmericanExpress.Size = new System.Drawing.Size(202, 28);
            this.RdoAmericanExpress.TabIndex = 6;
            this.RdoAmericanExpress.TabStop = true;
            this.RdoAmericanExpress.Text = "American Express";
            this.RdoAmericanExpress.UseVisualStyleBackColor = true;
            // 
            // RdoMasterCard
            // 
            this.RdoMasterCard.AutoSize = true;
            this.RdoMasterCard.Location = new System.Drawing.Point(276, 84);
            this.RdoMasterCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdoMasterCard.Name = "RdoMasterCard";
            this.RdoMasterCard.Size = new System.Drawing.Size(143, 28);
            this.RdoMasterCard.TabIndex = 5;
            this.RdoMasterCard.TabStop = true;
            this.RdoMasterCard.Text = "Master Card";
            this.RdoMasterCard.UseVisualStyleBackColor = true;
            // 
            // RdoVisa
            // 
            this.RdoVisa.AutoSize = true;
            this.RdoVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RdoVisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RdoVisa.Location = new System.Drawing.Point(83, 84);
            this.RdoVisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdoVisa.Name = "RdoVisa";
            this.RdoVisa.Size = new System.Drawing.Size(71, 28);
            this.RdoVisa.TabIndex = 4;
            this.RdoVisa.TabStop = true;
            this.RdoVisa.Text = "Visa";
            this.RdoVisa.UseVisualStyleBackColor = true;
            // 
            // TxtClientName
            // 
            this.TxtClientName.Enabled = false;
            this.TxtClientName.Location = new System.Drawing.Point(329, 33);
            this.TxtClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtClientName.Name = "TxtClientName";
            this.TxtClientName.Size = new System.Drawing.Size(371, 28);
            this.TxtClientName.TabIndex = 3;
            this.TxtClientName.TextChanged += new System.EventHandler(this.TxtClientName_TextChanged);
            // 
            // BtnSearchClient
            // 
            this.BtnSearchClient.Location = new System.Drawing.Point(720, 32);
            this.BtnSearchClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSearchClient.Name = "BtnSearchClient";
            this.BtnSearchClient.Size = new System.Drawing.Size(107, 28);
            this.BtnSearchClient.TabIndex = 2;
            this.BtnSearchClient.Text = "Search";
            this.BtnSearchClient.UseVisualStyleBackColor = true;
            this.BtnSearchClient.Click += new System.EventHandler(this.BtnSearchClient_Click);
            // 
            // TxtIDClient
            // 
            this.TxtIDClient.Enabled = false;
            this.TxtIDClient.Location = new System.Drawing.Point(115, 33);
            this.TxtIDClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtIDClient.Name = "TxtIDClient";
            this.TxtIDClient.Size = new System.Drawing.Size(180, 28);
            this.TxtIDClient.TabIndex = 1;
            this.TxtIDClient.TextChanged += new System.EventHandler(this.TxtIDClient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGeneral.Location = new System.Drawing.Point(11, 10);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1208, 636);
            this.tabGeneral.TabIndex = 4;
            this.tabGeneral.SelectedIndexChanged += new System.EventHandler(this.tabGeneral_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.BtnSaveQR);
            this.tabPage1.Controls.Add(this.PBqrCode);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.chkSelect);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.dgvBilling);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1200, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bills";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // BtnSaveQR
            // 
            this.BtnSaveQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveQR.Location = new System.Drawing.Point(704, 484);
            this.BtnSaveQR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSaveQR.Name = "BtnSaveQR";
            this.BtnSaveQR.Size = new System.Drawing.Size(189, 65);
            this.BtnSaveQR.TabIndex = 8;
            this.BtnSaveQR.Text = "Save QR";
            this.BtnSaveQR.UseVisualStyleBackColor = true;
            this.BtnSaveQR.Click += new System.EventHandler(this.BtnSaveQR_Click);
            // 
            // PBqrCode
            // 
            this.PBqrCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBqrCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBqrCode.Location = new System.Drawing.Point(928, 425);
            this.PBqrCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PBqrCode.Name = "PBqrCode";
            this.PBqrCode.Size = new System.Drawing.Size(248, 168);
            this.PBqrCode.TabIndex = 7;
            this.PBqrCode.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(275, 484);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(189, 65);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelect.Location = new System.Drawing.Point(36, 442);
            this.chkSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(90, 28);
            this.chkSelect.TabIndex = 4;
            this.chkSelect.Text = "Select";
            this.chkSelect.UseVisualStyleBackColor = true;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(581, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(33, 563);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(56, 24);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total";
            this.LblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AllowUserToDeleteRows = false;
            this.dgvBilling.AllowUserToOrderColumns = true;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect});
            this.dgvBilling.Location = new System.Drawing.Point(16, 63);
            this.dgvBilling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.ReadOnly = true;
            this.dgvBilling.RowHeadersWidth = 51;
            this.dgvBilling.RowTemplate.Height = 24;
            this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBilling.Size = new System.Drawing.Size(1160, 354);
            this.dgvBilling.TabIndex = 0;
            this.dgvBilling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBilling_CellContentClick);
            this.dgvBilling.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBilling_CellDoubleClick);
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
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnCreate);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1200, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maintenance";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LblDate);
            this.groupBox3.Controls.Add(this.LblSell);
            this.groupBox3.Controls.Add(this.LblBuy);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(919, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(265, 121);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type Of Change";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "DATE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "BUY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "SELL";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(123, 33);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(0, 20);
            this.LblDate.TabIndex = 3;
            // 
            // LblSell
            // 
            this.LblSell.AutoSize = true;
            this.LblSell.Location = new System.Drawing.Point(123, 87);
            this.LblSell.Name = "LblSell";
            this.LblSell.Size = new System.Drawing.Size(0, 20);
            this.LblSell.TabIndex = 2;
            // 
            // LblBuy
            // 
            this.LblBuy.AutoSize = true;
            this.LblBuy.Location = new System.Drawing.Point(123, 60);
            this.LblBuy.Name = "LblBuy";
            this.LblBuy.Size = new System.Drawing.Size(0, 20);
            this.LblBuy.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.TxtTotalColones);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PictureBox);
            this.groupBox2.Controls.Add(this.BtnUpload);
            this.groupBox2.Controls.Add(this.TxtIdentificationFile);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnAddCoverage);
            this.groupBox2.Controls.Add(this.TxtSubtotal);
            this.groupBox2.Controls.Add(this.TxtTotalTax);
            this.groupBox2.Controls.Add(this.TxtTotalDollars);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvDetails);
            this.groupBox2.Controls.Add(this.TxtPolicyDescription);
            this.groupBox2.Controls.Add(this.BtnSearchPolicy);
            this.groupBox2.Controls.Add(this.TxtIDPolicy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1125, 392);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TxtTotalColones
            // 
            this.TxtTotalColones.Enabled = false;
            this.TxtTotalColones.Location = new System.Drawing.Point(926, 343);
            this.TxtTotalColones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTotalColones.Name = "TxtTotalColones";
            this.TxtTotalColones.Size = new System.Drawing.Size(180, 28);
            this.TxtTotalColones.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(769, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Colones";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(569, 350);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(116, 28);
            this.PictureBox.TabIndex = 19;
            this.PictureBox.TabStop = false;
            this.PictureBox.Visible = false;
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(456, 350);
            this.BtnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(90, 28);
            this.BtnUpload.TabIndex = 18;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // TxtIdentificationFile
            // 
            this.TxtIdentificationFile.Enabled = false;
            this.TxtIdentificationFile.Location = new System.Drawing.Point(230, 350);
            this.TxtIdentificationFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtIdentificationFile.Name = "TxtIdentificationFile";
            this.TxtIdentificationFile.Size = new System.Drawing.Size(211, 28);
            this.TxtIdentificationFile.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Identification File";
            // 
            // BtnAddCoverage
            // 
            this.BtnAddCoverage.Location = new System.Drawing.Point(41, 236);
            this.BtnAddCoverage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddCoverage.Name = "BtnAddCoverage";
            this.BtnAddCoverage.Size = new System.Drawing.Size(188, 38);
            this.BtnAddCoverage.TabIndex = 15;
            this.BtnAddCoverage.Text = "Add Coverage";
            this.BtnAddCoverage.UseVisualStyleBackColor = true;
            this.BtnAddCoverage.Click += new System.EventHandler(this.BtnAddCoverage_Click);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Location = new System.Drawing.Point(926, 242);
            this.TxtSubtotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(180, 28);
            this.TxtSubtotal.TabIndex = 14;
            this.TxtSubtotal.TextChanged += new System.EventHandler(this.TxtSubtotal_TextChanged);
            // 
            // TxtTotalTax
            // 
            this.TxtTotalTax.Enabled = false;
            this.TxtTotalTax.Location = new System.Drawing.Point(926, 276);
            this.TxtTotalTax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTotalTax.Name = "TxtTotalTax";
            this.TxtTotalTax.Size = new System.Drawing.Size(180, 28);
            this.TxtTotalTax.TabIndex = 13;
            this.TxtTotalTax.TextChanged += new System.EventHandler(this.TxtTotalTax_TextChanged);
            // 
            // TxtTotalDollars
            // 
            this.TxtTotalDollars.Enabled = false;
            this.TxtTotalDollars.Location = new System.Drawing.Point(926, 308);
            this.TxtTotalDollars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTotalDollars.Name = "TxtTotalDollars";
            this.TxtTotalDollars.Size = new System.Drawing.Size(180, 28);
            this.TxtTotalDollars.TabIndex = 12;
            this.TxtTotalDollars.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subtotal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Tax";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Dollars";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(41, 97);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(1065, 132);
            this.dgvDetails.TabIndex = 8;
            this.dgvDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            this.dgvDetails.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetails_RowsRemoved);
            // 
            // TxtPolicyDescription
            // 
            this.TxtPolicyDescription.Enabled = false;
            this.TxtPolicyDescription.Location = new System.Drawing.Point(329, 42);
            this.TxtPolicyDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPolicyDescription.Name = "TxtPolicyDescription";
            this.TxtPolicyDescription.Size = new System.Drawing.Size(591, 28);
            this.TxtPolicyDescription.TabIndex = 7;
            this.TxtPolicyDescription.TextChanged += new System.EventHandler(this.TxtPolicyDescription_TextChanged);
            // 
            // BtnSearchPolicy
            // 
            this.BtnSearchPolicy.Location = new System.Drawing.Point(943, 44);
            this.BtnSearchPolicy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSearchPolicy.Name = "BtnSearchPolicy";
            this.BtnSearchPolicy.Size = new System.Drawing.Size(107, 28);
            this.BtnSearchPolicy.TabIndex = 6;
            this.BtnSearchPolicy.Text = "Search";
            this.BtnSearchPolicy.UseVisualStyleBackColor = true;
            this.BtnSearchPolicy.Click += new System.EventHandler(this.BtnSearchPolicy_Click);
            // 
            // TxtIDPolicy
            // 
            this.TxtIDPolicy.Enabled = false;
            this.TxtIDPolicy.Location = new System.Drawing.Point(115, 42);
            this.TxtIDPolicy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtIDPolicy.Name = "TxtIDPolicy";
            this.TxtIDPolicy.Size = new System.Drawing.Size(180, 28);
            this.TxtIDPolicy.TabIndex = 5;
            this.TxtIDPolicy.TextChanged += new System.EventHandler(this.TxtIDPolicy_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Policy";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(406, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 79);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Signature";
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::InsuranceProgram.Properties.Resources._1543956601_054887_1543957006_noticia_normal;
            this.ClientSize = new System.Drawing.Size(1237, 658);
            this.Controls.Add(this.tabGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBilling";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBqrCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkSelect;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.TextBox TxtPolicyDescription;
        private System.Windows.Forms.Button BtnSearchPolicy;
        private System.Windows.Forms.TextBox TxtIDPolicy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtClientName;
        private System.Windows.Forms.Button BtnSearchClient;
        private System.Windows.Forms.TextBox TxtIDClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtTotalTax;
        private System.Windows.Forms.TextBox TxtTotalDollars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblSell;
        private System.Windows.Forms.Label LblBuy;
        private System.Windows.Forms.RadioButton RdoAmericanExpress;
        private System.Windows.Forms.RadioButton RdoMasterCard;
        private System.Windows.Forms.RadioButton RdoVisa;
        private System.Windows.Forms.Button BtnAddCoverage;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.TextBox TxtIdentificationFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.PictureBox PBqrCode;
        private System.Windows.Forms.Button BtnSaveQR;
        private System.Windows.Forms.TextBox TxtTotalColones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}