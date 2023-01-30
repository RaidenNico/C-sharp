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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Creamos un combo box y segun la opcion a escoger se agregaran los datos de la empresa
            if(cbProveedor.SelectedIndex == 0)
            {
                txtRazonSocial.Text = "Corporacion Agrolatina S.A.C";
                txtRuc.Text = "20176770474";
                txtWeb.Text = "http://www.corpagrolatina.com";
                txtDireccion.Text = "Av. Manuel Olguin Nro. 335 (Edificio Link Tower Oficina 102)";
                txtDistrito.Text = "Santiago de Surco";
                txtDepartamento.Text = "Lima, Perú";
                textNumero.Text = "01363399";
            }
            if (cbProveedor.SelectedIndex == 1)
            {
                txtRazonSocial.Text = "Natural Foods & Fruits S.A.C";
                txtRuc.Text = "20511983101";
                txtWeb.Text = "http://www.naturalfoods.com";
                txtDireccion.Text = "Av. Aviacion Nro. 631";
                txtDistrito.Text = "La Victoria";
                txtDepartamento.Text = "Lima, Perú";
                textNumero.Text = "014582685";
            }
            if (cbProveedor.SelectedIndex == 2)
            {
                txtRazonSocial.Text = "Snacks America Latina S.R.L";
                txtRuc.Text = "20297182456";
                txtWeb.Text = "http://www.snackslatina.com";
                txtDireccion.Text = "Av. Bolognesi Nro. 550 (a Una Cdra del Ovalo Santa Anita)";
                txtDistrito.Text = "Santa Anita";
                txtDepartamento.Text = "Lima, Perú";
                textNumero.Text = "014782103";
            }
            if (cbProveedor.SelectedIndex == 3)
            {
                txtRazonSocial.Text = "Corporacion Vega S.A.C";
                txtRuc.Text = "20502257987";
                txtWeb.Text = "http://www.corporacionvega.com.pe";
                txtDireccion.Text = "Jr. Belaunde Oeste Nro. 198 Huaquillay (Alt.Km.12 Av.Tupac Amaru)";
                txtDistrito.Text = "Comas";
                txtDepartamento.Text = "Lima, Perú";
                textNumero.Text = "015363990";
            }
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se envio un correo electronico a la empresa","Aviso");
        }
    }
}
