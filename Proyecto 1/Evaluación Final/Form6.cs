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
    public partial class frmRegistrarUsuario : Form
    {

        frmLogin frml;

        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();

            if (Helper.ValidedCreateAccount(txt: txtUsuario, lbl: lblErrorUsuario))
            {

            }

            us.usuario_email = txtUsuario.Text.ToLower();
            us.usuario_password = txtPassword.Text;
            us.pregunta_id = Pregunta_C.ObtenerCodigoByName(cmbPregunta.Text).Pregunta_id;
            us.usuario_respuesta = txtRespuesta.Text.ToLower();

            //MessageBox.Show($"{us.usuario_email} | {us.usuario_password} | {us.pregunta_id} | {us.usuario_respuesta}");

            Usuario_C.RegistrarUsuario(us);

            MessageBox.Show("Usuario Registrado Correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();

            frml = new frmLogin();

            frml.Show();

        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            Pregunta_C.ListarPreguntas().ForEach(p =>
            {
                cmbPregunta.Items.Add(p.Pregunta_elegir);
            });
            cmbPregunta.SelectedIndex = 0;
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {

            this.Dispose();

            frmLogin l = new frmLogin();

            l.Show();
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {

            if(String.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                lblErrorUsuario.Text = "Este Campo es Obligatorio.";
            }

            Usuario_C.UsuarioExistent(txtUsuario);
        }
    }
}
