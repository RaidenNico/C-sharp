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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular c = new Calcular();
            c.Largo = Convert.ToInt32(txtLargo.Text);
            c.Ancho = Convert.ToInt32(txtAncho.Text);
            txtArea.Text = c.Area.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Calcular.limpiar(this);
        }
    }
}
