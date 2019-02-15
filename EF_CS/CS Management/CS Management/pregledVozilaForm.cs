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
        public pregledVozilaForm()
        {
            InitializeComponent();
        }

        private void pregledVozilaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet1.Servis' table. You can move, or remove it, as needed.
            this.servisTableAdapter.Fill(this.cS_ManagementDataSet1.Servis);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet.voziloView' table. You can move, or remove it, as needed.
            this.voziloViewTableAdapter.Fill(this.cS_ManagementDataSet.voziloView);
        }
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
            pregledServisa(dgvPregledVozila.CurrentRow.Index + 1);
        }
    }
}
