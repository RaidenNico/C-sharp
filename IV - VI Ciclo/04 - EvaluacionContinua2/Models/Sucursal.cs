using System;
using System.Collections.Generic;

namespace EvaluacionContinua2.Models;

public partial class Sucursal
{
    public int Idsucursal { get; set; }

    public string? Sucursal1 { get; set; }

    public string? Nombreencargado { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Comentario { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Inventario> Inventarios { get; } = new List<Inventario>();
}
