using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CS
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = korisnikTextbox;
        }

        private void lozinkaTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prijavaButton_Click(this, new EventArgs());
            }
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            using (var context = new CS_ManagementEntities())
            {
                var serviser = context.Serviser.Where(s => s.Kor_ime == korisnikTextbox.Text).FirstOrDefault<Serviser>();
                if (serviser != null)
                {
                    if (serviser.Lozinka == lozinkaTextbox.Text)
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
