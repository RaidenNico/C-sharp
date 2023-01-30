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
    public partial class frmPrincipal : Form
    {
        private frmAgProducto fAgProd; //Formulario Productos.
        private frmAgProv fAgProv; //Formulario Proveedores.
        private AgregarClien fAgregarClientes; //Formulario Clientes.
        private frmAgregarVenta fRVenta; //Formulario Realizar Venta.
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dialogo y cuadro de salida.
            DialogResult pregSalir = MessageBox.Show("¿Desea salir del sistema?", "SALIR DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (pregSalir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Al iniciar formulario, habilitar reloj.
            tReloj.Enabled = true;
        }

        private void tReloj_Tick(object sender, EventArgs e)
        { 
            //Cada tick del reloj, actualizar hora.
            stlFechaHora.Text = DateTime.Now.ToString("hh:mm:ss") + " " + DateTime.Now.ToShortDateString();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Registro de clientes, barra superior.
            if (fAgregarClientes == null)
            {
                fAgregarClientes = new AgregarClien();
                fAgregarClientes.MdiParent = this;
                fAgregarClientes.FormClosed += new FormClosedEventHandler(CerrarFormularioAgCliente);
                fAgregarClientes.Show();
            }
            else
            {
                fAgregarClientes.Focus();
            }
        }

        private void btnAgCli_Click(object sender, EventArgs e)
        {
            if (fAgregarClientes == null)
            {
                fAgregarClientes = new AgregarClien();
                fAgregarClientes.MdiParent = this;
                fAgregarClientes.FormClosed += new FormClosedEventHandler(CerrarFormularioAgCliente);
                fAgregarClientes.Show();
            }
            else
            {
                fAgregarClientes.Focus();
            }
        }

        void CerrarFormularioAgCliente(object sender, FormClosedEventArgs e)
        {
            fAgregarClientes = null;
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar formulario de Agregar Productos.
            if (fAgProd == null)
            {
                fAgProd = new frmAgProducto();
                fAgProd.MdiParent = this;
                fAgProd.FormClosed += new FormClosedEventHandler(CerrarFormularioAgProductos);
                fAgProd.Show();
            }
            else
            {
                //fAgProd.Activate();
                fAgProd.Focus();
            }
        }

        private void btnAgProd_Click(object sender, EventArgs e)
        {
            if (fAgProd == null)
            {
                fAgProd = new frmAgProducto();
                fAgProd.MdiParent = this;
                fAgProd.FormClosed += new FormClosedEventHandler(CerrarFormularioAgProductos);
                fAgProd.Show();
            }
            else
            {
                //fAgProd.Activate();
                fAgProd.Focus();
            }
        }

        void CerrarFormularioAgProductos(object sender, FormClosedEventArgs e)
        {
            fAgProd = null;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fRVenta == null)
            {
                fRVenta = new frmAgregarVenta();
                fRVenta.MdiParent = this;
                fRVenta.FormClosed += new FormClosedEventHandler(CerrarFormularioAgVenta);
                fRVenta.Show();
            }
            else
            {
                fRVenta.Focus();
            }
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Realizar ventas, formulario.
            if (fRVenta == null)
            {
                fRVenta = new frmAgregarVenta();
                fRVenta.MdiParent = this;
                fRVenta.FormClosed += new FormClosedEventHandler(CerrarFormularioAgVenta);
                fRVenta.Show();
            }
            else
            {
                fRVenta.Focus();
            }
        }

        void CerrarFormularioAgVenta(object sender, FormClosedEventArgs e)
        {
            fRVenta = null;
        }

        private void registrarProvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar formulario de agregar proveedores.
            if (fAgProv == null)
            {
                fAgProv = new frmAgProv();
                fAgProv.MdiParent = this;
                fAgProv.FormClosed += new FormClosedEventHandler(CerrarFomularioAgProveedor);
                fAgProv.Show();
            }
            else
            {
                //fAgProv = null;
                fAgProv.Focus();
            }
        }


        private void btnAgProv_Click(object sender, EventArgs e)
        {
            if (fAgProv == null)
            {
                fAgProv = new frmAgProv();
                fAgProv.MdiParent = this;
                fAgProv.FormClosed += new FormClosedEventHandler(CerrarFomularioAgProveedor);
                fAgProv.Show();
            }
            else
            {
                //fAgProv = null;
                fAgProv.Focus();
            }
        }

        void CerrarFomularioAgProveedor(object sender, FormClosedEventArgs e)
        {
            fAgProv = null;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
            //Agrego este comando porque cuando se llama al método Hide(), solo se esconde la ventana de 
            //login, lo que provoca que el progama se cierre solo si presionamos el botón SALIR en el menú principal
            this.Close();

        }

        private void stlFechaHora_Click(object sender, EventArgs e)
        {

        }
    }
}
