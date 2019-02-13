namespace CS
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
            this.vozilaDgv = new System.Windows.Forms.DataGridView();
            this.vozilaLabel = new System.Windows.Forms.Label();
            this.servisLabel = new System.Windows.Forms.Label();
            this.servisiDgv = new System.Windows.Forms.DataGridView();
            this.cS_ManagementDataSet = new CS.CS_ManagementDataSet();
            this.voziloViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloViewTableAdapter = new CS.CS_ManagementDataSetTableAdapters.voziloViewTableAdapter();
            this.cS_ManagementDataSet1 = new CS.CS_ManagementDataSet1();
            this.voziloViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.voziloViewTableAdapter1 = new CS.CS_ManagementDataSet1TableAdapters.voziloViewTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registarskaOznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registriranDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaProizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDserviserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvoziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaservisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vozilaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisiDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // vozilaDgv
            // 
            this.vozilaDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vozilaDgv.AutoGenerateColumns = false;
            this.vozilaDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vozilaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vozilaDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vINDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn1,
            this.registarskaOznakaDataGridViewTextBoxColumn,
            this.registriranDoDataGridViewTextBoxColumn,
            this.godinaProizvodnjeDataGridViewTextBoxColumn});
            this.vozilaDgv.DataSource = this.voziloViewBindingSource1;
            this.vozilaDgv.Location = new System.Drawing.Point(9, 24);
            this.vozilaDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vozilaDgv.Name = "vozilaDgv";
            this.vozilaDgv.RowTemplate.Height = 24;
            this.vozilaDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vozilaDgv.Size = new System.Drawing.Size(688, 229);
            this.vozilaDgv.TabIndex = 0;
            this.vozilaDgv.SelectionChanged += new System.EventHandler(this.vozilaDgv_SelectionChanged);
            // 
            // vozilaLabel
            // 
            this.vozilaLabel.AutoSize = true;
            this.vozilaLabel.Location = new System.Drawing.Point(9, 7);
            this.vozilaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vozilaLabel.Name = "vozilaLabel";
            this.vozilaLabel.Size = new System.Drawing.Size(66, 13);
            this.vozilaLabel.TabIndex = 1;
            this.vozilaLabel.Text = "Popis vozila:";
            // 
            // servisLabel
            // 
            this.servisLabel.AutoSize = true;
            this.servisLabel.Location = new System.Drawing.Point(11, 258);
            this.servisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servisLabel.Name = "servisLabel";
            this.servisLabel.Size = new System.Drawing.Size(72, 13);
            this.servisLabel.TabIndex = 2;
            this.servisLabel.Text = "Popis servisa:";
            // 
            // servisiDgv
            // 
            this.servisiDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servisiDgv.AutoGenerateColumns = false;
            this.servisiDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servisiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servisiDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.datumvrijemeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.iDserviserDataGridViewTextBoxColumn,
            this.iDvoziloDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.stavkaservisaDataGridViewTextBoxColumn});
            this.servisiDgv.DataSource = this.servisBindingSource;
            this.servisiDgv.Location = new System.Drawing.Point(9, 275);
            this.servisiDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servisiDgv.Name = "servisiDgv";
            this.servisiDgv.RowTemplate.Height = 24;
            this.servisiDgv.Size = new System.Drawing.Size(688, 229);
            this.servisiDgv.TabIndex = 3;
            // 
            // cS_ManagementDataSet
            // 
            this.cS_ManagementDataSet.DataSetName = "CS_ManagementDataSet";
            this.cS_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voziloViewBindingSource
            // 
            this.voziloViewBindingSource.DataMember = "voziloView";
            this.voziloViewBindingSource.DataSource = this.cS_ManagementDataSet;
            // 
            // voziloViewTableAdapter
            // 
            this.voziloViewTableAdapter.ClearBeforeFill = true;
            // 
            // cS_ManagementDataSet1
            // 
            this.cS_ManagementDataSet1.DataSetName = "CS_ManagementDataSet1";
            this.cS_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voziloViewBindingSource1
            // 
            this.voziloViewBindingSource1.DataMember = "voziloView";
            this.voziloViewBindingSource1.DataSource = this.cS_ManagementDataSet1;
            // 
            // voziloViewTableAdapter1
            // 
            this.voziloViewTableAdapter1.ClearBeforeFill = true;
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
            // voziloDataGridViewTextBoxColumn1
            // 
            this.voziloDataGridViewTextBoxColumn1.DataPropertyName = "Vozilo";
            this.voziloDataGridViewTextBoxColumn1.HeaderText = "Vozilo";
            this.voziloDataGridViewTextBoxColumn1.Name = "voziloDataGridViewTextBoxColumn1";
            this.voziloDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
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
            this.iDserviserDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDvoziloDataGridViewTextBoxColumn
            // 
            this.iDvoziloDataGridViewTextBoxColumn.DataPropertyName = "ID_vozilo";
            this.iDvoziloDataGridViewTextBoxColumn.HeaderText = "ID_vozilo";
            this.iDvoziloDataGridViewTextBoxColumn.Name = "iDvoziloDataGridViewTextBoxColumn";
            this.iDvoziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkaservisaDataGridViewTextBoxColumn
            // 
            this.stavkaservisaDataGridViewTextBoxColumn.DataPropertyName = "Stavka_servisa";
            this.stavkaservisaDataGridViewTextBoxColumn.HeaderText = "Stavka_servisa";
            this.stavkaservisaDataGridViewTextBoxColumn.Name = "stavkaservisaDataGridViewTextBoxColumn";
            this.stavkaservisaDataGridViewTextBoxColumn.Visible = false;
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataSource = typeof(CS.Servis);
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(CS.Vozilo);
            // 
            // voziloBindingSource1
            // 
            this.voziloBindingSource1.DataSource = typeof(CS.Vozilo);
            // 
            // pregledVozilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 426);
            this.Controls.Add(this.servisiDgv);
            this.Controls.Add(this.servisLabel);
            this.Controls.Add(this.vozilaLabel);
            this.Controls.Add(this.vozilaDgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pregledVozilaForm";
            this.Text = "Pregled vozila";
            this.Load += new System.EventHandler(this.pregledVozilaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vozilaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisiDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vozilaDgv;
        private System.Windows.Forms.Label vozilaLabel;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private System.Windows.Forms.Label servisLabel;
        private System.Windows.Forms.DataGridView servisiDgv;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private System.Windows.Forms.BindingSource voziloBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDserviserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvoziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaservisaDataGridViewTextBoxColumn;
        private CS_ManagementDataSet cS_ManagementDataSet;
        private System.Windows.Forms.BindingSource voziloViewBindingSource;
        private CS_ManagementDataSetTableAdapters.voziloViewTableAdapter voziloViewTableAdapter;
        private CS_ManagementDataSet1 cS_ManagementDataSet1;
        private System.Windows.Forms.BindingSource voziloViewBindingSource1;
        private CS_ManagementDataSet1TableAdapters.voziloViewTableAdapter voziloViewTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registarskaOznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registriranDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaProizvodnjeDataGridViewTextBoxColumn;
    }
}