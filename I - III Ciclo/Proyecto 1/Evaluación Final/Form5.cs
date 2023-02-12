using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación_Final
{
    public partial class frmLogin : Form
    {

        frmRegistrarUsuario ra;
        frmRecuperarAccount rc;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();

            us.usuario_email = txtUsuario.Text;
            us.usuario_password = txtPassword.Text;

            frmMain main = new frmMain();

            if ((Usuario_C.buscarUsuario(us)))
            {
                frmLogin fr = new frmLogin();
                fr.Dispose();
                main.Show();
                lblErrorUsuario.Text = "";
                lblErrorPassword.Text = "";
            }
            else
            {
                lblErrorPassword.Text = "Contraseña Incorrecta";
                lblErrorUsuario.Text = "Usuario No Existente";
            }

        }

        private void lblOlvidePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            rc = new frmRecuperarAccount();
            rc.Show();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            ra = new frmRegistrarUsuario();
            ra.Show();
        }
    }
}
