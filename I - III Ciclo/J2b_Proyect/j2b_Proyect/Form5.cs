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
    public partial class FrmInsumo : Form
    {
        public FrmInsumo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtInsumo.Text != "" && txtCant.Text != "" && txtPrecioI.Text != "")
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtInsumo.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtCant.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtPrecioI.Text;
                MessageBox.Show("Datos Guardados", "Estado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInsumo.Text = "";
                txtCant.Text = "";
                txtPrecioI.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("¿Desea cerrar la aplicacion?", "Registro de Insumos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (n == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
