using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncargoBodega
{
    public partial class frmAgregarVenta : Form
    {
        //Inicializo estas listas para almacenar los productos de la venta, sus precios y sus cantidades
        List<string> productos = new List<string>();
        List<double> precios = new List<double>();
        List<int> cantidades = new List<int>();
        //Inicializo dos variables de texto para que se guarde el tipo de pago seleccionado y 
        //el mensaje que se mostrará en la última caja de texto (txtFactura)
        string tipoPago = "", mensajeFactura = "";

        public frmAgregarVenta()
        {
            InitializeComponent();
        }
        //Creo una función que muestre los ítems del listBox (lbCarrito)
        public void mostrarProductosCarrito()
        {
            int contador = 0;
            while (contador != productos.Count)
            {
                lbCarrito.Items.Add(productos[contador] + " / " + cantidades[contador] + " unidades / S/. " + precios[contador] + " c/u");
                contador++;
            }
        }
        //Creo una función que muestre una ventana emergente en donde se muestre los productos
        //y lo que se va a pagar por ellos
        //OJO: "Environment.NewLine" es un salto de línea
        public void mostrarProductosVentana()
        {
            string mensajeVentana = "";

            mensajeVentana += "\tPRODUCTOS ELEGIDOS" + Environment.NewLine + Environment.NewLine;
            int contador = 0;
            while (contador != productos.Count)
            {
                mensajeVentana += productos[contador] + " ------>  " + cantidades[contador] + " x  S/. " 
                                  + precios[contador] + " = S/. " + (cantidades[contador] * precios[contador])  + Environment.NewLine;
                contador++;
            }

            MessageBox.Show(mensajeVentana, "Resumen de Productos", MessageBoxButtons.OK);
        }
        //Se muestra lo que se va a pagar por los productos seleccionados
        public void mostrarResumen(double descuento)
        {
            double sumaTotal = 0; 
            int contador = 0;
            //Lo que ocurre aquí es que se multiplican los precios de los productos con sus cantidades 
            //y se suman al acumulador sumaTotal
            while (contador != productos.Count)
            {
                sumaTotal = sumaTotal + (cantidades[contador] * precios[contador]);
                contador++;
            }

            double sumaTotalDescuento = sumaTotal * descuento, totalPagar = sumaTotal - sumaTotalDescuento;
            
            //Se crea el mensaje que se mostrará en la factura
            mensajeFactura = string.Format("\t-------------RESUMEN DE VENTA---------------{0}{0}MEDIO DE PAGO: {1}{0}SUMA TOTAL: S/. {2}{0}DESCUENTO: S/. {3}{0}TOTAL A PAGAR: S/. {4}{0}{0}**HAGA CLICK EN EL BOTON 'NUEVA VENTA' PARA REINICIAR LA VENTANA", 
                             Environment.NewLine, tipoPago, sumaTotal, sumaTotalDescuento, totalPagar);
                            // {0}                  {1}     {2}         {3}                 {4}
            txtFactura.Text = mensajeFactura;
        }

        //Cuando se cargue el formulario, se mostrará la hora en que se entró al formulario y
        //mantendrá la caja de texto de la factura (txtFactura) en solo lectura
        private void AgregarVent_Load(object sender, EventArgs e)
        {
            txtMensaje.Text = "Usted ha entrado a esta venta a las: " + DateTime.Now.ToString("hh:mm:ss");
            txtFactura.ReadOnly = true;
        }

        //Se agregan los productos seleccionados en el comboBox y en el spinBox
        //cuando se presiona el botón de agregar (btnAgregar)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Solo se guarda la informacion en el listBox, cuando se haya seleccionado un producto del comboBox
            //y cuando el valor del spinBox es mayor a 0
            if (cbProducto.SelectedIndex != -1 && numCantidad.Value > 0)
            {
                //En el caso de que se escoja un producto que ya se encuentre en el listBox,
                //a este solo se le sumará la nueva cantidad
                if (productos.Contains(cbProducto.Text))
                {
                    //El producto, al estar guardado en la lista productos, solamente necesitamos el 
                    //índice del producto repetido y se le suma la nueva cantidad
                    int index = productos.IndexOf(cbProducto.Text);
                    cantidades[index] += (int)numCantidad.Value;
                    lbCarrito.Items.Clear();

                    mostrarProductosCarrito();
                }
                //De lo contrario, se agrega el producto al listBox
                else
                {
                    //Primero, borramos toda la información de la listBox
                    lbCarrito.Items.Clear();

                    //Luego, se agrega el producto y su cantidad a las respectivas listas
                    productos.Add(cbProducto.Text);
                    cantidades.Add((int)numCantidad.Value);

                    //Después se agrega el precio, dependiendo del producto
                    if (cbProducto.SelectedIndex == 0)
                    {
                        precios.Add(1.2);
                    }
                    else if (cbProducto.SelectedIndex == 1)
                    {
                        precios.Add(3.5);
                    }
                    else if (cbProducto.SelectedIndex == 2)
                    {
                        precios.Add(2.5);
                    }
                    else if (cbProducto.SelectedIndex == 3)
                    {
                        precios.Add(2.3);
                    }
                    //Finalmente, se muestra el producto en la listBox
                    mostrarProductosCarrito();
                }
                cbProducto.SelectedIndex = -1;
                numCantidad.Value = 0;
            }
            else
            {
                MessageBox.Show("Recuerde de escoger un PRODUCTO y su CANTIDAD", "Falta de Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Permite eliminar los productos del listBox
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verifica si se tiene seleccionado un producto del listBox
            if (lbCarrito.SelectedItem != null)
            {
                //Primero, se quita el producto de la lista, al igual que su cantidad y su precio
                productos.RemoveAt(lbCarrito.SelectedIndex);
                precios.RemoveAt(lbCarrito.SelectedIndex);
                cantidades.RemoveAt(lbCarrito.SelectedIndex);
                //Se quita el ítem el listBox
                lbCarrito.Items.Remove(lbCarrito.SelectedItem);
            }
            else //De lo contrario, muestra este mensaje
            {
                MessageBox.Show("Seleccione el Producto para quitarlo del Carrito", "Mensaje de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Solamente permite seleccionar cualquier radioButton, si se han agregado productos al carrito
        private void rbEfectivo_Click(object sender, EventArgs e)
        {
            if (productos.Count > 0)
            {
                tipoPago = "Efectivo";
            }
            else
            {
                MessageBox.Show("Antes de Seleccionar el tipo de Pago, primero ingrese productos al carrito.", "Mensaje de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rbEfectivo.Checked = false;
            }
        }

        private void rbTarjeta_Click(object sender, EventArgs e)
        {
            if (productos.Count > 0)
            {
                tipoPago = "Tarjeta";
            }
            else
            {
                MessageBox.Show("Antes de Seleccionar el tipo de Pago, primero ingrese productos al carrito.", "Mensaje de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rbTarjeta.Checked = false;
            }
        }

        private void rbYape_Click(object sender, EventArgs e)
        {
            if (productos.Count > 0)
            {
                tipoPago = "Yape";
            }
            else
            {
                MessageBox.Show("Antes de Seleccionar el tipo de Pago, primero ingrese productos al carrito.", "Mensaje de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rbYape.Checked = false;
            }
        }

        //Se guarda el/los producto(s) selecionado(s) para mostrar la factura
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Primero verifica si la lista de productos no se encuentra vacía y los 
            //radioButton se encuentran seleccionado (alguno de los tres)
            if (productos.Count > 0 && (rbYape.Checked || rbTarjeta.Checked || rbEfectivo.Checked))
            {
                mostrarProductosVentana();
                //En el caso de que se encuentre seleccionado el rbTareja
                //da la posibilidad de un 15% de descuento
                if (rbTarjeta.Checked)
                {
                    mostrarResumen(0.15);
                }
                else
                {
                    mostrarResumen(0);
                }
                //Se inhabilitan otros
                groupBox2.Enabled = false;
                btnGuardar.Enabled = false;
                cbProducto.Enabled = false;
                numCantidad.Enabled = false;
                lbCarrito.Enabled = false;
            }
            else
            {
                MessageBox.Show("Antes de Guardar, primero ingrese PRODUCTOS al carrito y luego seleccione un MEDIO de PAGO.", "Mensaje de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rbEfectivo.Checked = false;
                rbTarjeta.Checked = false;
                rbYape.Checked = false;
            }
        }

        //Permite que todos los controles vuelvan a su estado original y las listas se vacíen
        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true; btnGuardar.Enabled = true; cbProducto.Enabled = true; numCantidad.Enabled = true;
            lbCarrito.Enabled = true;
            rbEfectivo.Checked = false; rbTarjeta.Checked = false; rbYape.Checked = false;
            cbProducto.SelectedIndex = -1;
            lbCarrito.Items.Clear(); txtFactura.Clear();
            productos.Clear(); cantidades.Clear(); precios.Clear();
        }

        //Permite salir de la ventana
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Salir?", "Mensaje de Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
         {

        }

        private void rbYape_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMensaje_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
