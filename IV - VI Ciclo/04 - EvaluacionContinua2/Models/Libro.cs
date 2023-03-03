using System;
using System.Collections.Generic;

namespace EvaluacionContinua2.Models;

public partial class Libro
{
    public int Idlibro { get; set; }

    public string? Titulolibro { get; set; }

    public string? Autor { get; set; }

    public string? Anio { get; set; }

    public string? Precio { get; set; }

    public string? Comentarios { get; set; }

    public string? Numpage { get; set; }

    public int? Ideditorial { get; set; }

    public bool? Activo { get; set; }

    public virtual Editorial? IdeditorialNavigation { get; set; }

    public virtual ICollection<Inventario> Inventarios { get; } = new List<Inventario>();
}
