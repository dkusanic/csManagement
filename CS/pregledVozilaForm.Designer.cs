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
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godproizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvarijanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnistvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDserviserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvoziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaservisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisiDgv)).BeginInit();
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
            this.vozilaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vozilaDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vINDataGridViewTextBoxColumn,
            this.regoznakaDataGridViewTextBoxColumn,
            this.regdoDataGridViewTextBoxColumn,
            this.godproizvodnjeDataGridViewTextBoxColumn,
            this.iDvarijanteDataGridViewTextBoxColumn,
            this.servisDataGridViewTextBoxColumn,
            this.vlasnistvoDataGridViewTextBoxColumn});
            this.vozilaDgv.DataSource = this.voziloBindingSource;
            this.vozilaDgv.Location = new System.Drawing.Point(12, 29);
            this.vozilaDgv.Name = "vozilaDgv";
            this.vozilaDgv.RowTemplate.Height = 24;
            this.vozilaDgv.Size = new System.Drawing.Size(917, 282);
            this.vozilaDgv.TabIndex = 0;
            // 
            // vozilaLabel
            // 
            this.vozilaLabel.AutoSize = true;
            this.vozilaLabel.Location = new System.Drawing.Point(12, 9);
            this.vozilaLabel.Name = "vozilaLabel";
            this.vozilaLabel.Size = new System.Drawing.Size(87, 17);
            this.vozilaLabel.TabIndex = 1;
            this.vozilaLabel.Text = "Popis vozila:";
            // 
            // servisLabel
            // 
            this.servisLabel.AutoSize = true;
            this.servisLabel.Location = new System.Drawing.Point(15, 318);
            this.servisLabel.Name = "servisLabel";
            this.servisLabel.Size = new System.Drawing.Size(96, 17);
            this.servisLabel.TabIndex = 2;
            this.servisLabel.Text = "Popis servisa:";
            // 
            // servisiDgv
            // 
            this.servisiDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servisiDgv.AutoGenerateColumns = false;
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
            this.servisiDgv.Location = new System.Drawing.Point(12, 339);
            this.servisiDgv.Name = "servisiDgv";
            this.servisiDgv.RowTemplate.Height = 24;
            this.servisiDgv.Size = new System.Drawing.Size(917, 282);
            this.servisiDgv.TabIndex = 3;
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataSource = typeof(CS.Servis);
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
            // regoznakaDataGridViewTextBoxColumn
            // 
            this.regoznakaDataGridViewTextBoxColumn.DataPropertyName = "Reg_oznaka";
            this.regoznakaDataGridViewTextBoxColumn.HeaderText = "Reg_oznaka";
            this.regoznakaDataGridViewTextBoxColumn.Name = "regoznakaDataGridViewTextBoxColumn";
            // 
            // regdoDataGridViewTextBoxColumn
            // 
            this.regdoDataGridViewTextBoxColumn.DataPropertyName = "Reg_do";
            this.regdoDataGridViewTextBoxColumn.HeaderText = "Reg_do";
            this.regdoDataGridViewTextBoxColumn.Name = "regdoDataGridViewTextBoxColumn";
            // 
            // godproizvodnjeDataGridViewTextBoxColumn
            // 
            this.godproizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "God_proizvodnje";
            this.godproizvodnjeDataGridViewTextBoxColumn.HeaderText = "God_proizvodnje";
            this.godproizvodnjeDataGridViewTextBoxColumn.Name = "godproizvodnjeDataGridViewTextBoxColumn";
            // 
            // iDvarijanteDataGridViewTextBoxColumn
            // 
            this.iDvarijanteDataGridViewTextBoxColumn.DataPropertyName = "ID_varijante";
            this.iDvarijanteDataGridViewTextBoxColumn.HeaderText = "ID_varijante";
            this.iDvarijanteDataGridViewTextBoxColumn.Name = "iDvarijanteDataGridViewTextBoxColumn";
            // 
            // servisDataGridViewTextBoxColumn
            // 
            this.servisDataGridViewTextBoxColumn.DataPropertyName = "Servis";
            this.servisDataGridViewTextBoxColumn.HeaderText = "Servis";
            this.servisDataGridViewTextBoxColumn.Name = "servisDataGridViewTextBoxColumn";
            this.servisDataGridViewTextBoxColumn.Visible = false;
            // 
            // vlasnistvoDataGridViewTextBoxColumn
            // 
            this.vlasnistvoDataGridViewTextBoxColumn.DataPropertyName = "Vlasnistvo";
            this.vlasnistvoDataGridViewTextBoxColumn.HeaderText = "Vlasnistvo";
            this.vlasnistvoDataGridViewTextBoxColumn.Name = "vlasnistvoDataGridViewTextBoxColumn";
            this.vlasnistvoDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(CS.Vozilo);
            // 
            // voziloBindingSource1
            // 
            this.voziloBindingSource1.DataSource = typeof(CS.Vozilo);
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
            // pregledVozilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 524);
            this.Controls.Add(this.servisiDgv);
            this.Controls.Add(this.servisLabel);
            this.Controls.Add(this.vozilaLabel);
            this.Controls.Add(this.vozilaDgv);
            this.Name = "pregledVozilaForm";
            this.Text = "Pregled vozila";
            this.Load += new System.EventHandler(this.pregledVozilaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vozilaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisiDgv)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godproizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvarijanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlasnistvoDataGridViewTextBoxColumn;
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
    }
}