namespace CS_Management
{
    partial class pregledVozilaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pregledVozilaForm));
            this.lblPopisVozila = new System.Windows.Forms.Label();
            this.dgvPregledVozila = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registarskaOznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registriranDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaProizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet = new CS_Management.CS_ManagementDataSet();
            this.lblPregledServisa = new System.Windows.Forms.Label();
            this.dgvPopisServisa = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDserviserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvoziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet1 = new CS_Management.CS_ManagementDataSet1();
            this.voziloViewTableAdapter = new CS_Management.CS_ManagementDataSetTableAdapters.voziloViewTableAdapter();
            this.servisTableAdapter = new CS_Management.CS_ManagementDataSet1TableAdapters.ServisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisServisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPopisVozila
            // 
            this.lblPopisVozila.AutoSize = true;
            this.lblPopisVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopisVozila.Location = new System.Drawing.Point(12, 9);
            this.lblPopisVozila.Name = "lblPopisVozila";
            this.lblPopisVozila.Size = new System.Drawing.Size(100, 17);
            this.lblPopisVozila.TabIndex = 0;
            this.lblPopisVozila.Text = "Popis vozila:";
            // 
            // dgvPregledVozila
            // 
            this.dgvPregledVozila.AutoGenerateColumns = false;
            this.dgvPregledVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vINDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.registarskaOznakaDataGridViewTextBoxColumn,
            this.registriranDoDataGridViewTextBoxColumn,
            this.godinaProizvodnjeDataGridViewTextBoxColumn});
            this.dgvPregledVozila.DataSource = this.voziloViewBindingSource;
            this.dgvPregledVozila.Location = new System.Drawing.Point(12, 29);
            this.dgvPregledVozila.Name = "dgvPregledVozila";
            this.dgvPregledVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledVozila.Size = new System.Drawing.Size(893, 247);
            this.dgvPregledVozila.TabIndex = 1;
            this.dgvPregledVozila.SelectionChanged += new System.EventHandler(this.dgvPregledVozila_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // vINDataGridViewTextBoxColumn
            // 
            this.vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            this.vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            this.vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registarskaOznakaDataGridViewTextBoxColumn
            // 
            this.registarskaOznakaDataGridViewTextBoxColumn.DataPropertyName = "Registarska oznaka";
            this.registarskaOznakaDataGridViewTextBoxColumn.HeaderText = "Registarska oznaka";
            this.registarskaOznakaDataGridViewTextBoxColumn.Name = "registarskaOznakaDataGridViewTextBoxColumn";
            // 
            // registriranDoDataGridViewTextBoxColumn
            // 
            this.registriranDoDataGridViewTextBoxColumn.DataPropertyName = "Registriran do";
            this.registriranDoDataGridViewTextBoxColumn.HeaderText = "Registriran do";
            this.registriranDoDataGridViewTextBoxColumn.Name = "registriranDoDataGridViewTextBoxColumn";
            // 
            // godinaProizvodnjeDataGridViewTextBoxColumn
            // 
            this.godinaProizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "Godina proizvodnje";
            this.godinaProizvodnjeDataGridViewTextBoxColumn.HeaderText = "Godina proizvodnje";
            this.godinaProizvodnjeDataGridViewTextBoxColumn.Name = "godinaProizvodnjeDataGridViewTextBoxColumn";
            // 
            // voziloViewBindingSource
            // 
            this.voziloViewBindingSource.DataMember = "voziloView";
            this.voziloViewBindingSource.DataSource = this.cS_ManagementDataSet;
            // 
            // cS_ManagementDataSet
            // 
            this.cS_ManagementDataSet.DataSetName = "CS_ManagementDataSet";
            this.cS_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPregledServisa
            // 
            this.lblPregledServisa.AutoSize = true;
            this.lblPregledServisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPregledServisa.Location = new System.Drawing.Point(12, 279);
            this.lblPregledServisa.Name = "lblPregledServisa";
            this.lblPregledServisa.Size = new System.Drawing.Size(110, 17);
            this.lblPregledServisa.TabIndex = 2;
            this.lblPregledServisa.Text = "Popis servisa:";
            // 
            // dgvPopisServisa
            // 
            this.dgvPopisServisa.AutoGenerateColumns = false;
            this.dgvPopisServisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisServisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisServisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.datumvrijemeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.iDserviserDataGridViewTextBoxColumn,
            this.iDvoziloDataGridViewTextBoxColumn});
            this.dgvPopisServisa.DataSource = this.servisBindingSource;
            this.dgvPopisServisa.Location = new System.Drawing.Point(12, 299);
            this.dgvPopisServisa.Name = "dgvPopisServisa";
            this.dgvPopisServisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisServisa.Size = new System.Drawing.Size(893, 247);
            this.dgvPopisServisa.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datumvrijemeDataGridViewTextBoxColumn
            // 
            this.datumvrijemeDataGridViewTextBoxColumn.DataPropertyName = "Datum_vrijeme";
            this.datumvrijemeDataGridViewTextBoxColumn.HeaderText = "Datum_vrijeme";
            this.datumvrijemeDataGridViewTextBoxColumn.Name = "datumvrijemeDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // iDserviserDataGridViewTextBoxColumn
            // 
            this.iDserviserDataGridViewTextBoxColumn.DataPropertyName = "ID_serviser";
            this.iDserviserDataGridViewTextBoxColumn.HeaderText = "ID_serviser";
            this.iDserviserDataGridViewTextBoxColumn.Name = "iDserviserDataGridViewTextBoxColumn";
            // 
            // iDvoziloDataGridViewTextBoxColumn
            // 
            this.iDvoziloDataGridViewTextBoxColumn.DataPropertyName = "ID_vozilo";
            this.iDvoziloDataGridViewTextBoxColumn.HeaderText = "ID_vozilo";
            this.iDvoziloDataGridViewTextBoxColumn.Name = "iDvoziloDataGridViewTextBoxColumn";
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataMember = "Servis";
            this.servisBindingSource.DataSource = this.cS_ManagementDataSet1;
            // 
            // cS_ManagementDataSet1
            // 
            this.cS_ManagementDataSet1.DataSetName = "CS_ManagementDataSet1";
            this.cS_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voziloViewTableAdapter
            // 
            this.voziloViewTableAdapter.ClearBeforeFill = true;
            // 
            // servisTableAdapter
            // 
            this.servisTableAdapter.ClearBeforeFill = true;
            // 
            // pregledVozilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 598);
            this.Controls.Add(this.dgvPopisServisa);
            this.Controls.Add(this.lblPregledServisa);
            this.Controls.Add(this.dgvPregledVozila);
            this.Controls.Add(this.lblPopisVozila);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pregledVozilaForm";
            this.Text = "Pregled vozila";
            this.Load += new System.EventHandler(this.pregledVozilaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisServisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPopisVozila;
        private System.Windows.Forms.DataGridView dgvPregledVozila;
        private System.Windows.Forms.Label lblPregledServisa;
        private System.Windows.Forms.DataGridView dgvPopisServisa;
        private CS_ManagementDataSet cS_ManagementDataSet;
        private System.Windows.Forms.BindingSource voziloViewBindingSource;
        private CS_ManagementDataSetTableAdapters.voziloViewTableAdapter voziloViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registarskaOznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registriranDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaProizvodnjeDataGridViewTextBoxColumn;
        private CS_ManagementDataSet1 cS_ManagementDataSet1;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private CS_ManagementDataSet1TableAdapters.ServisTableAdapter servisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDserviserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvoziloDataGridViewTextBoxColumn;
    }
}