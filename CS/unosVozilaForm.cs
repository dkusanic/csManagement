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
    public partial class unosVozilaForm : Form
    {
        BindingList<Marka> popisMarki = new BindingList<Marka>();
        BindingList<Model> popisModela = new BindingList<Model>();
        BindingList<Varijanta> popisVarijanti = new BindingList<Varijanta>();
        BindingList<voziloView> listaVozila = new BindingList<voziloView>();
        public unosVozilaForm()
        {
            InitializeComponent();
        }

        private void unosVozilaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet7.Varijanta' table. You can move, or remove it, as needed.
            this.varijantaTableAdapter.Fill(this.cS_ManagementDataSet7.Varijanta);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet6.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter1.Fill(this.cS_ManagementDataSet6.Model);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet3.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.cS_ManagementDataSet3.Model);
            // TODO: This line of code loads data into the 'cS_ManagementDataSet2.Marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter.Fill(this.cS_ManagementDataSet2.Marka);
            popuniMarke();
            cmbMarka.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
        }
        private void popuniMarke()
        {
            popisMarki = null;
            using (var db=new CS_ManagementEntities())
            {
                popisMarki = new BindingList<Marka>(db.Marka.ToList());
            }
            markaBindingSource.DataSource = popisMarki;
        }
        private void popuniModele(int index)
        {
            popisModela = null;
            using (var db = new CS_ManagementEntities())
            {
                popisModela = new BindingList<Model>(db.Model.ToList());
            }
            BindingList<Model> filterModel = new BindingList<Model>();
            foreach(Model m in popisModela)
            {
                if (m.ID_marke == index)
                    filterModel.Add(m);
            }
            modelBindingSource.DataSource = filterModel;
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniModele(cmbMarka.SelectedIndex+1);
        }

        private void btnSpremiVozilo_Click(object sender, EventArgs e)
        {
            
            using (var db = new CS_ManagementEntities())
            {
                var nv = new Vozilo()
                {
                    
                    VIN = txtBrojSasije.Text,
                    Reg_oznaka = txtRegOznaka.Text,
                    Reg_do = dtpRegDo.Value,
                    God_proizvodnje = dtpGodProizvodnje.Value,
                    ID_varijante = cmbVarijanta.SelectedIndex,
                };
                db.Vozilo.Add(nv);                
                db.SaveChanges();
            }
            
            
        }
        private void dodajVozilo()
        {
            listaVozila = null;
            using (var db = new CS_ManagementEntities())
            {
                listaVozila = new BindingList<voziloView>(db.voziloView.ToList());
            }
            
        }
    }
}
