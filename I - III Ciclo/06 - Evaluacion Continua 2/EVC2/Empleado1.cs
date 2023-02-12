using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVC2
{
    public class Empleado1
    {

        int empleado_id;
        string empleado_Paterno;
        string empleado_materno;
        string empleado_nombres;
        int empleado_edad;

        public int Empleado_id { get => empleado_id; set => empleado_id = value; }
        public string Empleado_Paterno { get => empleado_Paterno; set => empleado_Paterno = value; }
        public string Empleado_materno { get => empleado_materno; set => empleado_materno = value; }
        public string Empleado_nombres { get => empleado_nombres; set => empleado_nombres = value; }
        public int Empleado_edad { get => empleado_edad; set => empleado_edad = value; }


        public void guardarEmpleados()
        {
            using (BDEmpresa EMPLEADO = new BDEmpresa())
            {
                EMPLEADO estru = new EMPLEADO();
                estru.empleado_id = Empleado_id;
                estru.empleado_paterno = Empleado_Paterno;
                estru.empleado_materno = Empleado_materno;
                estru.empleado_nombres = Empleado_nombres;
                estru.empleado_edad = Empleado_edad;
                EMPLEADO.EMPLEADO.Add(estru);
                EMPLEADO.SaveChanges();
            }
            MessageBox.Show("Registro Guardado");

        }

        public void ModificarEmpleados()
        {
            using (BDEmpresa emp = new BDEmpresa())
            {

                EMPLEADO estru = new EMPLEADO();
                estru.empleado_id = Empleado_id;
                estru.empleado_paterno = Empleado_Paterno;
                estru.empleado_materno = Empleado_materno;
                estru.empleado_nombres = Empleado_nombres;
                estru.empleado_edad = Empleado_edad;
                emp.Entry(estru).State = System.Data.Entity.EntityState.Modified;
                emp.SaveChanges();
            }
        }

        //esto lista los datos
        public void ListaEmpleados(DataGridView dgvDatabase)
        {
            using (BDEmpresa emp = new BDEmpresa())
            {
                var lstemp = from d in emp.EMPLEADO select d;
                dgvDatabase.DataSource = lstemp.ToList();
            }
        }

        public void EliminarEmpleados(TextBox txt)
        {
            using (BDEmpresa emp = new BDEmpresa())
            {
                using (BDEmpresa bd = new BDEmpresa())
                {
                    EMPLEADO tra = bd.EMPLEADO.Find(Convert.ToInt32(txt.Text));
                    bd.EMPLEADO.Remove(tra);
                    bd.SaveChanges();

                }
            }
        }
    }
}


