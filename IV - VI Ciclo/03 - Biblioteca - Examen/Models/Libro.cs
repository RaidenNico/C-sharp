using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaBd.Models;

public partial class Libro
{
    public int Idlibro { get; set; }
    [Required]
    public string? Titulolibro { get; set; }
    [Required]
    public string? Autor { get; set; }
    [Required]
    public string? Anio { get; set; }
    [Required]
    public string? Precio { get; set; }
    [Required]
    public string? Comentarios { get; set; }
    [Required]
    public string? Numpage { get; set; }
    
    public int? Ideditorial { get; set; }
   
    public bool? Activo { get; set; }
   
    public virtual Editorial? IdeditorialNavigation { get; set; }

    public virtual ICollection<Inventario> Inventarios { get; } = new List<Inventario>();
}
