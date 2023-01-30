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
    public partial class frmRegProducto : Form
    {
        public frmRegProducto()
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
            borrar();
            pbImagen.Image=null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtC.Text == "" || txtD.Text == "" || txtPC.Text == "" || txtPV.Text == "" ||
               txtSM.Text == "" || txtStock.Text == "" || cbCategoria.SelectedIndex==-1)
            {
                MessageBox.Show("Revise campos incompletos");
            }
            else if (pbImagen.Image==null)
            {
                MessageBox.Show("No se cargó imagen", "INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("GUARDADO CORRECTAMENTE","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtC.Focus();
            cbCategoria.SelectedIndex = -1;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if(abririmagen.ShowDialog() == DialogResult.OK)
            {
                pbImagen.ImageLocation = abririmagen.FileName;
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtD);
        }

        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtPC);
        }

        private void txtD_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e,cbCategoria);
        }

        private void txtPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtPV);
        }

        private void txtPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtSM);
        }

        private void txtSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, txtStock);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            enviar(e, btnImagen);
        }
    }
}
