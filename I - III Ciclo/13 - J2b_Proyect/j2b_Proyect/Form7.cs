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
    public partial class FrmProv : Form
    {
        public FrmProv()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "")
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtCodigo.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtNombre.Text;
                MessageBox.Show("Datos Guardados", "Estado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Text = "";
                txtNombre.Text = "";
            }
    }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("¿Desea cerrar la aplicacion?", "Registro de Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (n == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
