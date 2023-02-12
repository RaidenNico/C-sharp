using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana11
{
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTurnos t=new frmTurnos();
            t.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras c=new frmCarreras();
            c.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos a = new frmAlumnos();
            a.Show();
        }
    }
}
