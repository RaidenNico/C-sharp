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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtDni.Text != "" && txtNombre.Text != "" && txtDirec.Text != "" && txtCelular.Text != "")
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtDirec.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtNombre.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtDirec.Text;
                dataGridView1.Rows[n].Cells[3].Value = txtCelular.Text;
                MessageBox.Show("Datos Guardados", "Estado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDirec.Text = "";
                txtNombre.Text = "";
                txtDirec.Text = "";
                txtCelular.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("¿Desea cerrar la aplicacion?", "Registro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (n == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
