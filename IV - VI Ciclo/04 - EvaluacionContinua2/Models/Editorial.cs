using System;
using System.Collections.Generic;

namespace EvaluacionContinua2.Models;

public partial class Editorial
{
    public int Ideditorial { get; set; }

    public string? Editorial1 { get; set; }

    public string? Nombrecontacto { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Comentario { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Libro> Libros { get; } = new List<Libro>();
}
