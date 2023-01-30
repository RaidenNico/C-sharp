using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVC2
{
    public partial class Form1 : Form
    {

        Empleado1 data = new Empleado1();


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // se Listan los extraen los Empleados de la base de datos
            data.ListaEmpleados(dgvDatabase);
        }

        private void dgvDatabase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Esto es Para Al Darle Click en una fila se va a mostrar los datos listados en sus cajas de texto

            string[] nom_atrib = new string[] {
                "empleado_id",
                "empleado_paterno",
                "empleado_materno",
                "empleado_nombres",
                "empleado_edad"
            };

            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvDatabase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDatabase.CurrentRow.Selected = true;
                int i = nom_atrib.Length - 1;
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = dgvDatabase.Rows[e.RowIndex].Cells[(nom_atrib[i])].FormattedValue.ToString();
                        i--;
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Helppers.Clean(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //
            using (BDEmpresa emp = new BDEmpresa())
            {
                int edad = Convert.ToInt32(txtEdad.Text);
                int id = Convert.ToInt32(txtID.Text);
                if (edad <= 100)
                {

                    data.Empleado_id = Convert.ToInt32(txtID.Text);
                    data.Empleado_Paterno = txtAPaterno.Text;
                    data.Empleado_materno = txtAMaterno.Text;
                    data.Empleado_nombres = txtNombres.Text;
                    data.Empleado_edad = edad;
                    data.guardarEmpleados();
                    data.ListaEmpleados(dgvDatabase);
                }
                else
                {
                    MessageBox.Show("El Empleado sobrepasa el Limite de edad", "Erro de Limite de Edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            data.Empleado_id = Convert.ToInt32(txtID.Text);
            data.Empleado_Paterno = txtAPaterno.Text;
            data.Empleado_materno = txtAMaterno.Text;
            data.Empleado_nombres = txtNombres.Text;
            data.Empleado_edad = Convert.ToInt32(txtEdad.Text);
            data.ModificarEmpleados();
            MessageBox.Show("Registro Modificado");
            data.ListaEmpleados(dgvDatabase);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            data.EliminarEmpleados(txtID);
        }

        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Helppers.keyPress(e, txtAPaterno);
        }

        private void txtAPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helppers.keyPress(e, txtAMaterno);
        }

        private void txtAMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helppers.keyPress(e, txtNombres);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helppers.keyPress(e, txtEdad);
        }
    }
}

