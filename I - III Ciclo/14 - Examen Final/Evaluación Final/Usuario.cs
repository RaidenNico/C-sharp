//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Evaluación_Final
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int usuario_id { get; set; }
        public string usuario_email { get; set; }
        public string usuario_password { get; set; }
        public int pregunta_id { get; set; }
        public string usuario_respuesta { get; set; }
    
        public virtual Pregunta Pregunta { get; set; }
    }
}
