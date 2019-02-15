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
    public partial class markaForm : Form
    {
        public markaForm()
        {
            InitializeComponent();
        }

        private void markaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cS_ManagementDataSet2.Marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter.Fill(this.cS_ManagementDataSet2.Marka);

        }
    }
}
