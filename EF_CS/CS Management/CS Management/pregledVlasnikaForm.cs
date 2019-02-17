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
    public partial class pregledVlasnikaForm : Form
    {
        public pregledVlasnikaForm()
        {
            InitializeComponent();
        }

        private void dodajUrediVlasnikaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet12.Vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.Fill(this.cS_ManagementDataSet12.Vlasnik);

        }
    }
}
