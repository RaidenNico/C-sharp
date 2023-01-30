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
    public partial class frmRecuperarAccount : Form
    {

        frmLogin login;

        public frmRecuperarAccount()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();

            us.usuario_email = txtUsuario.Text.ToLower().Trim();
            us.pregunta_id = Pregunta_C.ObtenerCodigoByName(cmbPregunta.Text).Pregunta_id;
            us.usuario_respuesta = txtRespuesta.Text.ToLower().Trim();
            MessageBox.Show($"Su Contraseña es: {Usuario_C.ObtenerCodigoByName(us).usuario_password}  ||  {us.pregunta_id}", "Recuperación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void frmRecuperarAccount_Load(object sender, EventArgs e)
        {
            Pregunta_C.ListarPreguntas().ForEach(p =>
            {
                cmbPregunta.Items.Add(p.Pregunta_elegir);
            });
            cmbPregunta.SelectedIndex = 0;
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new frmLogin();
            login.Show();
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            lblErrorUsuario.Text = Usuario_C.UsuarioExistent(txtUsuario) ? "" : "Este Usuario no Existe";
        }

        private void txtRespuesta_Validating(object sender, CancelEventArgs e)
        {
            btnRecuperar.Enabled = String.IsNullOrWhiteSpace(txtRespuesta.Text.ToLower()) && lblErrorUsuario.Text == "" ? false : true;
        }
    }
}
