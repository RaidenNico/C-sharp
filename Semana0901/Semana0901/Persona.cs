using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana0901
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad
        {
            get
            {
                TimeSpan diferencia = DateTime.Now - FechaNacimiento;
                int anios = Convert.ToInt32(Math.Truncate(diferencia.Days / 365.2425));
                return anios;
            }
        }

        public Persona(string pNombres, string pApellidoPaterno, string pApellidoMaterno, string pDni, DateTime pFechaNacimiento)
        {
            Nombres = pNombres; ApellidoPaterno = pApellidoPaterno; ApellidoMaterno = pApellidoMaterno; Dni = pDni;
            FechaNacimiento = pFechaNacimiento;
        }



    }
}
