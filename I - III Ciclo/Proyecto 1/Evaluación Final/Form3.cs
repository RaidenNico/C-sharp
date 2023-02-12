using System;
using System.Windows.Forms;

namespace Evaluación_Final
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            dgvProducto.DataSource = Producto_C.ListarProductos();
            Helper.ListarAccionesYCabeceras(
                cmbAccion,
                dgvProducto,
                "Codigo",
                "Descripción del Producto",
                "Precio Unitario",
                "Stock",
                producto: true
                );
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            Helper.AccionesProducto(
                cmbAccion,
                p,
                txtCodigo,
                txtNProducto,
                txtPUnitario,
                txtStock
                );
            dgvProducto.DataSource = Producto_C.ListarProductos();
        }
    }
}
