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
            BindingList<Vozilo> listaVozila = null;
            BindingList<Servis> listaServisa = null;
            using (var db = new CS_ManagementEntities())
            {
                listaVozila = new BindingList<Vozilo>(db.Vozilo.ToList());
                listaServisa = new BindingList<Servis>(db.Servis.ToList());
            }
            voziloBindingSource.DataSource = listaVozila;
            servisBindingSource.DataSource = listaServisa;
        }
    }
}
