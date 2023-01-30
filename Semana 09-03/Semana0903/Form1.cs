using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana0903
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }
        public void visualizar()
        {
            using (bdSistemasEntities alu = new bdSistemasEntities())
            {
                var lst = from d in alu.Alumnos select d;
                dgv.DataSource = lst.ToList();
            }
        }
        public void limpiar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            txtApa.Focus();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            visualizar();
            limpiar();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (bdSistemasEntities alu=new bdSistemasEntities())
            { 
                Alumnos estru=new Alumnos();
                estru.APA = txtApa.Text;
                estru.AMA = txtAma.Text;
                estru.NOM = txtNom.Text;
                alu.Alumnos.Add(estru);
                alu.SaveChanges();
            }
            MessageBox.Show("Registro Guardado");
            visualizar();
            limpiar();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                txtId.Text = dgv.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txtApa.Text = dgv.Rows[e.RowIndex].Cells["apa"].FormattedValue.ToString();
                txtAma.Text = dgv.Rows[e.RowIndex].Cells["ama"].FormattedValue.ToString();
                txtNom.Text = dgv.Rows[e.RowIndex].Cells["nom"].FormattedValue.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (bdSistemasEntities alu = new bdSistemasEntities())
            {
                Alumnos estru = new Alumnos();
                estru.ID = Convert.ToInt32(txtId.Text);
                estru.APA = txtApa.Text;
                estru.AMA = txtAma.Text;
                estru.NOM = txtNom.Text;
                alu.Entry(estru).State = System.Data.Entity.EntityState.Modified;
                alu.SaveChanges();
            }
            MessageBox.Show("Registro Modificado");
            visualizar();
            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (bdSistemasEntities bd = new bdSistemasEntities())
            {
                Alumnos alu = bd.Alumnos.Find(Convert.ToInt32(txtId.Text));
                bd.Alumnos.Remove(alu);
                bd.SaveChanges();
            }
            MessageBox.Show("Registro Eliminado");
            visualizar();
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
