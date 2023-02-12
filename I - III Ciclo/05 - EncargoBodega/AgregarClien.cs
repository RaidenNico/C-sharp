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
    public partial class AgregarClien : Form
    {
        public AgregarClien()
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            cmbTipDoc.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Mensaje = MessageBox.Show("¿Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Mensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbTipDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtNumDoc);
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtNomAp);
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void txtNomAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtTelefono);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtDireccion);
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtEmail);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnNuevo);
        }

        private void btnNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnGuardar);
        }

        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnSalir);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTipDoc.SelectedIndex == 0)
            {
                if (txtEmail.Text == String.Empty ||
                txtTelefono.Text == String.Empty ||
                txtDireccion.Text == String.Empty ||
                cmbTipDoc.Text == String.Empty)
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
                txtEmail.Text == String.Empty ||
                txtTelefono.Text == String.Empty ||
                txtDireccion.Text == String.Empty ||
                cmbTipDoc.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Registro Guardado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cmbTipDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipDoc.SelectedIndex == 1)
            {
                txtNumDoc.Enabled = true;
                txtNumDoc.MaxLength = 8;
            }
            else if (cmbTipDoc.SelectedIndex == 2)
            {
                txtNumDoc.Enabled = true;
                txtNumDoc.MaxLength = 11;
            }
            else if (cmbTipDoc.SelectedIndex == 3)
            {
                txtNumDoc.Enabled = true;
                txtNumDoc.MaxLength = 9;
            }
            else
            {
                txtNumDoc.Enabled = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
