using System;
using System.Windows.Forms;

namespace Evaluación_Final
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = Cliente_c.ListarCliente();
            Helper.ListarAccionesYCabeceras(cmbAccion, dgvCliente, cabecera0: "Código", cabecera1: "Datos del Cliente", cabecera2: "Dirección del Cliente", Cliente: true);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();

            Helper.AccionesCliente(cmbAccion, cl, txtC: txtCodigo, txtN: txtNombre, txtD: txtDireccion);
            dgvCliente.DataSource = Cliente_c.ListarCliente();
        }
    }
}
