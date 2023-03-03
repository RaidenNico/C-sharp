using EvaluacionContinua2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EvaluacionContinua2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Silla", Descripcion = "Un mueble con asiento y respaldo diseñado para una sola persona.", Precio = 50 },
            new Producto { Id = 2, Nombre = "Computadora", Descripcion = "Un dispositivo electrónico que procesa datos y realiza cálculos complejos.", Precio = 1200 },
            new Producto { Id = 3, Nombre = "Automovil", Descripcion = "Un vehículo motorizado con cuatro ruedas diseñado para transportar personas.", Precio = 30000 },
            new Producto { Id = 4, Nombre = "Televisor", Descripcion = "Un dispositivo electrónico que muestra imágenes y sonidos transmitidos por ondas de radio.", Precio = 2000 },
            new Producto { Id = 5, Nombre = "Mesa", Descripcion = "Un mueble plano y horizontal que se utiliza para colocar objetos o trabajar en él.", Precio = 1300 },
            new Producto { Id = 6, Nombre = "Smartphone", Descripcion = "Un teléfono móvil inteligente que permite realizar una variedad de funciones más allá de las llamadas y mensajes de texto.", Precio = 1200 },
            new Producto { Id = 7, Nombre = "Camara", Descripcion = "Un dispositivo que captura imágenes y videos mediante la grabación de luz en un sensor de imagen.", Precio = 2300 },
            new Producto { Id = 8, Nombre = "Guitarra", Descripcion = "Un instrumento musical de cuerda pulsada que se toca con los dedos o una púa.", Precio = 1200 },
            new Producto { Id = 9, Nombre = "Refrigerador", Descripcion = "Un aparato eléctrico que mantiene los alimentos y bebidas frescos y conservados a baja temperatura.", Precio = 1300 },
        };

            return View(productos);
        }
    }
}