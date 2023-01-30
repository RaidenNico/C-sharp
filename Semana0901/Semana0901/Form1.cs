using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana0901
{
    public partial class frmTrabajador : Form
    {
        public frmTrabajador()
        {
            InitializeComponent();
        }

        private void frmTrabajador_Load(object sender, EventArgs e)
        {
            Trabajador trabajador = new Trabajador(3500, "Juan", "Perez", "Pino", "06168499", new DateTime(2000, 06, 15));
            txtDni.Text = trabajador.Dni;
            txtApa.Text = trabajador.ApellidoPaterno;
            txtAma.Text = trabajador.ApellidoMaterno;
            txtNom.Text = trabajador.Nombres;
            txtEdad.Text = trabajador.Edad.ToString();
        }
    }
}
