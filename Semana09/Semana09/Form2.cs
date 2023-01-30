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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           Calcular cc=new Calcular();
            cc.Largo = Convert.ToDouble(v1.Text);
            cc.Ancho = Convert.ToDouble(v2.Text);
            r.Text = cc.Suma.ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Calcular.limpiar(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
