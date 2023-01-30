using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace j2b_Proyect
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtCodigo.Text != "" && txtNProducto.Text != "" && txtPrecio.Text != "")
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtCodigo.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtNProducto.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtPrecio.Text;
                MessageBox.Show("Datos Guardados", "Estado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Text = "";
                txtNProducto.Text = "";
                txtPrecio.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("¿Desea cerrar la aplicacion?", "Registro de Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (n == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
