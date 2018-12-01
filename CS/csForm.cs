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
            
        }
    }
}
