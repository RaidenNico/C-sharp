using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación_Final
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        frmCliente cl;
        frmVendedor vd;
        frmFactura fa;
        frmProducto pr;
        frmLogin fr;

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cl == null) 
            {

                cl = new frmCliente();
                cl.MdiParent = this;
                cl.FormClosed += new FormClosedEventHandler(ValidedForm);
                cl.Show();
            }
            cl.Activate();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vd = new frmVendedor();
            vd.MdiParent = this;
            vd.FormClosed += new FormClosedEventHandler(ValidedForm);
            vd.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fa = new frmFactura();
            fa.MdiParent = this;
            fa.FormClosed += new FormClosedEventHandler(ValidedForm);
            fa.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr = new frmLogin();
            this.Dispose();
            fr.Show();
        }

        public void ValidedForm(Object sender,FormClosedEventArgs e)
        {
            cl = null;
            vd = null;
            fa = null;
            pr = null;
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pr = new frmProducto();
            pr.MdiParent = this;
            pr.FormClosed += new FormClosedEventHandler(ValidedForm);
            pr.Show();
        }
    }
}
