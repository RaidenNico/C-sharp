using System;
using System.Windows.Forms;

namespace Evaluación_Final
{
    public static class Helper
    {
        public static void ListarAccionesYCabeceras(
            ComboBox cmb,
            DataGridView dgv,
            string cabecera0,
            string cabecera1,
            string cabecera2,
            string cabecera3 = null,
            string cabecera4 = null,
            string cabecera5 = null,
            string cabecera6 = null,
            bool Cliente = false,
            bool Vendedor = false,
            bool producto = false
            )
        {
            cmb.Items.Add("Guardar");
            cmb.Items.Add("Consultar");
            cmb.Items.Add("Modificar");
            cmb.Items.Add("Eliminar");
            cmb.SelectedIndex = 0;

            string[] titulos = new string[] { cabecera0, cabecera1, cabecera2, cabecera3, cabecera4, cabecera5, cabecera6 };

            if (Cliente)
            {
                for (int i = 0; i < titulos.Length; i++)
                {
                    if (i == 3) break;
                    dgv.Columns[i].HeaderText = titulos[i];
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else if (Vendedor)
            {
                for (int i = 0; i < titulos.Length; i++)
                {
                    if (i == 5) break;
                    dgv.Columns[i].HeaderText = titulos[i];
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else if (producto)
            {
                for (int i = 0; i < titulos.Length; i++)
                {
                    if (i == 4) break;
                    dgv.Columns[i].HeaderText = titulos[i];
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            for (int i = 0; i < titulos.Length; i++)
            {
                //dgv.Columns[i].HeaderText = titulos[i];
                //dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /*
        public static void DarCodigo(TextBox txtC)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from c in bd.Cliente select c).First();
                    string valor = consulta.Codc.Replace("C", "");

                    for (int i = 0; i < valor.Length; i++)
                    {
                        if (valor. == "0")
                        {
                            valor.Remove(i);
                        }
                        else
                        {
                            txtC.Text = valor;
                        }
                    }

                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        */

        public static void AccionesCliente(ComboBox cmb, Cliente cl, TextBox txtC, TextBox txtN, TextBox txtD)
        {
            switch (cmb.SelectedIndex)
            {
                case 0:
                    cmb.SelectedIndex = 0;
                    cl.Codc = txtC.Text;
                    cl.Nomc = txtN.Text;
                    cl.Dirc = txtD.Text;
                    Cliente_c.AgregarCliente(cl);
                    break;
                case 1:
                    cmb.SelectedIndex = 1;
                    cl.Codc = txtC.Text;
                    txtN.Text = Cliente_c.ConsultarCliente(cl).Nomc;
                    txtD.Text = Cliente_c.ConsultarCliente(cl).Dirc;
                    break;
                case 2:
                    cmb.SelectedIndex = 2;
                    cl.Codc = txtC.Text;
                    cl.Nomc = txtN.Text;
                    cl.Dirc = txtD.Text;
                    Cliente_c.ModificarCliente(cl);
                    break;
                case 3:
                    cmb.SelectedIndex = 3;
                    cl.Codc = txtC.Text;
                    Cliente_c.EliminarCliente(cl);
                    break;
                default:
                    break;
            }
        }

        public static string SexVendedor(string Sex)
        {

            string Result = (Sex != null && Sex == "M") ? "M" : "F";
            return Result;
            
        }

        public static string SexModVendedor(ComboBox cmbS)
        {
            string c = (cmbS.SelectedIndex == 0) ? "M" : "F";
            return c;
        }

        public static void AccionesVendedor(
            ComboBox cmb,
            Vendedor ve,
            TextBox txtC,
            TextBox txtD,
            TextBox txtDi,
            TextBox txtDNI,
            ComboBox cmbS
            )
        {
            switch (cmb.SelectedIndex)
            {
                case 0:
                    cmb.SelectedIndex = 0;
                    ve.Codv = txtC.Text;
                    ve.Datv = txtD.Text;
                    ve.Dirv = txtDi.Text;
                    ve.Dniv = txtDNI.Text;
                    ve.Sexv = SexModVendedor(cmbS) ;
                    Vendedor_C.AgregarVendedor(ve);
                    break;
                case 1:
                    cmb.SelectedIndex = 1;
                    ve.Codv = txtC.Text;
                    txtD.Text = Vendedor_C.ConsultarVendedor(ve).Datv;
                    txtDi.Text = Vendedor_C.ConsultarVendedor(ve).Dirv;
                    txtDNI.Text = Vendedor_C.ConsultarVendedor(ve).Dniv;
                    cmb.SelectedItem = (SexVendedor(Vendedor_C.ConsultarVendedor(ve).Sexv) == "M") ? cmbS.SelectedIndex = 0 : cmbS.SelectedIndex = 1;
                    break;
                case 2:
                    cmb.SelectedIndex = 2;
                    ve.Codv = txtC.Text;
                    ve.Datv = txtD.Text;
                    ve.Dirv = txtDi.Text;
                    ve.Dniv = txtDNI.Text;
                    ve.Sexv = SexModVendedor(cmbS);
                    Vendedor_C.ModificarVendedor(ve);
                    break;
                case 3:
                    cmb.SelectedIndex = 3;
                    ve.Codv = txtC.Text;
                    Vendedor_C.EliminarVendedor(ve);
                    break;
            }
        }

        public static void AccionesProducto(
            ComboBox cmb,
            Producto p,
            TextBox txtC,
            TextBox txtNP,
            TextBox txtPU,
            TextBox txtSt
            )
        {
            switch (cmb.SelectedIndex)
            {
                case 0:
                    cmb.SelectedIndex = 0;
                    p.Codp = txtC.Text;
                    p.Nomp = txtNP.Text;
                    p.Punp = float.Parse(txtPU.Text);
                    p.Stockp = int.Parse(txtSt.Text);
                    Producto_C.AgregarProducto(p);
                    break;
                case 1:
                    cmb.SelectedIndex = 1;
                    p.Codp = txtC.Text;
                    txtNP.Text = Producto_C.ConsultarProducto(p).Nomp;
                    txtPU.Text = Producto_C.ConsultarProducto(p).Punp.ToString();
                    txtSt.Text = Producto_C.ConsultarProducto(p).Stockp.ToString();
                    break;
                case 2:
                    cmb.SelectedIndex = 2;
                    p.Codp = txtC.Text;
                    p.Nomp = txtNP.Text;
                    p.Punp = float.Parse(txtPU.Text);
                    p.Stockp = int.Parse(txtSt.Text);
                    Producto_C.ModificarProducto(p);
                    break;
                case 3:
                    cmb.SelectedIndex = 3;
                    p.Codp = txtC.Text;
                    Producto_C.EliminarProducto(p);
                    break;
            }

        }

        public static void cargarData(ComboBox cmbCliente, ComboBox cmbProducto, ComboBox cmbVendedor)
        {
            Cliente_c.ListarCliente().ForEach(cl =>
            {
                cmbCliente.Items.Add(cl.Nomc);
            });
            cmbCliente.SelectedIndex = 0;

            Vendedor_C.ListarVendedor().ForEach(v =>
            {
                cmbVendedor.Items.Add(v.Datv);
            });
            cmbVendedor.SelectedIndex = 0;

            Producto_C.ListarProductos().ForEach(pr =>
            {
                cmbProducto.Items.Add(pr.Nomp);
            });
            cmbProducto.SelectedIndex = 0;
        }

        public static void AccionesFactura(
            ComboBox cmb,
            Factura f,
            DetalleFactura dt,
            TextBox txtNFactura,
            ComboBox cmbCliente,
            DateTimePicker dtpFechaFac,
            ComboBox cmbVendedor,
            ComboBox cmbProducto,
            TextBox txtPunitario,
            TextBox txtCantidad,
            TextBox txtTotalBruto,
            TextBox txtIGV,
            TextBox txtTotalCancelar
            )
        {

            DetalleFactura dta = new DetalleFactura();

            switch (cmb.SelectedIndex)
            {
                case 0:
                    cmb.SelectedIndex = 0;
                    f.NumFac = txtNFactura.Text;
                    dt.NumFac = txtNFactura.Text;
                    dtpFechaFac.Value = (DateTime)Factura_C.ConsultarFactura(f).FechaFac;
                    txtTotalCancelar.Text = $"S/. {Factura_C.ConsultarFactura(f).TotalPago}";
                    txtIGV.Text = $"S/. {Factura_C.ConsultarFactura(f).IgvFac}";
                    txtTotalBruto.Text = $"S/. {Factura_C.ConsultarFactura(f).TotalFac}";
                    cmbCliente.SelectedItem = Cliente_c.ObtenerCodigoByName(Factura_C.ConsultarFactura(f).Codc, buscar: true).Nomc;
                    cmbVendedor.SelectedItem = Vendedor_C.ObtenerCodigoByName(Factura_C.ConsultarFactura(f).Codv, busqueda: true).Datv;
                    txtCantidad.Text = Factura_Detalle_C.ConsultarDetalleFactura(dt).Cantidad.ToString();
                    break;
                case 1:
                    cmb.SelectedIndex = 1;
                    f.NumFac = txtNFactura.Text;
                    f.FechaFac = dtpFechaFac.Value;
                    f.TotalFac = float.Parse(txtTotalBruto.Text.Replace("S/. ", ""));
                    f.IgvFac = float.Parse(txtIGV.Text.Replace("S/. ", ""));
                    f.TotalPago = float.Parse(txtTotalCancelar.Text.Replace("S/. ", ""));
                    f.Codc = Cliente_c.ObtenerCodigoByName(cmbCliente.Text).Codc;
                    f.Codv = Vendedor_C.ObtenerCodigoByName(cmbVendedor.Text).CodV;
                    dt.NumFac = txtNFactura.Text;
                    dt.Codp = Producto_C.ObtenerCodigoByName(cmbProducto.Text).Codp;
                    dt.Cantidad = int.Parse(txtCantidad.Text);
                    dt.PUnitario = 15f;
                    dt.Importe = float.Parse(txtTotalCancelar.Text.Replace("S/. ", ""));
                    Factura_C.ModificarFactura(f);
                    Factura_Detalle_C.ModificarDetalleFactura(dt);
                    break;
                case 2:
                    cmb.SelectedIndex = 2;
                    f.NumFac = txtNFactura.Text;
                    dt.NumFac = txtNFactura.Text;
                    Factura_Detalle_C.EliminarDetalleFactura(dt);
                    Factura_C.EliminarFactura(f);
                    break;
            }

        }

        public static string validators(TextBox txt, Label lbl)
        {

            if (int.TryParse(txt.Text, out int txtvalor) && !String.IsNullOrWhiteSpace(txt.Text))
            {
                lbl.Text = "";
                return "successfully";
            }
            else if (String.IsNullOrWhiteSpace(txt.Text))
            {
                lbl.Text = "¡Este Campo es Obligatorio!";
            }
            else if (int.TryParse(txt.Text, out int txtvalorE) == false)
            {
                lbl.Text = "¡Solo Numeros Enteros!";

            }
            return null;
        }

        public static void Textoboton(ComboBox cmb, Button btn)
        {
            switch (cmb.SelectedIndex)
            {
                case 0:
                    cmb.SelectedIndex = 0;
                    btn.Text = "Gestionar Factura";
                    break;
                case 1:
                    cmb.SelectedIndex = 1;
                    btn.Text = "Consultar Factura";
                    break;
                case 2:
                    cmb.SelectedIndex = 2;
                    btn.Text = "Anular Factura";
                    break;
                default:
                    MessageBox.Show("Error al Seleccionar una acción a realizar", "Error de Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static bool ValidedCreateAccount(Label lbl, TextBox txt)
        {
            if (String.IsNullOrWhiteSpace(txt.Text))
            {
                lbl.Text = "Este Campo es Obligatorio";
                return true;
            }
            return false;
        }

    }
}
