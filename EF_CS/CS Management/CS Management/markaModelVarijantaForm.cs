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
    public partial class markaModelVarijantaForm : Form
    {
        public markaModelVarijantaForm()
        {
            InitializeComponent();
        }

        private void markaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet6.Marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter2.Fill(this.cS_ManagementDataSet6.Marka);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet5.Marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter1.Fill(this.cS_ManagementDataSet5.Marka);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet4.Varijanta' table. You can move, or remove it, as needed.
            this.varijantaTableAdapter.Fill(this.cS_ManagementDataSet4.Varijanta);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet3.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.cS_ManagementDataSet3.Model);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet2.Marka' table. You can move, or remove it, as needed.
             this.markaTableAdapter.Fill(this.cS_ManagementDataSet2.Marka);
            
        }
        /// <summary>
        /// Metoda koja dohvaća modele odabrane marke
        /// </summary>
        /// <param name="index"></param>
        private void pregledModela(int markaId)
        {
            BindingList<Model> listaModela = new BindingList<Model>();
            BindingList<Model> modeliMarke = new BindingList<Model>();
            using (var context = new CS_ManagementModel())
            {
                var Modeli = context.Model.ToList();
                foreach (Model m in Modeli)
                {
                    if (m.ID_marke == markaId)
                        modeliMarke.Add(m);
                }
            }         
            modelBindingSource.DataSource = modeliMarke;

        }
        private void dgvMarke_SelectionChanged(object sender, EventArgs e)
        {
            varijantaBindingSource.DataSource = null;
            int markaId = (int)dgvMarke.CurrentRow.Cells[0].Value;
            pregledModela(markaId);
        }
        /// <summary>
        /// Metoda koja dohvaća varijante odabranog modela
        /// </summary>
        /// <param name="index"></param>
        private void pregledVarijanti(int modelId)
        {
            BindingList<Varijanta> Varijante = new BindingList<Varijanta>();
            BindingList<Varijanta> varijanteModela = new BindingList<Varijanta>();
            using (var context = new CS_ManagementModel())
            {
                var Varijant = context.Varijanta.ToList();
                foreach (Varijanta v in Varijant)
                {
                    if (v.ID_modela == modelId)
                        varijanteModela.Add(v);
                }
            }           
            varijantaBindingSource.DataSource = varijanteModela;
        }

        private void dgvModeli_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModeli.CurrentRow != null)
            {
                int modelId = (int)dgvModeli.CurrentRow.Cells[0].Value;
                pregledVarijanti(modelId);
            }
            
        }
    }
}
