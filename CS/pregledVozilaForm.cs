using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS
{
    public partial class pregledVozilaForm : Form
    {
        public pregledVozilaForm()
        {
            InitializeComponent();
        }

        private void prikaziVozila()
        {
            
        }

        private void pregledVozilaForm_Load(object sender, EventArgs e)
        {
            pregledVozila();
            pregledServisa();
        }

        private void pregledVozila()
        {
            BindingList<Vozilo> listaVozila = null;
            using (var db = new CS_ManagementEntities())
            {
                listaVozila = new BindingList<Vozilo>(db.Vozilo.ToList());
            }
            voziloBindingSource.DataSource = listaVozila;
        }

        private void pregledServisa()
        {
            BindingList<Servis> listaServisa = null;
            using (var db = new CS_ManagementEntities())
            {
                listaServisa = new BindingList<Servis>(db.Servis.ToList());
            }
            servisBindingSource.DataSource = listaServisa;
        }

        private void vozilaDgv_SelectionChanged(object sender, EventArgs e)
        {
            pregledServisa();
        }
    }
}
