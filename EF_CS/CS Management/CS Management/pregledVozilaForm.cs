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
            // TODO: This line of code loads data into the 'cS_ManagementDataSet.voziloView' table. You can move, or remove it, as needed.
            this.voziloViewTableAdapter.Fill(this.cS_ManagementDataSet.voziloView);

        }
        private void pregledVozila()
        {
            listaVozila = null;
            using (var context = new CS_ManagementModel())
            {
                listaVozila = new BindingList<voziloView>(context.voziloView.ToList());
            }
            voziloViewBindingSource.DataSource = listaVozila;
        }
    }
}
