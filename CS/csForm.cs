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
    public partial class csForm : Form
    {
        public csForm()
        {
            InitializeComponent();
        }

        private void csForm_Load_1(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.ShowDialog();
            provjeraAdmin(login.admin);
        }

        /// <summary>
        /// Rukuje klikom na gumb za izlaz iz aplikacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Skrivanje admin funkcionalnosti od servisera
        /// </summary>
        /// <param name="a">Parametar tipa bool koji se predaje u login formi</param>
        private void provjeraAdmin(bool a)
        {
            if(a==false)
            {
                bazaToolStripMenuItem.Visible = false;
                bazaToolStripMenuItem1.Visible = false;
                serviseriToolStripMenuItem.Visible = false;
            }
        }

        private void pregledVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pregledVozilaForm pregledVozila = new pregledVozilaForm();
            pregledVozila.WindowState = FormWindowState.Maximized;
            pregledVozila.MdiParent = this;
            pregledVozila.Show();
        }
    }
}
