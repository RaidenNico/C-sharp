using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Evaluación_Final
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            dgvFacturas.DataSource = Factura_C.ListarFacturas();
            Helper.cargarData(cmbCliente, cmbProducto, cmbVendedor: cmbVendedor);
            Helper.ListarAccionesYCabeceras(
                cmb: cmbAcccion,
                dgv: dgvFacturas,
                "Numero de Factura",
                "Fecha de Factura",
                "Total bruto",
                "IGV",
                "Total Pagado",
                "Cliente",
                "Vendedor"
                );
            cmbAcccion.Items.RemoveAt(0);
            cmbAcccion.SelectedIndex = 0;
        }

        private void btnGProducto_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();

            DetalleFactura dt = new DetalleFactura();

            f.NumFac = txtNFactura.Text;
            f.FechaFac = dtpFecha.Value;
            f.TotalFac = float.Parse(txtBruto.Text.Replace("S/. ", ""));
            f.IgvFac = float.Parse(txtIGV.Text.Replace("S/. ", ""));
            f.TotalPago = float.Parse(txtTotal.Text.Replace("S/. ", ""));
            f.Codc = Cliente_c.ObtenerCodigoByName(cmbCliente.Text).Codc;
            f.Codv = Vendedor_C.ObtenerCodigoByName(cmbVendedor.Text).CodV;
            //MessageBox.Show($"{txtNFactura.Text} {Producto_C.ObtenerCodigoByName(cmbProducto.Text).Codp} {int.Parse(txtCantidad.Text)} {float.Parse(txtPUnitario.Text)} {float.Parse(txtBruto.Text.Replace("S/. ", ""))}", "titulo");
            dt.NumFac = txtNFactura.Text;
            dt.Codp = Producto_C.ObtenerCodigoByName(cmbProducto.Text).Codp;
            dt.Cantidad = float.Parse(txtCantidad.Text);
            dt.PUnitario = float.Parse(txtPUnitario.Text);
            dt.Importe = float.Parse(txtTotal.Text.Replace("S/. ", ""));
            Factura_C.AgregarFactura(f);
            Factura_Detalle_C.AgregarDetalleFactura(dt);
            dgvFacturas.DataSource = Factura_C.ListarFacturas();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDireccionC.Text = Cliente_c.ObtenerCodigoByName(cmbCliente.Text).Dirc;
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPUnitario.Text = Producto_C.ObtenerCodigoByName(cmbProducto.Text).Punp.ToString();
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (Helper.validators(txtCantidad, lblErrorCantidad) != null)
            {
                float bruto = float.Parse(txtPUnitario.Text) * int.Parse(txtCantidad.Text);

                txtBruto.Text = $"S/. {bruto}";

                txtIGV.Text = $"S/. {bruto * .18}";

                txtTotal.Text = $"S/. {bruto + bruto * .18}";
            }
            else
            {
                txtBruto.Text = "";

                txtIGV.Text = "";

                txtTotal.Text = "";
            }
        }

        private void txtNFactura_Validating(object sender, CancelEventArgs e)
        {

            if (txtNFactura.Text.Length != 8)
            {
                lblValidator.Text = "Error de longitud";
            }
            else
            {
                lblValidator.Text = "";
            }
        }

        private void cmbAcccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helper.Textoboton(cmbAcccion, btnProcesar);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Factura fa = new Factura();
            DetalleFactura dt = new DetalleFactura();
            Helper.AccionesFactura(
                cmbAcccion,
                fa,
                dt,
                txtNFactura,
                cmbCliente,
                dtpFecha,
                cmbVendedor,
                cmbProducto,
                txtPUnitario,
                txtCantidad,
                txtBruto,
                txtIGV,
                txtTotal);
            //MessageBox.Show($"{Cliente_c.ObtenerCodigoByName(Factura_C.ConsultarFactura(fa).Codc, buscar: true)}");
        }
    }
}
