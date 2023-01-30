using System;
using System.Windows.Forms;

namespace Evaluación_Final
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            dgvVendedor.DataSource = Vendedor_C.ListarVendedor();
            Helper.ListarAccionesYCabeceras(
                cmbAccion,
                dgvVendedor,
                cabecera0: "Código",
                cabecera1: "Datos del Vendedor",
                cabecera2: "Dirección Vendedor",
                cabecera3: "DNI",
                cabecera4: "Sexo",
                cabecera5: null,
                Vendedor: true
                );
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Vendedor ve = new Vendedor();
            Helper.AccionesVendedor(
                cmb: cmbAccion,
                ve: ve,
                txtC: txtCodigo,
                txtD: txtDatosVendedor,
                txtDi: txtDireccionVendedor,
                txtDNI: txtDNIVendedor,
                cmbS: cmbSexo
                );
            dgvVendedor.DataSource = Vendedor_C.ListarVendedor();
        }
    }
}
