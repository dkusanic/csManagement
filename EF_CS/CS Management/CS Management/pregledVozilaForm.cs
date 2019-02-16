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
    public partial class pregledVozilaForm : Form
    {
        BindingList<voziloView> listaVozila = new BindingList<voziloView>();
        BindingList<Servis> listaServisa = new BindingList<Servis>();
        Serviser serviser;
        public pregledVozilaForm(Serviser prijavljeniServiser)
        {
            this.serviser = prijavljeniServiser;
            InitializeComponent();
        }

        private void pregledVozilaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet1.Servis' table. You can move, or remove it, as needed.
            this.servisTableAdapter.Fill(this.cS_ManagementDataSet1.Servis);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet.voziloView' table. You can move, or remove it, as needed.
            this.voziloViewTableAdapter.Fill(this.cS_ManagementDataSet.voziloView);
        }
        /// <summary>
        /// Metoda koja dohvaća servise odabranog vozila
        /// </summary>
        /// <param name="index"></param>
        private void pregledServisa(int index)
        {
            listaServisa = null;
            using (var db = new CS_ManagementModel())
            {
                listaServisa = new BindingList<Servis>(db.Servis.ToList());
            }
            List<Servis> servisiVozila = new List<Servis>();
            foreach (Servis s in listaServisa)
            {
                if (s.ID_vozilo == index)
                    servisiVozila.Add(s);

            }
            servisBindingSource.DataSource = servisiVozila;
        }

        private void dgvPregledVozila_SelectionChanged(object sender, EventArgs e)
        {
            pregledServisa((int)dgvPregledVozila.CurrentRow.Cells[0].Value);
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            dodajUrediVoziloForm dodajVozilo = new dodajUrediVoziloForm();
            dodajVozilo.WindowState = FormWindowState.Maximized;
            dodajVozilo.MdiParent = this.MdiParent;
            dodajVozilo.Show();
        }

        private void btnUrediVozilo_Click(object sender, EventArgs e)
        {
            int voziloId = 0;

            if (dgvPregledVozila.CurrentRow != null)
            {
                voziloId = (int)dgvPregledVozila.CurrentRow.Cells[0].Value;
            }

            dodajUrediVoziloForm urediVozilo = new dodajUrediVoziloForm(voziloId);
            urediVozilo.WindowState = FormWindowState.Maximized;
            urediVozilo.MdiParent = this.MdiParent;
            urediVozilo.Show();
        }

        private void btnDodajServis_Click(object sender, EventArgs e)
        {
            int idVozila = (int)dgvPregledVozila.CurrentRow.Cells[0].Value;
            dodajUrediServisForm dodajServis = new dodajUrediServisForm(idVozila, serviser.ID);
            dodajServis.WindowState = FormWindowState.Maximized;
            dodajServis.MdiParent = this.MdiParent;
            dodajServis.Show();
        }

        private void btnUrediServis_Click(object sender, EventArgs e)
        {
            int idServisa = (int)dgvPopisServisa.CurrentRow.Cells[0].Value;
            dodajUrediServisForm urediServis = new dodajUrediServisForm(idServisa);
            urediServis.WindowState = FormWindowState.Maximized;
            urediServis.MdiParent = this.MdiParent;
            urediServis.Show();
        }
    }
}
