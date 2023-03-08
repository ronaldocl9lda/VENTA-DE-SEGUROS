
namespace InsuranceProgram.Layers.UI.Maintenances
{
    partial class FrmBeneficiaries
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
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.dgvBeneficiaries = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtIdentification = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnInsertBeneficiary = new System.Windows.Forms.Button();
            this.BtnUpdateBeneficiary = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblRelationship = new System.Windows.Forms.Label();
            this.CboRelationship = new System.Windows.Forms.ComboBox();
            this.DTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaries)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(12, 12);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(552, 441);
            this.tabGeneral.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.chkSelect);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.dgvBeneficiaries);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Beneficiaries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(189, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Location = new System.Drawing.Point(32, 364);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(71, 22);
            this.chkSelect.TabIndex = 4;
            this.chkSelect.Text = "Select";
            this.chkSelect.UseVisualStyleBackColor = true;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(367, 372);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(41, 18);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total";
            // 
            // dgvBeneficiaries
            // 
            this.dgvBeneficiaries.AllowUserToAddRows = false;
            this.dgvBeneficiaries.AllowUserToDeleteRows = false;
            this.dgvBeneficiaries.AllowUserToOrderColumns = true;
            this.dgvBeneficiaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect});
            this.dgvBeneficiaries.Location = new System.Drawing.Point(6, 6);
            this.dgvBeneficiaries.Name = "dgvBeneficiaries";
            this.dgvBeneficiaries.ReadOnly = true;
            this.dgvBeneficiaries.RowHeadersWidth = 51;
            this.dgvBeneficiaries.RowTemplate.Height = 24;
            this.dgvBeneficiaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficiaries.Size = new System.Drawing.Size(506, 342);
            this.dgvBeneficiaries.TabIndex = 0;
            this.dgvBeneficiaries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeneficiaries_CellContentClick);
            this.dgvBeneficiaries.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeneficiaries_CellContentDoubleClick);
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
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.BtnUpdate);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsert);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maintenance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTPBirthday);
            this.groupBox1.Controls.Add(this.CboRelationship);
            this.groupBox1.Controls.Add(this.LblRelationship);
            this.groupBox1.Controls.Add(this.BtnUpdateBeneficiary);
            this.groupBox1.Controls.Add(this.BtnInsertBeneficiary);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.TxtPhoneNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtLastName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtFirstName);
            this.groupBox1.Controls.Add(this.TxtIdentification);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 381);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beneficiary Information";
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(157, 292);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(267, 27);
            this.TxtPhoneNumber.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Birthday";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(157, 149);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(267, 27);
            this.TxtLastName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Last Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(157, 99);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(267, 27);
            this.TxtFirstName.TabIndex = 17;
            // 
            // TxtIdentification
            // 
            this.TxtIdentification.Location = new System.Drawing.Point(157, 48);
            this.TxtIdentification.Name = "TxtIdentification";
            this.TxtIdentification.Size = new System.Drawing.Size(267, 27);
            this.TxtIdentification.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identification";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(117, 431);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(147, 35);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(367, 431);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(147, 35);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(153, 431);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(147, 35);
            this.BtnInsert.TabIndex = 5;
            this.BtnInsert.Text = "Insertar";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(240, 334);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(132, 30);
            this.BtnCancel.TabIndex = 28;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnInsertBeneficiary
            // 
            this.BtnInsertBeneficiary.Location = new System.Drawing.Point(78, 334);
            this.BtnInsertBeneficiary.Name = "BtnInsertBeneficiary";
            this.BtnInsertBeneficiary.Size = new System.Drawing.Size(132, 30);
            this.BtnInsertBeneficiary.TabIndex = 29;
            this.BtnInsertBeneficiary.Text = "Insert";
            this.BtnInsertBeneficiary.UseVisualStyleBackColor = true;
            this.BtnInsertBeneficiary.Click += new System.EventHandler(this.BtnInsertBeneficiary_Click);
            // 
            // BtnUpdateBeneficiary
            // 
            this.BtnUpdateBeneficiary.Location = new System.Drawing.Point(67, 334);
            this.BtnUpdateBeneficiary.Name = "BtnUpdateBeneficiary";
            this.BtnUpdateBeneficiary.Size = new System.Drawing.Size(132, 30);
            this.BtnUpdateBeneficiary.TabIndex = 30;
            this.BtnUpdateBeneficiary.Text = "Update";
            this.BtnUpdateBeneficiary.UseVisualStyleBackColor = true;
            this.BtnUpdateBeneficiary.Click += new System.EventHandler(this.BtnUpdateBeneficiary_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LblRelationship
            // 
            this.LblRelationship.AutoSize = true;
            this.LblRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelationship.Location = new System.Drawing.Point(20, 202);
            this.LblRelationship.Name = "LblRelationship";
            this.LblRelationship.Size = new System.Drawing.Size(101, 18);
            this.LblRelationship.TabIndex = 31;
            this.LblRelationship.Text = "Relationship";
            // 
            // CboRelationship
            // 
            this.CboRelationship.FormattingEnabled = true;
            this.CboRelationship.Items.AddRange(new object[] {
            "Mother",
            "Father",
            "Brother",
            "Husband",
            "Wife",
            "Son",
            "Daughter"});
            this.CboRelationship.Location = new System.Drawing.Point(157, 202);
            this.CboRelationship.Name = "CboRelationship";
            this.CboRelationship.Size = new System.Drawing.Size(267, 28);
            this.CboRelationship.TabIndex = 32;
            // 
            // DTPBirthday
            // 
            this.DTPBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBirthday.Location = new System.Drawing.Point(157, 246);
            this.DTPBirthday.Name = "DTPBirthday";
            this.DTPBirthday.Size = new System.Drawing.Size(146, 27);
            this.DTPBirthday.TabIndex = 33;
            // 
            // FrmBeneficiaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 461);
            this.Controls.Add(this.tabGeneral);
            this.Name = "FrmBeneficiaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Beneficiaries";
            this.Load += new System.EventHandler(this.FrmBeneficiaries_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaries)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkSelect;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView dgvBeneficiaries;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtIdentification;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnUpdateBeneficiary;
        private System.Windows.Forms.Button BtnInsertBeneficiary;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox CboRelationship;
        private System.Windows.Forms.Label LblRelationship;
        private System.Windows.Forms.DateTimePicker DTPBirthday;
    }
}