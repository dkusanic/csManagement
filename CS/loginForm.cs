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
            this.Close();
        }
    }
}
