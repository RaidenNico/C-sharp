using Microsoft.AspNetCore.Mvc;
using TiendaVirtualBD.Models;

namespace TiendaVirtualBD.Controllers
{
    public class ProductosController : Controller
    {
        //GET
        //dominio:puerto/Productos
        //dominio:puerto/Productos/Index
        public IActionResult Index()
        {
            List<Producto> listaProductos = new List<Producto>();

            using (TiendaVirtualBdContext BD = new TiendaVirtualBdContext())
            {
                listaProductos = (from p in BD.Productos select p).ToList();
            }

            return View(listaProductos);
        }

    }
}
