using System;
using System.Collections.Generic;

namespace TiendaVirtualBD.Models;

public partial class Marca
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
