namespace CS_Management
{
    partial class dodajUrediVoziloForm
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
            this.lblBrojSasije = new System.Windows.Forms.Label();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.lblRegOznaka = new System.Windows.Forms.Label();
            this.txtRegOznaka = new System.Windows.Forms.TextBox();
            this.lblRegDo = new System.Windows.Forms.Label();
            this.lblGodProizvodnje = new System.Windows.Forms.Label();
            this.dtpRegDo = new System.Windows.Forms.DateTimePicker();
            this.dtpGodProizvodnje = new System.Windows.Forms.DateTimePicker();
            this.lblMarka = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet7 = new CS_Management.CS_ManagementDataSet7();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet8 = new CS_Management.CS_ManagementDataSet8();
            this.lblVarijanta = new System.Windows.Forms.Label();
            this.cmbVarijanta = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.markaTableAdapter = new CS_Management.CS_ManagementDataSet7TableAdapters.MarkaTableAdapter();
            this.modelTableAdapter = new CS_Management.CS_ManagementDataSet8TableAdapters.ModelTableAdapter();
            this.cS_ManagementDataSet9 = new CS_Management.CS_ManagementDataSet9();
            this.cmbVarijantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varijantaTableAdapter = new CS_Management.CS_ManagementDataSet9TableAdapters.VarijantaTableAdapter();
            this.cS_ManagementDataSet10 = new CS_Management.CS_ManagementDataSet10();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVarijantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrojSasije
            // 
            this.lblBrojSasije.AutoSize = true;
            this.lblBrojSasije.Location = new System.Drawing.Point(12, 9);
            this.lblBrojSasije.Name = "lblBrojSasije";
            this.lblBrojSasije.Size = new System.Drawing.Size(84, 13);
            this.lblBrojSasije.TabIndex = 0;
            this.lblBrojSasije.Text = "Broj šasije (VIN):";
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(119, 6);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(131, 20);
            this.txtBrojSasije.TabIndex = 1;
            // 
            // lblRegOznaka
            // 
            this.lblRegOznaka.AutoSize = true;
            this.lblRegOznaka.Location = new System.Drawing.Point(12, 50);
            this.lblRegOznaka.Name = "lblRegOznaka";
            this.lblRegOznaka.Size = new System.Drawing.Size(71, 13);
            this.lblRegOznaka.TabIndex = 2;
            this.lblRegOznaka.Text = "Reg. oznaka:";
            // 
            // txtRegOznaka
            // 
            this.txtRegOznaka.Location = new System.Drawing.Point(119, 47);
            this.txtRegOznaka.Name = "txtRegOznaka";
            this.txtRegOznaka.Size = new System.Drawing.Size(131, 20);
            this.txtRegOznaka.TabIndex = 3;
            // 
            // lblRegDo
            // 
            this.lblRegDo.AutoSize = true;
            this.lblRegDo.Location = new System.Drawing.Point(12, 91);
            this.lblRegDo.Name = "lblRegDo";
            this.lblRegDo.Size = new System.Drawing.Size(75, 13);
            this.lblRegDo.TabIndex = 4;
            this.lblRegDo.Text = "Registriran do:";
            // 
            // lblGodProizvodnje
            // 
            this.lblGodProizvodnje.AutoSize = true;
            this.lblGodProizvodnje.Location = new System.Drawing.Point(12, 130);
            this.lblGodProizvodnje.Name = "lblGodProizvodnje";
            this.lblGodProizvodnje.Size = new System.Drawing.Size(101, 13);
            this.lblGodProizvodnje.TabIndex = 6;
            this.lblGodProizvodnje.Text = "Godina proizvodnje:";
            // 
            // dtpRegDo
            // 
            this.dtpRegDo.Location = new System.Drawing.Point(119, 85);
            this.dtpRegDo.Name = "dtpRegDo";
            this.dtpRegDo.Size = new System.Drawing.Size(131, 20);
            this.dtpRegDo.TabIndex = 7;
            // 
            // dtpGodProizvodnje
            // 
            this.dtpGodProizvodnje.Location = new System.Drawing.Point(119, 124);
            this.dtpGodProizvodnje.Name = "dtpGodProizvodnje";
            this.dtpGodProizvodnje.Size = new System.Drawing.Size(131, 20);
            this.dtpGodProizvodnje.TabIndex = 8;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(12, 169);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(40, 13);
            this.lblMarka.TabIndex = 9;
            this.lblMarka.Text = "Marka:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataSource = this.markaBindingSource;
            this.cmbMarka.DisplayMember = "Naziv";
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(119, 166);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbMarka.TabIndex = 10;
            this.cmbMarka.ValueMember = "ID";
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.cS_ManagementDataSet7;
            // 
            // cS_ManagementDataSet7
            // 
            this.cS_ManagementDataSet7.DataSetName = "CS_ManagementDataSet7";
            this.cS_ManagementDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 213);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Model:";
            // 
            // cmbModel
            // 
            this.cmbModel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelBindingSource, "ID", true));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(119, 210);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 12;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.cS_ManagementDataSet8;
            // 
            // cS_ManagementDataSet8
            // 
            this.cS_ManagementDataSet8.DataSetName = "CS_ManagementDataSet8";
            this.cS_ManagementDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblVarijanta
            // 
            this.lblVarijanta.AutoSize = true;
            this.lblVarijanta.Location = new System.Drawing.Point(12, 253);
            this.lblVarijanta.Name = "lblVarijanta";
            this.lblVarijanta.Size = new System.Drawing.Size(51, 13);
            this.lblVarijanta.TabIndex = 13;
            this.lblVarijanta.Text = "Varijanta:";
            // 
            // cmbVarijanta
            // 
            this.cmbVarijanta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelBindingSource, "ID", true));
            this.cmbVarijanta.FormattingEnabled = true;
            this.cmbVarijanta.Location = new System.Drawing.Point(119, 250);
            this.cmbVarijanta.Name = "cmbVarijanta";
            this.cmbVarijanta.Size = new System.Drawing.Size(121, 21);
            this.cmbVarijanta.TabIndex = 14;
            this.cmbVarijanta.SelectedIndexChanged += new System.EventHandler(this.cmbVarijanta_SelectedIndexChanged);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(15, 295);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(98, 47);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(142, 295);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(98, 47);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // cS_ManagementDataSet9
            // 
            this.cS_ManagementDataSet9.DataSetName = "CS_ManagementDataSet9";
            this.cS_ManagementDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbVarijantaBindingSource
            // 
            this.cmbVarijantaBindingSource.DataMember = "Varijanta";
            this.cmbVarijantaBindingSource.DataSource = this.cS_ManagementDataSet9;
            // 
            // varijantaTableAdapter
            // 
            this.varijantaTableAdapter.ClearBeforeFill = true;
            // 
            // cS_ManagementDataSet10
            // 
            this.cS_ManagementDataSet10.DataSetName = "CS_ManagementDataSet10";
            this.cS_ManagementDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dodajUrediVoziloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbVarijanta);
            this.Controls.Add(this.lblVarijanta);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.dtpGodProizvodnje);
            this.Controls.Add(this.dtpRegDo);
            this.Controls.Add(this.lblGodProizvodnje);
            this.Controls.Add(this.lblRegDo);
            this.Controls.Add(this.txtRegOznaka);
            this.Controls.Add(this.lblRegOznaka);
            this.Controls.Add(this.txtBrojSasije);
            this.Controls.Add(this.lblBrojSasije);
            this.Name = "dodajUrediVoziloForm";
            this.Text = "dodajUrediVozilo";
            this.Load += new System.EventHandler(this.dodajUrediVoziloForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVarijantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojSasije;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.Label lblRegOznaka;
        private System.Windows.Forms.TextBox txtRegOznaka;
        private System.Windows.Forms.Label lblRegDo;
        private System.Windows.Forms.Label lblGodProizvodnje;
        private System.Windows.Forms.DateTimePicker dtpRegDo;
        private System.Windows.Forms.DateTimePicker dtpGodProizvodnje;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblVarijanta;
        private System.Windows.Forms.ComboBox cmbVarijanta;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private CS_ManagementDataSet7 cS_ManagementDataSet7;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private CS_ManagementDataSet7TableAdapters.MarkaTableAdapter markaTableAdapter;
        private CS_ManagementDataSet8 cS_ManagementDataSet8;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private CS_ManagementDataSet8TableAdapters.ModelTableAdapter modelTableAdapter;
        private CS_ManagementDataSet9 cS_ManagementDataSet9;
        private System.Windows.Forms.BindingSource cmbVarijantaBindingSource;
        private CS_ManagementDataSet9TableAdapters.VarijantaTableAdapter varijantaTableAdapter;
        private CS_ManagementDataSet10 cS_ManagementDataSet10;
    }
}