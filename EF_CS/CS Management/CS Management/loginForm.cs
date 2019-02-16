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
    public partial class loginForm : Form
    {
        Serviser serviser;
        public bool admin = false;
        public loginForm(Serviser prijavljeniServiser)
        {
            serviser = prijavljeniServiser;
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtKorime;
        }
        /// <summary>
        /// Rukuje pritiskom tipke Enter na tipkovnici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPrijava_Click(this, new EventArgs());
        }
        /// <summary>
        /// Rukuje klikom na tipku "Prijava"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            using (var context = new CS_ManagementModel())
            {
                var prijavljeniServiser = context.Serviser.Where(s => s.Kor_ime == txtKorime.Text).FirstOrDefault<Serviser>();
                               
                if (prijavljeniServiser != null)
                {
                    if (prijavljeniServiser.Admin == true)
                        admin = true;
                    if (prijavljeniServiser.Kor_ime == txtKorime.Text && prijavljeniServiser.Lozinka == txtLozinka.Text)
                        this.Close();
                    else
                        MessageBox.Show("Pogrešno korisničko ime i/ili lozinka!\nPokušajte ponovno!");
                }
                else
                    MessageBox.Show("Pogrešno korisničko ime i/ili lozinka!\nPokušajte ponovno!");

                serviser.ID = prijavljeniServiser.ID;
                serviser.Ime = prijavljeniServiser.Ime;
                serviser.Kor_ime = prijavljeniServiser.Kor_ime;
                serviser.Lozinka = prijavljeniServiser.Lozinka;
                serviser.Prezime = prijavljeniServiser.Prezime;
                serviser.Servis = prijavljeniServiser.Servis;
                serviser.Admin = prijavljeniServiser.Admin;
            }
        }
        /// <summary>
        /// Metoda koja zatvara aplikaciju klikom na tipku "Izlaz"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
