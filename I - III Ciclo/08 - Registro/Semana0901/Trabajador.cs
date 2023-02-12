using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana0901
{
    public  class Trabajador : Persona
    {
        public double Sueldo { get; set; }

        public Trabajador(double pSueldo,string pNombres, string pApellidoPaterno, string pApellidoMaterno, string pDni, DateTime pFechaNacimiento)
        : base(pNombres, pApellidoPaterno, pApellidoMaterno, pDni, pFechaNacimiento)
        {
            Sueldo = pSueldo;
        }


    }
}
