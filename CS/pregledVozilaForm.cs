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
        BindingList<voziloView> listaVozila = new BindingList<voziloView>();
        BindingList<Servis> listaServisa = new BindingList<Servis>();
        public pregledVozilaForm()
        {
            InitializeComponent();
        }

        private void prikaziVozila()
        {
            
        }

        private void pregledVozilaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet1.voziloView' table. You can move, or remove it, as needed.
            this.voziloViewTableAdapter1.Fill(this.cS_ManagementDataSet1.voziloView);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet.voziloView' table. You can move, or remove it, as needed.
            this.voziloViewTableAdapter.Fill(this.cS_ManagementDataSet.voziloView);
            pregledVozila();
            pregledServisa();
        }

        private void pregledVozila()
        {
            listaVozila = null;
            using (var db = new CS_ManagementEntities())
            {
                listaVozila = new BindingList<voziloView>(db.voziloView.ToList());
            }
            voziloBindingSource.DataSource = listaVozila;
        }

        private void pregledServisa()
        {
            listaServisa = null;
            using (var db = new CS_ManagementEntities())
            {
                listaServisa = new BindingList<Servis>(db.Servis.ToList());
            }
            List<Servis> servisiVozila = new List<Servis>();
            foreach(Servis s in listaServisa)
            {
                for (int i=0; i<listaVozila.Count; i++)
                {
                    if (s.ID_vozilo == listaVozila[i].ID)
                        servisiVozila.Add(s);
                }
                
            }
            servisBindingSource.DataSource = servisiVozila;
        }
        private void pregledServisa(int index)
        {
            listaServisa = null;
            using (var db = new CS_ManagementEntities())
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
        private void vozilaDgv_SelectionChanged(object sender, EventArgs e)
        {
            pregledServisa(vozilaDgv.CurrentRow.Index+1);
        }
    }
}
