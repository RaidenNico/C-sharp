using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Bodega

{
    public partial class frmPrincipal : Form
    {
        private frmProductos frm; // Creacion de variable para el llamado
        private frmProveedores frp;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void teCanelaYClavoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Productos_Click(object sender, EventArgs e)
        {
            frm = new frmProductos();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void lecheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            frp = new frmProveedores();
            frp.MdiParent = this;
            frp.Show();
            frm.Hide();
            
        }
    }
}
