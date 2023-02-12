using System;
using System.Windows.Forms;

namespace j2b_Proyect
{
    public partial class frmLogin : Form
    {
        frmPrincipal frmPrincipal;

        frmPrincipal principal;



        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, System.EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();

            for (int i = 0; i <= principal.usuario.Length; i++)
            {
                try
                {
                    if (principal.usuario[i] == txtUsuario.Text && principal.contraseña[i] == txtContrasena.Text)
                    {
                        frmPrincipal = new frmPrincipal();
                        frmPrincipal.nombre = txtUsuario.Text;
                        frmPrincipal.Show();
                        this.Hide();
                        break;
                    }
                }
                catch
                {
                    MessageBox.Show("Error usuario o contraseña no validas", "Error al acceder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        { 

            if (MessageBox.Show("¿Está Seguro de que quieres Salir?", "Salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
