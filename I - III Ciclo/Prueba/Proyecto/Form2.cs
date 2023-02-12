using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Proyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private frmRegProducto frp;
        private frmRegistroCompra frc;

        private void registroProducto_Click(object sender, EventArgs e)
        {
            if(frp == null)
            {
                frp = new frmRegProducto();
                frp.MdiParent = this;
                frp.FormClosed += new FormClosedEventHandler(cerrarFormulario);
                frp.Show();
            }
            else
            {
                frp.Activate();
            }
        }

        void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            frp = null;
        }

        void closeFRM(object sender, FormClosedEventArgs e)
        {
            frc = null;
        }

        private void comprarProducto_Click(object sender, EventArgs e)
        {
            if (frc == null)
            {
                frc = new frmRegistroCompra();
                frc.MdiParent = this;
                frc.FormClosed += new FormClosedEventHandler(closeFRM);
                frc.Show();
            }
            else
            {
                frc.Activate();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult salida;
            salida = MessageBox.Show("¿DESEA SALIR DE LA APLICACIÓN?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(salida == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frc == null)
            {
                frc = new frmRegistroCompra();
                frc.MdiParent = this;
                frc.FormClosed += new FormClosedEventHandler(closeFRM);
                frc.Show();
            }
            else
            {
                frc.Activate();
            }
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frp == null)
            {
                frp = new frmRegProducto();
                frp.MdiParent = this;
                frp.FormClosed += new FormClosedEventHandler(cerrarFormulario);
                frp.Show();
            }
            else
            {
                frp.Activate();
            }
        }
    }
}
