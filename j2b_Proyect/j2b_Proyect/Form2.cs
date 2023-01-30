using j2b_Proyect;
using System;
using System.Windows.Forms;

namespace j2b_Proyect
{

    public partial class frmPrincipal : Form
    {

        frmRegistro registro;
        frmLogin login;
        FrmInsumo insum;
        FrmClientes clientes;
        FrmProv prov;


        public string[] usuario = new string[] { "david", "nicolas", "stephanie", "miguel", "nicol" };
        public string[] contraseña = new string[] { "3333", "1111", "2222", "4444", "5555" };
        public string nombre = "";


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes= new FrmClientes();
            clientes.Show();
            this.Hide();
        }

        private void cerrarFormulario (object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("HH/mm/ss");
            if (fecha == "6.00" && fecha == "12.00")
            {
                lblStatus.Text = $"Hola Buenos días {nombre}";
            }
            else if (fecha == "2.00" && fecha == "18.00") {
                lblStatus.Text = $"Hola Buenas Tardes {nombre}";
            }
            else {
                lblStatus.Text = $"Hola Buenas Noches {nombre}";
            }
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void registroDeInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insum = new FrmInsumo();
            insum.Show();
            this.Hide();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prov = new FrmProv();
            prov.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clientes = new FrmClientes();
            clientes.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            prov = new FrmProv();
            prov.Show();
            this.Hide();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            insum = new FrmInsumo();
            insum.Show();
            this.Hide();
        }
    }
}
