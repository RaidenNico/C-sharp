using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaBd.Models;

public partial class Editorial
{
    public int Ideditorial { get; set; }
    [Required]
    public string? Editorial1 { get; set; }
    [Required]
    public string? Nombrecontacto { get; set; }
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
    [Required]
    public bool? Activo { get; set; }
    [Required]
    public virtual ICollection<Libro> Libros { get; } = new List<Libro>();
}
