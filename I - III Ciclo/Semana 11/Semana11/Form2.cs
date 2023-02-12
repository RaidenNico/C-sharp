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
    public partial class frmTurnos : Form
    {
        public frmTurnos()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            txtCod.Focus();
        }
        public List<estructura> Visualizar()
        {
            try {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = (from n in bd.Turno
                               orderby n.NOMT
                               select new estructura
                               {
                                   c = n.CODT,
                                   d = n.NOMT
                               }).ToList();
                    return sql;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AgregarTurno(Turno tu)
        {
            try {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    bd.Turno.Add(tu);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ModificarTurno(Turno tu)
        {
            try {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = from t in bd.Turno where t.CODT == tu.CODT select t;
                    foreach (Turno tur in sql)
                    { 
                        tur.CODT= tu.CODT;
                        tur.NOMT= tu.NOMT;
                    }
                    bd.SaveChanges();

                }
            
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EliminarTurno(Turno tu)
        {
            try {
                using (BDTardeEntities bd = new BDTardeEntities())
                { 
                    var sql=from t in bd.Turno where t.CODT==tu.CODT select t;
                    foreach (Turno tt in sql)
                    {
                        bd.Turno.Remove(tt);
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            dgv.DataSource = Visualizar();
            dgv.Columns[0].HeaderText = "CODIGO";
            dgv.Columns[1].HeaderText = "DESCRIPCION";
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 220;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Turno t = new Turno();
            t.CODT=txtCod.Text;
            t.NOMT = txtDes.Text;
            AgregarTurno(t);
            MessageBox.Show("Registro Guardado");
            dgv.DataSource = Visualizar();
            dgv.Columns[0].HeaderText = "CODIGO";
            dgv.Columns[1].HeaderText = "DESCRIPCION";
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 220;
            limpiar();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (BDTardeEntities bd = new BDTardeEntities())
            {
                Turno t = bd.Turno.Find(txtCod.Text);
                txtCod.Text = t.CODT;
                txtDes.Text = t.NOMT;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Turno t = new Turno();
            t.CODT = txtCod.Text;
            t.NOMT = txtDes.Text;
            ModificarTurno(t);
            MessageBox.Show("Registro Modificado");
            dgv.DataSource = Visualizar();
            dgv.Columns[0].HeaderText = "CODIGO";
            dgv.Columns[1].HeaderText = "DESCRIPCION";
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 220;
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text.Trim().Length > 0)
            {
                DialogResult respuestaAdvertencia = DialogResult.OK;
                respuestaAdvertencia = MessageBox.Show("¿Esta seguro de Eliminar el Turno?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestaAdvertencia == DialogResult.Yes)
                {
                    Turno t = new Turno();
                    t.CODT = txtCod.Text;
                    EliminarTurno(t);
                    dgv.DataSource = Visualizar();
                    dgv.Columns[0].HeaderText = "CODIGO";
                    dgv.Columns[1].HeaderText = "DESCRIPCION";
                    dgv.Columns[0].Width = 80;
                    dgv.Columns[1].Width = 220;
                    limpiar();
                    MessageBox.Show("Registro Eliminado Satisfactoriamente");
                }
                else 
                {
                    MessageBox.Show("Debe selecciona el Registro a Eliminar");
                }

            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                txtCod.Text = dgv.Rows[e.RowIndex].Cells["c"].FormattedValue.ToString();
                txtDes.Text = dgv.Rows[e.RowIndex].Cells["d"].FormattedValue.ToString();

            }
        }
    }
}
