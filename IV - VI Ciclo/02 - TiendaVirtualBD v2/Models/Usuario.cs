using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaVirtualBD.Models;

public partial class Usuario
{
    
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Nombres { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Apellidos { get; set; }

    [Required]
    [MaxLength(8)]
    public string? Dni { get; set; }

    [Required]
    [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")]
    public string? Correo { get; set; }

    [Required]
    public string? Contrasena { get; set; }

    public bool? Activo { get; set; }
}
