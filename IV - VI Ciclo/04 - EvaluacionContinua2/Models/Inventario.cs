using System;
using System.Collections.Generic;

namespace EvaluacionContinua2.Models;

public partial class Inventario
{
    public int Idinventario { get; set; }

    public int? Idlibro { get; set; }

    public int? Idsucursal { get; set; }

    public string? Existencia { get; set; }

    public string? Comentarios { get; set; }

    public bool? Activo { get; set; }

    public virtual Libro? IdlibroNavigation { get; set; }

    public virtual Sucursal? IdsucursalNavigation { get; set; }
}
