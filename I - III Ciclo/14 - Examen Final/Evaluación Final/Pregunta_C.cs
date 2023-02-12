using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Final
{
    public class Pregunta_C
    {
        private int _pregunta_id;

        private string _pregunta_elegir;

        public int Pregunta_id { get => _pregunta_id; set => _pregunta_id = value; }
        public string Pregunta_elegir { get => _pregunta_elegir; set => _pregunta_elegir = value; }

        public static List<Pregunta_C> ListarPreguntas() 
        {
            try
            {
                using(pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from pr in bd.Pregunta select new Pregunta_C
                    {
                        Pregunta_elegir = pr.pregunta_elegir
                    }).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Pregunta_C ObtenerCodigoByName(string name)
        {
            try
            {

                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from pr in bd.Pregunta
                                    where pr.pregunta_elegir == name
                                    select new Pregunta_C
                                    {
                                        Pregunta_id = pr.pregunta_id
                                    }).First();
                    return consulta;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
