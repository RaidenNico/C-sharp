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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        public List<estructura> Visualizar()
        {
            try
            {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = (from c in bd.Carreras
                               orderby c.NOMC
                               select new estructura
                               {
                                   c = c.CODC,
                                   d = c.NOMC
                               }).ToList();
                    return sql;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AgregarCarrera(Carreras ca)
        {
            try
            {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    bd.Carreras.Add(ca);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ModificarCarrera(Carreras ca)
        {
            try
            {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = from c in bd.Carreras where c.CODC == ca.CODC select c;
                    foreach (Carreras cc in sql)
                    {
                        cc.CODC = ca.CODC;
                        cc.NOMC = ca.NOMC;
                    }
                    bd.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EliminarCarrera(Carreras ca)
        {
            try
            {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = from c in bd.Carreras where c.CODC == ca.CODC select c;
                    foreach (Carreras cc in sql)
                    {
                        bd.Carreras.Remove(cc);
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            dgv.DataSource = Visualizar();
            dgv.Columns[0].HeaderText = "CODIGO";
            dgv.Columns[1].HeaderText = "DESCRIPCION";
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 350;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Carreras c = new Carreras();
            c.CODC = txtCod.Text;
            c.NOMC = txtDes.Text;
            AgregarCarrera(c);
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
                Carreras c = bd.Carreras.Find(txtCod.Text);
                txtCod.Text = c.CODC;
                txtDes.Text = c.NOMC;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Carreras c = new Carreras();
            c.CODC = txtCod.Text;
            c.NOMC = txtDes.Text;
            ModificarCarrera(c);
            MessageBox.Show("Registro Modificado");
            dgv.DataSource = Visualizar();
            dgv.Columns[0].HeaderText = "CODIGO";
            dgv.Columns[1].HeaderText = "DESCRIPCION";
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 350;
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuestaAdvertencia = DialogResult.OK;
            respuestaAdvertencia = MessageBox.Show("¿Esta seguro de Eliminar la Carrera?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuestaAdvertencia == DialogResult.Yes)
            {
                Carreras c = new Carreras();
                c.CODC = txtCod.Text;
                EliminarCarrera(c);
                dgv.DataSource = Visualizar();
                dgv.Columns[0].HeaderText = "CODIGO";
                dgv.Columns[1].HeaderText = "DESCRIPCION";
                dgv.Columns[0].Width = 80;
                dgv.Columns[1].Width = 350;
                limpiar();
                MessageBox.Show("Registro Eliminado Satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Debe selecciona el Registro a Eliminar");
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
