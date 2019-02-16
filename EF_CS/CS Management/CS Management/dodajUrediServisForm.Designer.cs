namespace CS_Management
{
    partial class dodajUrediServisForm
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
            this.lblDatumVrijemeServisa = new System.Windows.Forms.Label();
            this.dtpDatumVrijeme = new System.Windows.Forms.DateTimePicker();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.grbStavkaServisa = new System.Windows.Forms.GroupBox();
            this.chbOmogucenUsluga = new System.Windows.Forms.CheckBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsluga = new System.Windows.Forms.ComboBox();
            this.lblUsluga = new System.Windows.Forms.Label();
            this.cmbDio = new System.Windows.Forms.ComboBox();
            this.lblDio = new System.Windows.Forms.Label();
            this.dgvStavkeServisa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cS_ManagementDataSet11 = new CS_Management.CS_ManagementDataSet11();
            this.stavkaServisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_servisaTableAdapter = new CS_Management.CS_ManagementDataSet11TableAdapters.Stavka_servisaTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDservisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbStavkaServisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeServisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaServisaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatumVrijemeServisa
            // 
            this.lblDatumVrijemeServisa.AutoSize = true;
            this.lblDatumVrijemeServisa.Location = new System.Drawing.Point(12, 10);
            this.lblDatumVrijemeServisa.Name = "lblDatumVrijemeServisa";
            this.lblDatumVrijemeServisa.Size = new System.Drawing.Size(118, 13);
            this.lblDatumVrijemeServisa.TabIndex = 0;
            this.lblDatumVrijemeServisa.Text = "Datum i vrijeme servisa:";
            // 
            // dtpDatumVrijeme
            // 
            this.dtpDatumVrijeme.Location = new System.Drawing.Point(136, 9);
            this.dtpDatumVrijeme.Name = "dtpDatumVrijeme";
            this.dtpDatumVrijeme.Size = new System.Drawing.Size(172, 20);
            this.dtpDatumVrijeme.TabIndex = 1;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(12, 43);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(67, 13);
            this.lblOpis.TabIndex = 2;
            this.lblOpis.Text = "Opis servisa:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(83, 40);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(225, 58);
            this.txtOpis.TabIndex = 3;
            // 
            // grbStavkaServisa
            // 
            this.grbStavkaServisa.Controls.Add(this.chbOmogucenUsluga);
            this.grbStavkaServisa.Controls.Add(this.btnDodajStavku);
            this.grbStavkaServisa.Controls.Add(this.nudKolicina);
            this.grbStavkaServisa.Controls.Add(this.label1);
            this.grbStavkaServisa.Controls.Add(this.cmbUsluga);
            this.grbStavkaServisa.Controls.Add(this.lblUsluga);
            this.grbStavkaServisa.Controls.Add(this.cmbDio);
            this.grbStavkaServisa.Controls.Add(this.lblDio);
            this.grbStavkaServisa.Location = new System.Drawing.Point(12, 104);
            this.grbStavkaServisa.Name = "grbStavkaServisa";
            this.grbStavkaServisa.Size = new System.Drawing.Size(296, 201);
            this.grbStavkaServisa.TabIndex = 4;
            this.grbStavkaServisa.TabStop = false;
            this.grbStavkaServisa.Text = "Stavke servisa:";
            // 
            // chbOmogucenUsluga
            // 
            this.chbOmogucenUsluga.AutoSize = true;
            this.chbOmogucenUsluga.Location = new System.Drawing.Point(9, 89);
            this.chbOmogucenUsluga.Name = "chbOmogucenUsluga";
            this.chbOmogucenUsluga.Size = new System.Drawing.Size(104, 17);
            this.chbOmogucenUsluga.TabIndex = 5;
            this.chbOmogucenUsluga.Text = "Omogućen unos";
            this.chbOmogucenUsluga.UseVisualStyleBackColor = true;
            this.chbOmogucenUsluga.CheckedChanged += new System.EventHandler(this.chbOmogucenUsluga_CheckedChanged);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(9, 145);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(109, 41);
            this.btnDodajStavku.TabIndex = 9;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // nudKolicina
            // 
            this.nudKolicina.DecimalPlaces = 1;
            this.nudKolicina.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudKolicina.Location = new System.Drawing.Point(71, 119);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(138, 20);
            this.nudKolicina.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Količina:";
            // 
            // cmbUsluga
            // 
            this.cmbUsluga.Enabled = false;
            this.cmbUsluga.FormattingEnabled = true;
            this.cmbUsluga.Location = new System.Drawing.Point(71, 53);
            this.cmbUsluga.Name = "cmbUsluga";
            this.cmbUsluga.Size = new System.Drawing.Size(138, 21);
            this.cmbUsluga.TabIndex = 6;
            this.cmbUsluga.SelectedIndexChanged += new System.EventHandler(this.cmbUsluga_SelectedIndexChanged);
            // 
            // lblUsluga
            // 
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.Location = new System.Drawing.Point(6, 52);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(43, 13);
            this.lblUsluga.TabIndex = 5;
            this.lblUsluga.Text = "Usluga:";
            // 
            // cmbDio
            // 
            this.cmbDio.FormattingEnabled = true;
            this.cmbDio.Location = new System.Drawing.Point(71, 26);
            this.cmbDio.Name = "cmbDio";
            this.cmbDio.Size = new System.Drawing.Size(138, 21);
            this.cmbDio.TabIndex = 4;
            this.cmbDio.SelectedIndexChanged += new System.EventHandler(this.cmbDio_SelectedIndexChanged);
            // 
            // lblDio
            // 
            this.lblDio.AutoSize = true;
            this.lblDio.Location = new System.Drawing.Point(6, 29);
            this.lblDio.Name = "lblDio";
            this.lblDio.Size = new System.Drawing.Size(26, 13);
            this.lblDio.TabIndex = 3;
            this.lblDio.Text = "Dio:";
            // 
            // dgvStavkeServisa
            // 
            this.dgvStavkeServisa.AutoGenerateColumns = false;
            this.dgvStavkeServisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeServisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeServisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDservisDataGridViewTextBoxColumn,
            this.iDdioDataGridViewTextBoxColumn,
            this.iDuslugaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvStavkeServisa.DataSource = this.stavkaServisaBindingSource;
            this.dgvStavkeServisa.Location = new System.Drawing.Point(324, 40);
            this.dgvStavkeServisa.Name = "dgvStavkeServisa";
            this.dgvStavkeServisa.Size = new System.Drawing.Size(464, 265);
            this.dgvStavkeServisa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stavke servisa:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(679, 311);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(109, 41);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cS_ManagementDataSet11
            // 
            this.cS_ManagementDataSet11.DataSetName = "CS_ManagementDataSet11";
            this.cS_ManagementDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stavkaServisaBindingSource
            // 
            this.stavkaServisaBindingSource.DataMember = "Stavka servisa";
            this.stavkaServisaBindingSource.DataSource = this.cS_ManagementDataSet11;
            // 
            // stavka_servisaTableAdapter
            // 
            this.stavka_servisaTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDservisDataGridViewTextBoxColumn
            // 
            this.iDservisDataGridViewTextBoxColumn.DataPropertyName = "ID_servis";
            this.iDservisDataGridViewTextBoxColumn.HeaderText = "ID_servis";
            this.iDservisDataGridViewTextBoxColumn.Name = "iDservisDataGridViewTextBoxColumn";
            // 
            // iDdioDataGridViewTextBoxColumn
            // 
            this.iDdioDataGridViewTextBoxColumn.DataPropertyName = "ID_dio";
            this.iDdioDataGridViewTextBoxColumn.HeaderText = "ID_dio";
            this.iDdioDataGridViewTextBoxColumn.Name = "iDdioDataGridViewTextBoxColumn";
            // 
            // iDuslugaDataGridViewTextBoxColumn
            // 
            this.iDuslugaDataGridViewTextBoxColumn.DataPropertyName = "ID_usluga";
            this.iDuslugaDataGridViewTextBoxColumn.HeaderText = "ID_usluga";
            this.iDuslugaDataGridViewTextBoxColumn.Name = "iDuslugaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // dodajUrediServisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStavkeServisa);
            this.Controls.Add(this.grbStavkaServisa);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.dtpDatumVrijeme);
            this.Controls.Add(this.lblDatumVrijemeServisa);
            this.Name = "dodajUrediServisForm";
            this.Text = "dodajUrediServisForm";
            this.Load += new System.EventHandler(this.dodajUrediServisForm_Load);
            this.grbStavkaServisa.ResumeLayout(false);
            this.grbStavkaServisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeServisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaServisaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumVrijemeServisa;
        private System.Windows.Forms.DateTimePicker dtpDatumVrijeme;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.GroupBox grbStavkaServisa;
        private System.Windows.Forms.CheckBox chbOmogucenUsluga;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsluga;
        private System.Windows.Forms.Label lblUsluga;
        private System.Windows.Forms.ComboBox cmbDio;
        private System.Windows.Forms.Label lblDio;
        private System.Windows.Forms.DataGridView dgvStavkeServisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpremi;
        private CS_ManagementDataSet11 cS_ManagementDataSet11;
        private System.Windows.Forms.BindingSource stavkaServisaBindingSource;
        private CS_ManagementDataSet11TableAdapters.Stavka_servisaTableAdapter stavka_servisaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDservisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuslugaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}