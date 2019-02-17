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
    public partial class pregledServiseraForm : Form
    {
        public pregledServiseraForm()
        {
            InitializeComponent();
        }

        private void dodajUrediServiseraForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet13.Serviser' table. You can move, or remove it, as needed.
            this.serviserTableAdapter.Fill(this.cS_ManagementDataSet13.Serviser);

        }
    }
}
