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
    public partial class frmRegistroCompra : Form
    {
        public frmRegistroCompra()
        {
            InitializeComponent();
        }

        private void enviar(KeyPressEventArgs tecla, Control foco)
        {
            if (tecla.KeyChar == 13)
            {
                foco.Focus();
            }
        }
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            if (txtDP.Text=="" || txtCantidad.Text=="" || txtCP.Text=="" || txtDP.Text=="" || txtNP.Text=="" || 
                                  txtNprod.Text=="" || txtPCprov.Text=="" || txtPVprov.Text=="" || cbCateg.SelectedIndex==-1)
            {
                MessageBox.Show("CAMPOS IMCOMPLETOS", "ATENCIÓN");
            }
            else
            {
                MessageBox.Show("Registro Exitoso", "Información");
                borrar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }

        void borrar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            txtDP.Focus();
            cbCateg.SelectedIndex = -1;
        }

        private void txtDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtCP);
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, cbCateg);
        }

        private void cbCateg_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtPVprov);
        }

        private void txtPVprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtNP);
        }

        private void txtNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtNprod);
        }

        private void txtNprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtPCprov);
        }

        private void txtPCprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtCantidad);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnRegistra);
        }
    }
}
