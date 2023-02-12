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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
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
            cmbCarrera.Text = "";
            cmbTurno.Text = "";
            txtDni.Focus();
        }

        public List<combocarrera> comboc()
        {
            try {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = (from cc in bd.Carreras
                               orderby cc.NOMC
                               select new combocarrera
                               {
                                   nomcar = cc.NOMC
                               }

                             ).ToList();
                    return sql;
                }
            } catch(Exception) { throw; }
        }
        public List<comboturno> combot()
        {
            try {
                using (BDTardeEntities bd = new BDTardeEntities())
                { 
                    var sql=(from tt in bd.Turno orderby tt.NOMT
                             select new comboturno
                             { 
                                 nomtur=tt.NOMT
                             }).ToList();
                    return sql;
                }
            
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<alumnos> Visualizar()
        {
            try
            {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = (from n in bd.Alumnos
                               join t in bd.Turno on n.CODT equals t.CODT
                               join c in bd.Carreras on n.CODC equals c.CODC
                               orderby n.NOM
                               select new alumnos
                               {
                                   dni = n.DNI,
                                   apa = n.APA,
                                   ama = n.AMA,
                                   nom = n.NOM,
                                   car = c.NOMC,
                                   tur = t.NOMT
                               }).ToList();
                    return sql;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string buscarcodigo(string nomcarrera)
        {
            try {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = (from cc in bd.Carreras
                               where cc.NOMC == nomcarrera
                               orderby cc.NOMC
                               select new codigocar
                               {
                                   codc = cc.CODC
                               }).First();
                    return sql.codc;
                }
            
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string buscarturno(string nomturno)
        {
            try
            {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = (from tu in bd.Turno
                               where tu.NOMT == nomturno
                               orderby tu.NOMT
                               select new codigotur
                               {
                                   codt = tu.CODT
                               }).First();
                    return sql.codt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        
        }
        public void AgregarEstudiante(Alumnos datos)
        {
            try
            {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    bd.Alumnos.Add(datos);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ActualizarAlumnos(Alumnos humano)
        {
            try {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = from p in bd.Alumnos where p.DNI == humano.DNI select p;
                    foreach (Alumnos pas in sql)
                    { 
                        pas.APA = humano.APA;
                        pas.AMA = humano.AMA;
                        pas.NOM = humano.NOM;
                        pas.CODC=humano.CODC;
                        pas.CODT = humano.CODT;
                    }
                    bd.SaveChanges();
                }
            
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EliminarAlumno(Alumnos humano)
        {
            try
            {
                using (BDTardeEntities bd = new BDTardeEntities())
                {
                    var sql = from p in bd.Alumnos where p.DNI == humano.DNI select p;
                    foreach (Alumnos pas in sql)
                    {
                        bd.Alumnos.Remove(pas);
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
        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            cmbCarrera.DataSource = comboc();
            cmbCarrera.DisplayMember = "nomcar";
            cmbTurno.DataSource = combot();
            cmbTurno.DisplayMember = "nomtur";
            dgv.DataSource = Visualizar();
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 120;
            dgv.Columns[2].Width = 120;
            dgv.Columns[3].Width = 150;
            dgv.Columns[4].Width = 200;
            dgv.Columns[5].Width = 80;
            dgv.Columns[0].HeaderText = "DNI";
            dgv.Columns[1].HeaderText = "PATERNO";
            dgv.Columns[2].HeaderText = "MATERNO";
            dgv.Columns[3].HeaderText = "NOMBRES";
            dgv.Columns[4].HeaderText = "CARRERA PROFESIONAL";
            dgv.Columns[5].HeaderText = "TURNO";


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumnos al = new Alumnos();
            al.DNI=Convert.ToInt32(txtDni.Text);
            al.APA = txtApa.Text;
            al.AMA = txtAma.Text;
            al.NOM = txtNom.Text;
            string cc = buscarcodigo(cmbCarrera.Text);
            string tt = buscarturno(cmbTurno.Text);
            al.CODC = cc;
            al.CODT = tt;
            AgregarEstudiante(al);
            MessageBox.Show("Registro Guardado");
            dgv.DataSource = Visualizar();
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 120;
            dgv.Columns[2].Width = 120;
            dgv.Columns[3].Width = 150;
            dgv.Columns[4].Width = 200;
            dgv.Columns[5].Width = 80;
            dgv.Columns[0].HeaderText = "DNI";
            dgv.Columns[1].HeaderText = "PATERNO";
            dgv.Columns[2].HeaderText = "MATERNO";
            dgv.Columns[3].HeaderText = "NOMBRES";
            dgv.Columns[4].HeaderText = "CARRERA PROFESIONAL";
            dgv.Columns[5].HeaderText = "TURNO";
            limpiar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                txtDni.Text = dgv.Rows[e.RowIndex].Cells["dni"].FormattedValue.ToString();
                txtApa.Text = dgv.Rows[e.RowIndex].Cells["apa"].FormattedValue.ToString();
                txtAma.Text = dgv.Rows[e.RowIndex].Cells["ama"].FormattedValue.ToString();
                txtNom.Text = dgv.Rows[e.RowIndex].Cells["nom"].FormattedValue.ToString();
                cmbCarrera.Text = dgv.Rows[e.RowIndex].Cells["car"].FormattedValue.ToString();
                cmbTurno.Text = dgv.Rows[e.RowIndex].Cells["tur"].FormattedValue.ToString();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cc = buscarcodigo(cmbCarrera.Text);
            string tt = buscarturno(cmbTurno.Text);
            Alumnos alum = new Alumnos();
            alum.DNI = Convert.ToInt32(txtDni.Text);
            alum.APA = txtApa.Text;
            alum.AMA = txtAma.Text;
            alum.NOM = txtNom.Text;
            alum.CODC = cc;
            alum.CODT = tt;
            ActualizarAlumnos(alum);
            MessageBox.Show("Registro Modificado");
            dgv.DataSource = Visualizar();
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 120;
            dgv.Columns[2].Width = 120;
            dgv.Columns[3].Width = 150;
            dgv.Columns[4].Width = 200;
            dgv.Columns[5].Width = 80;
            dgv.Columns[0].HeaderText = "DNI";
            dgv.Columns[1].HeaderText = "PATERNO";
            dgv.Columns[2].HeaderText = "MATERNO";
            dgv.Columns[3].HeaderText = "NOMBRES";
            dgv.Columns[4].HeaderText = "CARRERA PROFESIONAL";
            dgv.Columns[5].HeaderText = "TURNO";
            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuestaAdvertencia = DialogResult.OK;
            respuestaAdvertencia = MessageBox.Show("¿Esta seguro de Eliminar al Alumno?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuestaAdvertencia == DialogResult.Yes)
            {
                Alumnos alumn = new Alumnos();
                alumn.DNI = Convert.ToInt32(txtDni.Text.ToString());
                EliminarAlumno(alumn);
                dgv.DataSource = Visualizar();
                MessageBox.Show("Registro Eliminado");
                dgv.DataSource = Visualizar();
                dgv.Columns[0].Width = 80;
                dgv.Columns[1].Width = 120;
                dgv.Columns[2].Width = 120;
                dgv.Columns[3].Width = 150;
                dgv.Columns[4].Width = 200;
                dgv.Columns[5].Width = 80;
                dgv.Columns[0].HeaderText = "DNI";
                dgv.Columns[1].HeaderText = "PATERNO";
                dgv.Columns[2].HeaderText = "MATERNO";
                dgv.Columns[3].HeaderText = "NOMBRES";
                dgv.Columns[4].HeaderText = "CARRERA PROFESIONAL";
                dgv.Columns[5].HeaderText = "TURNO";
                limpiar();


            }
            else
            {
                MessageBox.Show("Debe selecciona el Registro a Eliminar");
            }


        }
    }
}
