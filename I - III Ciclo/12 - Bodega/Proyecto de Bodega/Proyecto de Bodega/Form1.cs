using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Bodega
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void enviar(KeyPressEventArgs tecla, Control Foco)
        {
            if(tecla.KeyChar == 13)
            {
                Foco.Focus();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0); // Codigo para la transparencia de panel 
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("¿Esta seguro de ingresar al sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(txtUsuario.Text == "Admin")
            {
                if(textContra.Text == "123456")
                {
                    new frmPrincipal().Show(); //Nombre del formulario que se va a abrir si los datos son correctos
                    this.Hide();  //Escondemos el formulario Login
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto o no existe","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




            //if (txtUsuario.Text == "Admin" && textContra.Text == "123456");
            //DialogResult opcion = MessageBox.Show("¿Estas seguro de ingresar al sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (opcion == DialogResult.Yes)
            //    {
            //        Form formulario = new frmPrincipal();   // Creamos variable y llamamos al formulario principal
            //        formulario.Show();
            //    }
            //    else
            //    {
            //        Application.Exit();
            //    }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) // Creamos variable
        {
            //if (tecla.KeyChar == 13) // Si se preciona enter se tabulara
            //{
            //    textContra.Focus();
            //} 
            enviar(e, textContra);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te enviaremos tus datos de recuperacion a la dirección de correo electronica registrada con el usuario","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        //NO USAR
        ////Evento ENTER cuando el textBox este activo
        //private void txtUsuario_Enter(object sender, EventArgs e)
        //{
        //    //Llamamos la clase con metodo estatico e ingresamos los parametros
        //    PlaceHolder.Enter("Usuario", txtUsuario);
        //}

        //private void txtContra_Enter(object sender, EventArgs e)
        //{
        //    PlaceHolder.Enter("Contraseña", txtContra);
        //}

        //private void txtUsuario_Leave(object sender, EventArgs e)
        //{
        //    PlaceHolder.Leave("Usuario", txtUsuario);
        //}

        //private void txtContra_Leave(object sender, EventArgs e)
        //{
        //    PlaceHolder.Leave("Contraseña", txtContra);
        //}
    }
}
