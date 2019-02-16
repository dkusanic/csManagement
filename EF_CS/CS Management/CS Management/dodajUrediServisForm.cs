using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Management
{
    public partial class dodajUrediServisForm : Form
    {
        int selektiranoVozilo;
        int prijavljeniServiser;
        int servisId = -1;
        List<Stavka_servisa> stavke_Servisa = new List<Stavka_servisa>();

        Servis servis = new Servis();
        
        public dodajUrediServisForm(int servisId)
        {
            this.servisId = servisId;

            InitializeComponent();

            using (var context = new CS_ManagementModel())
            {
                var servisi = context.Servis.ToList();
                List<Stavka_servisa> stavke = context.Stavka_servisa.ToList();
                foreach (Stavka_servisa st in stavke)
                {
                    if (st.ID_servis == servisId)
                        stavke_Servisa.Add(st);
                }
                foreach (Servis s in servisi)
                {
                    if(s.ID == servisId)
                    {
                        dtpDatumVrijeme.Value = s.Datum_vrijeme;
                        dtpDatumVrijeme.Enabled = false;
                        txtOpis.Text = s.Opis;
                    }
                    
                }
            }

            dgvStavkeServisa.DataSource = new BindingList<Stavka_servisa>(stavke_Servisa);
        }

        public dodajUrediServisForm(int selektiranoVozilo, int prijavljeniServiser)
        {
            this.selektiranoVozilo = selektiranoVozilo;
            this.prijavljeniServiser = prijavljeniServiser;   

            InitializeComponent();

            using (var context = new CS_ManagementModel())
            {
                var dijelovi = context.Dijelovi.ToList();
                cmbDio.DataSource = new BindingList<Dijelovi>(dijelovi);
                cmbDio.DisplayMember = "Naziv";
                cmbDio.ValueMember = "ID";

                var usluge = context.Usluge.ToList();
                cmbUsluga.DataSource = new BindingList<Usluge>(usluge);
                cmbUsluga.DisplayMember = "Naziv";
                cmbUsluga.ValueMember = "ID";
            }
        }
        /// <summary>
        /// Metoda koaj rukuje klikom na tipku Dodaj stavku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            Stavka_servisa stavka_Servisa = new Stavka_servisa();            

            using (var context = new CS_ManagementModel())
            {
                var dioID = (object)cmbDio.SelectedItem.GetType().GetProperty("ID").GetValue(cmbDio.SelectedItem, null);
                var uslugaID = (object)cmbUsluga.SelectedItem.GetType().GetProperty("ID").GetValue(cmbUsluga.SelectedItem, null);

                if (chbOmogucenUsluga.Checked)
                {
                    stavka_Servisa.ID_usluga = (int)uslugaID;
                }
                else
                {
                    stavka_Servisa.ID_dio = (int)dioID;
                }
            }

            // stavka_Servisa.ID_servis = servis.ID;
            stavka_Servisa.Kolicina = (double)nudKolicina.Value;
            stavke_Servisa.Add(stavka_Servisa);

            dgvStavkeServisa.DataSource = null;
            dgvStavkeServisa.DataSource = stavke_Servisa;
        }
        /// <summary>
        /// Metoda koaj rukuje klikom na tipku Spremi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            servis.ID_serviser = prijavljeniServiser;
            servis.ID_vozilo = selektiranoVozilo;
            servis.Opis = txtOpis.Text;
            servis.Datum_vrijeme = dtpDatumVrijeme.Value;

            using (var context = new CS_ManagementModel())
            {
                context.Servis.Add(servis);
                context.SaveChanges();
            }

            using (var context = new CS_ManagementModel())
            {
                foreach (Stavka_servisa stavka in stavke_Servisa)
                {
                    stavka.ID_servis = servis.ID;
                    context.Stavka_servisa.Add(stavka);
                }

                context.SaveChanges();
            }


            dgvStavkeServisa.DataSource = null;
            dgvStavkeServisa.DataSource = stavke_Servisa;
            this.Close();
        }
        /// <summary>
        /// Metoda koja rukuje klikom na checkbox Omogućeno. Omogućuje unos ili dijela ili usluge za stavku servisa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbOmogucenUsluga_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOmogucenUsluga.Checked)
            {
                cmbUsluga.Enabled = true;
                cmbDio.Enabled = false;
            }
            else
            {
                cmbUsluga.Enabled = false;
                cmbDio.Enabled = true;
            }
        }

        private void cmbDio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUsluga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajUrediServisForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet11.Stavka_servisa' table. You can move, or remove it, as needed.
            this.stavka_servisaTableAdapter.Fill(this.cS_ManagementDataSet11.Stavka_servisa);

        }
        /// <summary>
        /// Metoda koja rukuje klikom na tipku Izlaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
