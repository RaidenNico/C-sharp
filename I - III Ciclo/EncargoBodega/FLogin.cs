using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncargoBodega
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassw.Text == "admin")
            {
                this.Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
            }
        }
    }
}
