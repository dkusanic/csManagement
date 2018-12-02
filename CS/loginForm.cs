using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CS
{
    public partial class loginForm : Form
    {
        public bool admin = false;
        public loginForm()
        {
            InitializeComponent();
        }

        public void loginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = korisnikTextbox;
            string korisnik = korisnikTextbox.Text;
            string lozinka = lozinkaTextbox.Text;
        }

        /// <summary>
        /// Rukuje pritiskom tipke Enter na tipkovnici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lozinkaTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prijavaButton_Click(this, new EventArgs());
            }
        }


        /// <summary>
        /// Rukuje klikom na gumb PRIJAVA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void prijavaButton_Click(object sender, EventArgs e)
        {
            using (var context = new CS_ManagementEntities())
            {
                var prijavljeniServiser = context.Serviser.Where(s => s.Kor_ime == korisnikTextbox.Text).FirstOrDefault<Serviser>();
                if (prijavljeniServiser != null)
                {
                    if (prijavljeniServiser.Admin == true)
                        admin = true;
                    if (prijavljeniServiser.Lozinka == lozinkaTextbox.Text)
                        this.Close();
                    else
                        MessageBox.Show("Netočna lozinka!");
                }
                else
                    MessageBox.Show("Nepostojeći korisnik!");
            }
        }
    }
}
