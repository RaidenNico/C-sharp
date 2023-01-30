using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación_Final
{
    public class Usuario_C
    {

        private int _usuario_id;

        private string _usuario_email;

        private string _usuario_password;

        private int _pregunta_id;

        public int Usuario_id { get => _usuario_id; set => _usuario_id = value; }
        public string Usuario_email { get => _usuario_email; set => _usuario_email = value; }
        public string Usuario_password { get => _usuario_password; set => _usuario_password = value; }
        public int Pregunta_id { get => _pregunta_id; set => _pregunta_id = value; }

        public static bool buscarUsuario(Usuario us)
        {

            bool valor = false;

            try
            {
                using(pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from u in bd.Usuario where u.usuario_email == us.usuario_email && u.usuario_password == us.usuario_password select u);

                    foreach (Usuario uda in consulta)
                    {
                        valor = true;
                    }
                }
                return valor;
                
            }
            catch (NotSupportedException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario ObtenerCodigoByName(Usuario us)
        {
            try
            {
                using(pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from u in bd.Usuario
                                    where u.usuario_email == us.usuario_email && 
                                    u.pregunta_id == us.pregunta_id && 
                                    u.usuario_respuesta == us.usuario_respuesta
                                    select u).First();
                    return consulta;
                }
            }
            catch (NotSupportedException)
            {
                return us;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool UsuarioExistent(TextBox txt)
        {

            bool valor = false;

            try
            {
                using(pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from u in bd.Usuario where u.usuario_email == txt.Text.ToLower() select u);

                    foreach(Usuario ts in consulta)
                    {
                        valor = true;
                    }

                }
                return valor;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static void RegistrarUsuario(Usuario us)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    bd.Usuario.Add(us);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
