using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana09
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArea area = new frmArea();
            area.Show();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperaciones suma = new frmOperaciones();
            suma.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
