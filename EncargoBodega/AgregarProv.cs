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
    public partial class frmAgProv : Form
    {
        public frmAgProv()
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

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumDoc.Text = "";
            if (cmbTipoDoc.SelectedIndex == 0)
            {
                txtNumDoc.ReadOnly = true;
            }
            else
            {
                txtNumDoc.ReadOnly = false;
            } 
            
            
            if (cmbTipoDoc.SelectedIndex == 1)
            {
                txtNumDoc.MaxLength = 8;
            }
            else if (cmbTipoDoc.SelectedIndex == 2)
            {
                txtNumDoc.MaxLength = 11;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDoc.SelectedIndex != -1 && cmbCategoria.SelectedIndex != -1)
            {

                if (cmbTipoDoc.SelectedIndex == 0)
                {
                    if (txtRazonSocial.Text == String.Empty ||
                    txtContacto.Text == String.Empty ||
                    txtEmail.Text == String.Empty ||
                    txtTelefono.Text == String.Empty ||
                    txtDireccion.Text == String.Empty ||
                    cmbCategoria.Text == String.Empty)
                    {
                        MessageBox.Show("Falta ingresar datos requeridos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Registro Guardado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (txtNumDoc.Text == String.Empty ||
                    txtRazonSocial.Text == String.Empty ||
                    txtContacto.Text == String.Empty ||
                    txtEmail.Text == String.Empty ||
                    txtTelefono.Text == String.Empty ||
                    txtDireccion.Text == String.Empty ||
                    cmbCategoria.Text == String.Empty)
                    {
                        MessageBox.Show("Falta ingresar datos requeridos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Registro Guardado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Falta ingresar datos requeridos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtRazonSocial);

            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            //cambio hecho por César: Se deselecciona cualquier item que anteriomente se encontrara seleccionado
            //del combobox
            cmbCategoria.SelectedIndex = -1;
            cmbTipoDoc.SelectedIndex = -1;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtDireccion);
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Mensaje = MessageBox.Show("¿Desea salir?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Mensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbTipoDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtNumDoc);
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtContacto);
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtEmail);
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtTelefono);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, cmbCategoria);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnGuardar);
        }

        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnNuevo);
        }

        private void btnNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnSalir);
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmAgProv_Load(object sender, EventArgs e)
        {

        }
    }
}
