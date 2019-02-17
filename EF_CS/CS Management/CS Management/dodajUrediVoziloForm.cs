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
    public partial class dodajUrediVoziloForm : Form
    {
        int pomIndex = 0;
        int indexVozila = -1;
        Vozilo voziloKojeAzuriramo;
        public dodajUrediVoziloForm()
        {
            InitializeComponent();
        }
        public dodajUrediVoziloForm(int index)
        {
            InitializeComponent();
            indexVozila = index;
            using (var context = new CS_ManagementModel())
            {
                List<Vozilo> listaSvihVozila = new List<Vozilo>(context.Vozilo.ToList());
                List<Varijanta> listaVarijanti = new List<Varijanta>(context.Varijanta.ToList());
                List<Model> listaModela = new List<Model>(context.Model.ToList());
                List<Marka> listaMarki = new List<Marka>(context.Marka.ToList());
                foreach (Vozilo v in listaSvihVozila)
                {
                    if (v.ID == index)
                    {
                        voziloKojeAzuriramo = v;
                        txtBrojSasije.Text = v.VIN;
                        txtBrojSasije.ReadOnly = true;
                        txtRegOznaka.Text = v.Reg_oznaka;
                        dtpRegDo.Value = Convert.ToDateTime(v.Reg_do);
                        dtpGodProizvodnje.Value = Convert.ToDateTime(v.God_proizvodnje);
                        dtpGodProizvodnje.Enabled = false;
                        foreach(Varijanta var in listaVarijanti)
                        {
                            if (v.ID_varijante == var.ID)
                            {
                                cmbVarijanta.Text = var.ToString();
                                cmbVarijanta.Enabled = false;
                                foreach (Model m in listaModela)
                                {
                                    if (var.ID_modela == m.ID)
                                    {
                                        cmbModel.Text = m.Naziv;
                                        cmbModel.Enabled = false;
                                        foreach (Marka mar in listaMarki)
                                        {
                                            if (m.ID_marke == mar.ID)
                                            {
                                                cmbMarka.Text = mar.Naziv;
                                                cmbMarka.Enabled = false;
                                            }
                                        }
                                    }
                                }
                            }
                                
                        }
                    }
                }
            }
        }

        private void dodajUrediVoziloForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet10.voziloView' table. You can move, or remove it, as needed.
            //this.voziloViewTableAdapter.Fill(this.cS_ManagementDataSet10.voziloView);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet9.Varijanta' table. You can move, or remove it, as needed.
            //this.varijantaTableAdapter.Fill(this.cS_ManagementDataSet9.Varijanta);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet8.Model' table. You can move, or remove it, as needed.
            //this.modelTableAdapter.Fill(this.cS_ManagementDataSet8.Model);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet7.Marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter.Fill(this.cS_ManagementDataSet7.Marka);

        }
        /// <summary>
        /// Metoda koja dohvaća modele odabrane marke
        /// </summary>
        /// <param name="index"></param>
        private void popuniModele(int index)
        {
            BindingList<Model> listaModela = new BindingList<Model>();
            BindingList<Model> modeliMarke = new BindingList<Model>();
            using (var context = new CS_ManagementModel())
            {
                var Modeli = context.Model.ToList();
                foreach (Model m in Modeli)
                {
                    if (m.ID_marke == index)
                        modeliMarke.Add(m);
                }
            }
            cmbModel.DataSource = modeliMarke;
            cmbModel.DisplayMember = "Naziv";
            cmbModel.ValueMember = "ID";

        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbVarijantaBindingSource.DataSource = null;
            int markaId = cmbMarka.SelectedIndex + 1;
            popuniModele(markaId);
        }
        /// <summary>
        /// Metoda koja dohvaća varijante odabranog modela
        /// </summary>
        /// <param name="index"></param>
        private void popuniVarijante(int index)
        {
            BindingList<Varijanta> Varijante = new BindingList<Varijanta>();
            BindingList<Varijanta> varijanteModela = new BindingList<Varijanta>();
            using (var context = new CS_ManagementModel())
            {
                var Varijant = context.Varijanta.ToList();
                foreach (Varijanta v in Varijant)
                {
                    if (v.ID_modela == index)
                        varijanteModela.Add(v);
                }
            }
            cmbVarijanta.DataSource = varijanteModela;
            cmbVarijanta.ValueMember = "ID";
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedIndex > -1)
            {
                int index;
                using (var context = new CS_ManagementModel())
                {
                    var comboBox = sender as ComboBox;
                    var value = cmbModel.SelectedItem;
                    var modelId = (object)value.GetType().GetProperty("ID").GetValue(value, null);
                    index = (int)modelId;
                }
                cmbVarijanta.DataSource = null;
                popuniVarijante(index);
                pomIndex = index;
            }
        }
        /// <summary>
        /// Metoda koja rukuje klikom na tipku Spremi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(indexVozila > -1)
            {                
                voziloKojeAzuriramo.Reg_oznaka = txtRegOznaka.Text;
                voziloKojeAzuriramo.Reg_do = dtpRegDo.Value;
                using (var context = new CS_ManagementModel())
                {
                    context.Entry(voziloKojeAzuriramo).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }

            else
            {
                Vozilo novoVozilo = new Vozilo();
                novoVozilo.VIN = txtBrojSasije.Text;
                novoVozilo.Reg_oznaka = txtRegOznaka.Text;
                novoVozilo.Reg_do = dtpRegDo.Value;
                novoVozilo.God_proizvodnje = dtpGodProizvodnje.Value;
                novoVozilo.ID_varijante = pomIndex;
                using (var context = new CS_ManagementModel())
                {
                    context.Vozilo.Add(novoVozilo);
                    context.SaveChanges();
                }
            }
            this.Close();
        }

        private void cmbVarijanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVarijanta.SelectedIndex > -1)
            {
                using (var context = new CS_ManagementModel())
                {
                    var comboBox = sender as ComboBox;
                    var value = cmbVarijanta.SelectedItem;
                    var modelId = (object)value.GetType().GetProperty("ID").GetValue(value, null);
                    pomIndex = (int)modelId;
                }
            }
        }
        /// <summary>
        /// Metoda koja rukuje klikom na tipku Odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
