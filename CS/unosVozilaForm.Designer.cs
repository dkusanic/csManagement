namespace CS
{
    partial class unosVozilaForm
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
            this.dtpRegDo = new System.Windows.Forms.DateTimePicker();
            this.lblGodProizvodnje = new System.Windows.Forms.Label();
            this.dtpGodProizvodnje = new System.Windows.Forms.DateTimePicker();
            this.lblMarka = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet2 = new CS.CS_ManagementDataSet2();
            this.markaTableAdapter = new CS.CS_ManagementDataSet2TableAdapters.MarkaTableAdapter();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet6 = new CS.CS_ManagementDataSet6();
            this.cS_ManagementDataSet3 = new CS.CS_ManagementDataSet3();
            this.modelTableAdapter = new CS.CS_ManagementDataSet3TableAdapters.ModelTableAdapter();
            this.cS_ManagementDataSet5 = new CS.CS_ManagementDataSet5();
            this.cSManagementDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter1 = new CS.CS_ManagementDataSet6TableAdapters.ModelTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lblVarijanta = new System.Windows.Forms.Label();
            this.cmbVarijanta = new System.Windows.Forms.ComboBox();
            this.varijantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cS_ManagementDataSet7 = new CS.CS_ManagementDataSet7();
            this.varijantaTableAdapter = new CS.CS_ManagementDataSet7TableAdapters.VarijantaTableAdapter();
            this.btnSpremiVozilo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSManagementDataSet5BindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varijantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet7)).BeginInit();
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
            this.txtBrojSasije.Location = new System.Drawing.Point(122, 6);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(117, 20);
            this.txtBrojSasije.TabIndex = 1;
            // 
            // lblRegOznaka
            // 
            this.lblRegOznaka.AutoSize = true;
            this.lblRegOznaka.Location = new System.Drawing.Point(12, 44);
            this.lblRegOznaka.Name = "lblRegOznaka";
            this.lblRegOznaka.Size = new System.Drawing.Size(104, 13);
            this.lblRegOznaka.TabIndex = 2;
            this.lblRegOznaka.Text = "Registarska oznaka:";
            // 
            // txtRegOznaka
            // 
            this.txtRegOznaka.Location = new System.Drawing.Point(122, 41);
            this.txtRegOznaka.Name = "txtRegOznaka";
            this.txtRegOznaka.Size = new System.Drawing.Size(117, 20);
            this.txtRegOznaka.TabIndex = 3;
            // 
            // lblRegDo
            // 
            this.lblRegDo.AutoSize = true;
            this.lblRegDo.Location = new System.Drawing.Point(12, 77);
            this.lblRegDo.Name = "lblRegDo";
            this.lblRegDo.Size = new System.Drawing.Size(75, 13);
            this.lblRegDo.TabIndex = 4;
            this.lblRegDo.Text = "Registriran do:";
            // 
            // dtpRegDo
            // 
            this.dtpRegDo.CustomFormat = "MMM yyyy";
            this.dtpRegDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegDo.Location = new System.Drawing.Point(122, 71);
            this.dtpRegDo.Name = "dtpRegDo";
            this.dtpRegDo.Size = new System.Drawing.Size(117, 20);
            this.dtpRegDo.TabIndex = 5;
            // 
            // lblGodProizvodnje
            // 
            this.lblGodProizvodnje.AutoSize = true;
            this.lblGodProizvodnje.Location = new System.Drawing.Point(12, 111);
            this.lblGodProizvodnje.Name = "lblGodProizvodnje";
            this.lblGodProizvodnje.Size = new System.Drawing.Size(101, 13);
            this.lblGodProizvodnje.TabIndex = 6;
            this.lblGodProizvodnje.Text = "Godina proizvodnje:";
            // 
            // dtpGodProizvodnje
            // 
            this.dtpGodProizvodnje.CustomFormat = "yyyy";
            this.dtpGodProizvodnje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGodProizvodnje.Location = new System.Drawing.Point(122, 105);
            this.dtpGodProizvodnje.Name = "dtpGodProizvodnje";
            this.dtpGodProizvodnje.ShowUpDown = true;
            this.dtpGodProizvodnje.Size = new System.Drawing.Size(117, 20);
            this.dtpGodProizvodnje.TabIndex = 7;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(12, 148);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(40, 13);
            this.lblMarka.TabIndex = 8;
            this.lblMarka.Text = "Marka:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataSource = this.markaBindingSource;
            this.cmbMarka.DisplayMember = "Naziv";
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(122, 145);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(117, 21);
            this.cmbMarka.TabIndex = 9;
            this.cmbMarka.ValueMember = "ID";
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.cS_ManagementDataSet2;
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
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 184);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model:";
            // 
            // cmbModel
            // 
            this.cmbModel.DataSource = this.modelBindingSource;
            this.cmbModel.DisplayMember = "Naziv";
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(122, 181);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(117, 21);
            this.cmbModel.TabIndex = 11;
            this.cmbModel.ValueMember = "ID";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.cS_ManagementDataSet6;
            // 
            // cS_ManagementDataSet6
            // 
            this.cS_ManagementDataSet6.DataSetName = "CS_ManagementDataSet6";
            this.cS_ManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cS_ManagementDataSet3
            // 
            this.cS_ManagementDataSet3.DataSetName = "CS_ManagementDataSet3";
            this.cS_ManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // cS_ManagementDataSet5
            // 
            this.cS_ManagementDataSet5.DataSetName = "CS_ManagementDataSet5";
            this.cS_ManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cSManagementDataSet5BindingSource
            // 
            this.cSManagementDataSet5BindingSource.DataSource = this.cS_ManagementDataSet5;
            this.cSManagementDataSet5BindingSource.Position = 0;
            // 
            // modelTableAdapter1
            // 
            this.modelTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 12;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // lblVarijanta
            // 
            this.lblVarijanta.AutoSize = true;
            this.lblVarijanta.Location = new System.Drawing.Point(12, 221);
            this.lblVarijanta.Name = "lblVarijanta";
            this.lblVarijanta.Size = new System.Drawing.Size(51, 13);
            this.lblVarijanta.TabIndex = 13;
            this.lblVarijanta.Text = "Varijanta:";
            // 
            // cmbVarijanta
            // 
            this.cmbVarijanta.DataSource = this.varijantaBindingSource;
            this.cmbVarijanta.DisplayMember = "Oznaka_motora";
            this.cmbVarijanta.FormattingEnabled = true;
            this.cmbVarijanta.Location = new System.Drawing.Point(122, 218);
            this.cmbVarijanta.Name = "cmbVarijanta";
            this.cmbVarijanta.Size = new System.Drawing.Size(117, 21);
            this.cmbVarijanta.TabIndex = 14;
            this.cmbVarijanta.ValueMember = "ID";
            // 
            // varijantaBindingSource
            // 
            this.varijantaBindingSource.DataMember = "Varijanta";
            this.varijantaBindingSource.DataSource = this.cS_ManagementDataSet7;
            // 
            // cS_ManagementDataSet7
            // 
            this.cS_ManagementDataSet7.DataSetName = "CS_ManagementDataSet7";
            this.cS_ManagementDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varijantaTableAdapter
            // 
            this.varijantaTableAdapter.ClearBeforeFill = true;
            // 
            // btnSpremiVozilo
            // 
            this.btnSpremiVozilo.Location = new System.Drawing.Point(164, 245);
            this.btnSpremiVozilo.Name = "btnSpremiVozilo";
            this.btnSpremiVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiVozilo.TabIndex = 15;
            this.btnSpremiVozilo.Text = "Spremi";
            this.btnSpremiVozilo.UseVisualStyleBackColor = true;
            this.btnSpremiVozilo.Click += new System.EventHandler(this.btnSpremiVozilo_Click);
            // 
            // unosVozilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpremiVozilo);
            this.Controls.Add(this.cmbVarijanta);
            this.Controls.Add(this.lblVarijanta);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.dtpGodProizvodnje);
            this.Controls.Add(this.lblGodProizvodnje);
            this.Controls.Add(this.dtpRegDo);
            this.Controls.Add(this.lblRegDo);
            this.Controls.Add(this.txtRegOznaka);
            this.Controls.Add(this.lblRegOznaka);
            this.Controls.Add(this.txtBrojSasije);
            this.Controls.Add(this.lblBrojSasije);
            this.Name = "unosVozilaForm";
            this.Text = "unosVozilaForm";
            this.Load += new System.EventHandler(this.unosVozilaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSManagementDataSet5BindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varijantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS_ManagementDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojSasije;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.Label lblRegOznaka;
        private System.Windows.Forms.TextBox txtRegOznaka;
        private System.Windows.Forms.Label lblRegDo;
        private System.Windows.Forms.DateTimePicker dtpRegDo;
        private System.Windows.Forms.Label lblGodProizvodnje;
        private System.Windows.Forms.DateTimePicker dtpGodProizvodnje;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox cmbMarka;
        private CS_ManagementDataSet2 cS_ManagementDataSet2;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private CS_ManagementDataSet2TableAdapters.MarkaTableAdapter markaTableAdapter;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbModel;
        private CS_ManagementDataSet3 cS_ManagementDataSet3;
        private CS_ManagementDataSet3TableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource cSManagementDataSet5BindingSource;
        private CS_ManagementDataSet5 cS_ManagementDataSet5;
        private CS_ManagementDataSet6 cS_ManagementDataSet6;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private CS_ManagementDataSet6TableAdapters.ModelTableAdapter modelTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label lblVarijanta;
        private System.Windows.Forms.ComboBox cmbVarijanta;
        private CS_ManagementDataSet7 cS_ManagementDataSet7;
        private System.Windows.Forms.BindingSource varijantaBindingSource;
        private CS_ManagementDataSet7TableAdapters.VarijantaTableAdapter varijantaTableAdapter;
        private System.Windows.Forms.Button btnSpremiVozilo;
    }
}