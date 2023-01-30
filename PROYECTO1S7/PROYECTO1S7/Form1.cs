using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1S7
{
    public partial class frmCondionales : Form
    {
        public frmCondionales()
        {
            InitializeComponent();
        }

        private void frmCondionales_Load(object sender, EventArgs e)
        {
            cmbProductos.Items.Add("ACEITE");
            cmbProductos.Items.Add("HARINA");
            cmbProductos.Items.Add("CEBOLLA");

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex == 0)
            {
                txtPrecio.Text = "15";
            }
            else if (cmbProductos.SelectedIndex == 1)
            {
                txtPrecio.Text = "120";
            }
            else
            {
                txtPrecio.Text = "3.50";
            }

            if (cmbProductos.SelectedItem.ToString() == "ACEITE" || cmbProductos.SelectedItem.ToString() == "HARINA")
            {
                txtDescuento.Text = "5%";
            }
            else
            {
                txtDescuento.Text = "10%";
            }
            txtcantidad.Focus();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                double precio_unitario = double.Parse(txtPrecio.Text);
                double cantidad = int.Parse(txtcantidad.Text);
                double resultado = precio_unitario * cantidad;
                txttotal.Text = resultado.ToString();
                if(cmbProductos.SelectedItem.ToString() =="ACEITE" || cmbProductos.SelectedItem.ToString() == "HARINA")
                {
                    double vdes =( resultado * 5 )/ 100;
                    txtdes.Text=vdes.ToString();
                    txtneto.Text = (resultado - vdes).ToString(); 
                }
                else if (cmbProductos.SelectedItem.ToString() == "CEBOLLA")
                {
                    double vdes = (resultado * 10) / 100;
                    txtdes.Text = vdes.ToString();
                    txtneto.Text = (resultado - vdes).ToString();
                }
            }
        }
    }
}
