﻿using System;
using System.Collections.Generic;

namespace TiendaVirtualBD.Models;

public partial class Tarjetum
{
    public int Id { get; set; }

    public string? Marca { get; set; }

    public string? Numero { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();
}
