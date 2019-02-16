namespace CS_Management
{
    partial class markaModelVarijantaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMarke = new System.Windows.Forms.DataGridView();
            this.cS_ManagementDataSet2 = new CS_Management.CS_ManagementDataSet2();
            this.markaTableAdapter = new CS_Management.CS_ManagementDataSet2TableAdapters.MarkaTableAdapter();
            this.lblModeli = new System.Windows.Forms.Label();
            this.dgvModeli = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmarkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet3 = new CS_Management.CS_ManagementDataSet3();
            this.lblVarijante = new System.Windows.Forms.Label();
            this.dgvVarijante = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznakamotoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjenjačDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karoserijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmodelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varijantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet4 = new CS_Management.CS_ManagementDataSet4();
            this.modelTableAdapter = new CS_Management.CS_ManagementDataSet3TableAdapters.ModelTableAdapter();
            this.varijantaTableAdapter = new CS_Management.CS_ManagementDataSet4TableAdapters.VarijantaTableAdapter();
            this.cS_ManagementDataSet5 = new CS_Management.CS_ManagementDataSet5();
            this.markaTableAdapter1 = new CS_Management.CS_ManagementDataSet5TableAdapters.MarkaTableAdapter();
            this.cS_ManagementDataSet6 = new CS_Management.CS_ManagementDataSet6();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markaTableAdapter2 = new CS_Management.CS_ManagementDataSet6TableAdapters.MarkaTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarijante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varijantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis marki:";
            // 
            // dgvMarke
            // 
            this.dgvMarke.AutoGenerateColumns = false;
            this.dgvMarke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.dgvMarke.DataSource = this.markaBindingSource;
            this.dgvMarke.Location = new System.Drawing.Point(12, 29);
            this.dgvMarke.Name = "dgvMarke";
            this.dgvMarke.Size = new System.Drawing.Size(518, 170);
            this.dgvMarke.TabIndex = 1;
            this.dgvMarke.SelectionChanged += new System.EventHandler(this.dgvMarke_SelectionChanged);
            // 
            // cS_ManagementDataSet2
            // 
            this.cS_ManagementDataSet2.DataSetName = "CS_ManagementDataSet2";
            this.cS_ManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // lblModeli
            // 
            this.lblModeli.AutoSize = true;
            this.lblModeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblModeli.Location = new System.Drawing.Point(12, 202);
            this.lblModeli.Name = "lblModeli";
            this.lblModeli.Size = new System.Drawing.Size(110, 17);
            this.lblModeli.TabIndex = 2;
            this.lblModeli.Text = "Popis modela:";
            // 
            // dgvModeli
            // 
            this.dgvModeli.AutoGenerateColumns = false;
            this.dgvModeli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.iDmarkeDataGridViewTextBoxColumn});
            this.dgvModeli.DataSource = this.modelBindingSource;
            this.dgvModeli.Location = new System.Drawing.Point(12, 222);
            this.dgvModeli.Name = "dgvModeli";
            this.dgvModeli.Size = new System.Drawing.Size(518, 170);
            this.dgvModeli.TabIndex = 3;
            this.dgvModeli.SelectionChanged += new System.EventHandler(this.dgvModeli_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // iDmarkeDataGridViewTextBoxColumn
            // 
            this.iDmarkeDataGridViewTextBoxColumn.DataPropertyName = "ID_marke";
            this.iDmarkeDataGridViewTextBoxColumn.HeaderText = "ID_marke";
            this.iDmarkeDataGridViewTextBoxColumn.Name = "iDmarkeDataGridViewTextBoxColumn";
            this.iDmarkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.cS_ManagementDataSet3;
            // 
            // cS_ManagementDataSet3
            // 
            this.cS_ManagementDataSet3.DataSetName = "CS_ManagementDataSet3";
            this.cS_ManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblVarijante
            // 
            this.lblVarijante.AutoSize = true;
            this.lblVarijante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVarijante.Location = new System.Drawing.Point(12, 395);
            this.lblVarijante.Name = "lblVarijante";
            this.lblVarijante.Size = new System.Drawing.Size(116, 17);
            this.lblVarijante.TabIndex = 4;
            this.lblVarijante.Text = "Popis varijanti:";
            // 
            // dgvVarijante
            // 
            this.dgvVarijante.AutoGenerateColumns = false;
            this.dgvVarijante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVarijante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarijante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.oznakamotoraDataGridViewTextBoxColumn,
            this.mjenjačDataGridViewTextBoxColumn,
            this.karoserijaDataGridViewTextBoxColumn,
            this.iDmodelaDataGridViewTextBoxColumn});
            this.dgvVarijante.DataSource = this.varijantaBindingSource;
            this.dgvVarijante.Location = new System.Drawing.Point(12, 415);
            this.dgvVarijante.Name = "dgvVarijante";
            this.dgvVarijante.Size = new System.Drawing.Size(518, 170);
            this.dgvVarijante.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // oznakamotoraDataGridViewTextBoxColumn
            // 
            this.oznakamotoraDataGridViewTextBoxColumn.DataPropertyName = "Oznaka_motora";
            this.oznakamotoraDataGridViewTextBoxColumn.HeaderText = "Oznaka_motora";
            this.oznakamotoraDataGridViewTextBoxColumn.Name = "oznakamotoraDataGridViewTextBoxColumn";
            // 
            // mjenjačDataGridViewTextBoxColumn
            // 
            this.mjenjačDataGridViewTextBoxColumn.DataPropertyName = "Mjenjač";
            this.mjenjačDataGridViewTextBoxColumn.HeaderText = "Mjenjač";
            this.mjenjačDataGridViewTextBoxColumn.Name = "mjenjačDataGridViewTextBoxColumn";
            // 
            // karoserijaDataGridViewTextBoxColumn
            // 
            this.karoserijaDataGridViewTextBoxColumn.DataPropertyName = "Karoserija";
            this.karoserijaDataGridViewTextBoxColumn.HeaderText = "Karoserija";
            this.karoserijaDataGridViewTextBoxColumn.Name = "karoserijaDataGridViewTextBoxColumn";
            // 
            // iDmodelaDataGridViewTextBoxColumn
            // 
            this.iDmodelaDataGridViewTextBoxColumn.DataPropertyName = "ID_modela";
            this.iDmodelaDataGridViewTextBoxColumn.HeaderText = "ID_modela";
            this.iDmodelaDataGridViewTextBoxColumn.Name = "iDmodelaDataGridViewTextBoxColumn";
            // 
            // varijantaBindingSource
            // 
            this.varijantaBindingSource.DataMember = "Varijanta";
            this.varijantaBindingSource.DataSource = this.cS_ManagementDataSet4;
            // 
            // cS_ManagementDataSet4
            // 
            this.cS_ManagementDataSet4.DataSetName = "CS_ManagementDataSet4";
            this.cS_ManagementDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // varijantaTableAdapter
            // 
            this.varijantaTableAdapter.ClearBeforeFill = true;
            // 
            // cS_ManagementDataSet5
            // 
            this.cS_ManagementDataSet5.DataSetName = "CS_ManagementDataSet5";
            this.cS_ManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaTableAdapter1
            // 
            this.markaTableAdapter1.ClearBeforeFill = true;
            // 
            // cS_ManagementDataSet6
            // 
            this.cS_ManagementDataSet6.DataSetName = "CS_ManagementDataSet6";
            this.cS_ManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.cS_ManagementDataSet6;
            // 
            // markaTableAdapter2
            // 
            this.markaTableAdapter2.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // markaModelVarijantaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 550);
            this.Controls.Add(this.dgvVarijante);
            this.Controls.Add(this.lblVarijante);
            this.Controls.Add(this.dgvModeli);
            this.Controls.Add(this.lblModeli);
            this.Controls.Add(this.dgvMarke);
            this.Controls.Add(this.label1);
            this.Name = "markaModelVarijantaForm";
            this.Text = "Šifarnik -> Marka, Model, Varijanta";
            this.Load += new System.EventHandler(this.markaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarijante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varijantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMarke;
        private CS_ManagementDataSet2 cS_ManagementDataSet2;
        private CS_ManagementDataSet2TableAdapters.MarkaTableAdapter markaTableAdapter;
        private System.Windows.Forms.Label lblModeli;
        private System.Windows.Forms.DataGridView dgvModeli;
        private System.Windows.Forms.Label lblVarijante;
        private System.Windows.Forms.DataGridView dgvVarijante;
        private CS_ManagementDataSet3 cS_ManagementDataSet3;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private CS_ManagementDataSet3TableAdapters.ModelTableAdapter modelTableAdapter;
        private CS_ManagementDataSet4 cS_ManagementDataSet4;
        private System.Windows.Forms.BindingSource varijantaBindingSource;
        private CS_ManagementDataSet4TableAdapters.VarijantaTableAdapter varijantaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznakamotoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjenjačDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karoserijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmodelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmarkeDataGridViewTextBoxColumn;
        private CS_ManagementDataSet5 cS_ManagementDataSet5;
        private CS_ManagementDataSet5TableAdapters.MarkaTableAdapter markaTableAdapter1;
        private CS_ManagementDataSet6 cS_ManagementDataSet6;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private CS_ManagementDataSet6TableAdapters.MarkaTableAdapter markaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
    }
}