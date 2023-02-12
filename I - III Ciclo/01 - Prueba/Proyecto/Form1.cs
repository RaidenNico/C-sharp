using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("¿Desea Salir de la Aplicación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "ADMIN" && txtPassword.Text == "123456")
            {
                DialogResult b;
                b = MessageBox.Show("¿Desea ingresar al Sistema?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(b == DialogResult.Yes)
                {
                    MessageBox.Show("Usted está ingresando al Sistema","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    frmPrincipal fp = new frmPrincipal();
                    fp.Show();
                }
                else if(b == DialogResult.No)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos. \nIntente nuevamente.","ERROR!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
