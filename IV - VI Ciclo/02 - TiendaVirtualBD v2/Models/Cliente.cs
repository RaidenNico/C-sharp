using System;
using System.Collections.Generic;

namespace TiendaVirtualBD.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Dni { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();
}
