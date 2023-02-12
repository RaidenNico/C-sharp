using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaBd.Models;

public partial class Sucursal
{
    public int Idsucursal { get; set; }
    [Required]
    public string? Sucursal1 { get; set; }
    [Required]
    public string? Nombreencargado { get; set; }
    [Required]
    public string? Direccion { get; set; }
    [Required]
    public string? Ciudad { get; set; }
    [Required]
    public string? Telefono { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Comentario { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Inventario> Inventarios { get; } = new List<Inventario>();
}
