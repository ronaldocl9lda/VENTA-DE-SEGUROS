
namespace InsuranceProgram.Layers.UI
{
    partial class FrmSelectPolicy
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
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.dgvPolicies = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGeneral.Location = new System.Drawing.Point(12, 12);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(952, 505);
            this.tabGeneral.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.dgvPolicies);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Policy";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 18);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(581, 30);
            this.txtSearch.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(556, 431);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(61, 25);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total";
            // 
            // dgvPolicies
            // 
            this.dgvPolicies.AllowUserToAddRows = false;
            this.dgvPolicies.AllowUserToDeleteRows = false;
            this.dgvPolicies.AllowUserToOrderColumns = true;
            this.dgvPolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect});
            this.dgvPolicies.Location = new System.Drawing.Point(16, 63);
            this.dgvPolicies.Name = "dgvPolicies";
            this.dgvPolicies.ReadOnly = true;
            this.dgvPolicies.RowHeadersWidth = 51;
            this.dgvPolicies.RowTemplate.Height = 24;
            this.dgvPolicies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolicies.Size = new System.Drawing.Size(908, 355);
            this.dgvPolicies.TabIndex = 0;
            this.dgvPolicies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicies_CellDoubleClick);
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
            // FrmSelectPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InsuranceProgram.Properties.Resources._1543956601_054887_1543957006_noticia_normal;
            this.ClientSize = new System.Drawing.Size(976, 529);
            this.Controls.Add(this.tabGeneral);
            this.Name = "FrmSelectPolicy";
            this.Text = "FrmSelectPolicy";
            this.Load += new System.EventHandler(this.FrmSelectPolicy_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView dgvPolicies;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
    }
}