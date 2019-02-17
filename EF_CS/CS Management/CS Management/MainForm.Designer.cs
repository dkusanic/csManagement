namespace CS_Management
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuIzbornik = new System.Windows.Forms.MenuStrip();
            this.tsmiAplikacija = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZakljucaj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVozila = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledVozila = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBazaV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMarka = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDijelovi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsluge = new System.Windows.Forms.ToolStripMenuItem();
            this.vlasniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledVlasnika = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServiseri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledServisera = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIzbornik
            // 
            this.menuIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAplikacija,
            this.tsmiVozila,
            this.vlasniciToolStripMenuItem,
            this.tsmiServiseri});
            resources.ApplyResources(this.menuIzbornik, "menuIzbornik");
            this.menuIzbornik.Name = "menuIzbornik";
            // 
            // tsmiAplikacija
            // 
            this.tsmiAplikacija.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZakljucaj,
            this.tsmiIzlaz});
            this.tsmiAplikacija.Name = "tsmiAplikacija";
            resources.ApplyResources(this.tsmiAplikacija, "tsmiAplikacija");
            // 
            // tsmiZakljucaj
            // 
            this.tsmiZakljucaj.Name = "tsmiZakljucaj";
            resources.ApplyResources(this.tsmiZakljucaj, "tsmiZakljucaj");
            this.tsmiZakljucaj.Click += new System.EventHandler(this.tsmiZakljucaj_Click);
            // 
            // tsmiIzlaz
            // 
            this.tsmiIzlaz.Name = "tsmiIzlaz";
            resources.ApplyResources(this.tsmiIzlaz, "tsmiIzlaz");
            this.tsmiIzlaz.Click += new System.EventHandler(this.tsmiIzlaz_Click);
            // 
            // tsmiVozila
            // 
            this.tsmiVozila.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledVozila,
            this.tsmiBazaV});
            this.tsmiVozila.Name = "tsmiVozila";
            resources.ApplyResources(this.tsmiVozila, "tsmiVozila");
            // 
            // tsmiPregledVozila
            // 
            this.tsmiPregledVozila.Name = "tsmiPregledVozila";
            resources.ApplyResources(this.tsmiPregledVozila, "tsmiPregledVozila");
            this.tsmiPregledVozila.Click += new System.EventHandler(this.tsmiPregledVozila_Click);
            // 
            // tsmiBazaV
            // 
            this.tsmiBazaV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMarka,
            this.tsmiDijelovi,
            this.tsmiUsluge});
            this.tsmiBazaV.Name = "tsmiBazaV";
            resources.ApplyResources(this.tsmiBazaV, "tsmiBazaV");
            // 
            // tsmiMarka
            // 
            this.tsmiMarka.Name = "tsmiMarka";
            resources.ApplyResources(this.tsmiMarka, "tsmiMarka");
            this.tsmiMarka.Click += new System.EventHandler(this.tsmiMarka_Click);
            // 
            // tsmiDijelovi
            // 
            this.tsmiDijelovi.Name = "tsmiDijelovi";
            resources.ApplyResources(this.tsmiDijelovi, "tsmiDijelovi");
            // 
            // tsmiUsluge
            // 
            this.tsmiUsluge.Name = "tsmiUsluge";
            resources.ApplyResources(this.tsmiUsluge, "tsmiUsluge");
            // 
            // vlasniciToolStripMenuItem
            // 
            this.vlasniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledVlasnika});
            this.vlasniciToolStripMenuItem.Name = "vlasniciToolStripMenuItem";
            resources.ApplyResources(this.vlasniciToolStripMenuItem, "vlasniciToolStripMenuItem");
            // 
            // tsmiPregledVlasnika
            // 
            this.tsmiPregledVlasnika.Name = "tsmiPregledVlasnika";
            resources.ApplyResources(this.tsmiPregledVlasnika, "tsmiPregledVlasnika");
            this.tsmiPregledVlasnika.Click += new System.EventHandler(this.tsmiPregledVlasnika_Click);
            // 
            // tsmiServiseri
            // 
            this.tsmiServiseri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledServisera});
            this.tsmiServiseri.Name = "tsmiServiseri";
            resources.ApplyResources(this.tsmiServiseri, "tsmiServiseri");
            // 
            // tsmiPregledServisera
            // 
            this.tsmiPregledServisera.Name = "tsmiPregledServisera";
            resources.ApplyResources(this.tsmiPregledServisera, "tsmiPregledServisera");
            this.tsmiPregledServisera.Click += new System.EventHandler(this.tsmiPregledServisera_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuIzbornik);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuIzbornik;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuIzbornik.ResumeLayout(false);
            this.menuIzbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuIzbornik;
        private System.Windows.Forms.ToolStripMenuItem tsmiAplikacija;
        private System.Windows.Forms.ToolStripMenuItem tsmiZakljucaj;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzlaz;
        private System.Windows.Forms.ToolStripMenuItem tsmiVozila;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledVozila;
        private System.Windows.Forms.ToolStripMenuItem tsmiBazaV;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarka;
        private System.Windows.Forms.ToolStripMenuItem vlasniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledVlasnika;
        private System.Windows.Forms.ToolStripMenuItem tsmiServiseri;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledServisera;
        private System.Windows.Forms.ToolStripMenuItem tsmiDijelovi;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsluge;
    }
}

