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

        void enviar(KeyPressEventArgs e, Control foco)
        {
            if (e.KeyChar == 13)
            {
                foco.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Agregado por Cesar -- Pregunta para salir del Login
            DialogResult respuesta = MessageBox.Show("¿Desea Salir del Programa?", "Cerrar Programa", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassw.Text == "admin")
            {
                frmPrincipal principal = new frmPrincipal();
                this.Hide();
                principal.ShowDialog();
                //Agrego este comando porque cuando se llama al método Hide(), solo se esconde la ventana de 
                //login, lo que provoca que el progama se cierre solo si presionamos el botón SALIR en el menú principal
                this.Close();
            }
            //Mensaje de error en caso ingrese datos incorrectos
            else
            {
                MessageBox.Show("A ingresado datos incorrectos" + "\n" + "O el usuario no se encuentra registrado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Text = "";
                txtPassw.Text = "";
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtPassw);
        }

        private void txtPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enviar(e, btnInSesion);
            if (e.KeyChar == 13)
            {
                btnInSesion_Click(this, new EventArgs()); //Enter, directo al programa.
            }
        }
    }
}
