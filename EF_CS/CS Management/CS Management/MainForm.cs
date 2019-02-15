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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.ShowDialog();
            provjeraAdmin(login.admin);
        }
        /// <summary>
        /// Skrivanje admin funkcionalnosti od servisera
        /// </summary>
        /// <param name="b">Parametar tipa bool koji se predaje u login formi</param>
        private void provjeraAdmin (bool b)
        {
            if (b==false)
            {
                tsmiBazaS.Visible = false;
                tsmiBazaV.Visible = false;
                tsmiServiseri.Visible = false;
            }
            else
            {
                tsmiBazaS.Visible = true;
                tsmiBazaV.Visible = true;
                tsmiServiseri.Visible = true;
            }
        }
        /// <summary>
        /// Rukuje klikom u izborniku na Aplikacija-Izlaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiZakljucaj_Click(object sender, EventArgs e)
        {
            MainForm_Load(this, new EventArgs());
        }
    }
}
