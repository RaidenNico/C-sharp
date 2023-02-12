using Microsoft.AspNetCore.Mvc;
using TiendaVirtualBD.Models;

namespace TiendaVirtualBD.Controllers
{
    public class CategoriasController : Controller
    {
        /*  public IActionResult Index()
          {
              return View();
          }*/
        /*  public String Index()
          {
              String mensaje = "Responde el metodo 'Index()' del Controlador 'Categorias'";
              return mensaje;
          }*/
        /* public String MostrarCategoria(int Id)
        {
            String mensaje = "Id solicitado: " + Id.ToString();
            return mensaje;
        } */
        /* public String MostrarCategoria(int Id)
         {
             String mensaje = "Categoria solicitada:\n\n";

             using (TiendaVirtualBdContext BD = new TiendaVirtualBdContext())
             {
                 var listaCategorias = (from c in BD.Categoria
                 where c.Id == Id
                                        select new Categorium
                                        {
                                            Id = c.Id, 
                                            Nombre = c.Nombre,
                                            Activo = c.Activo

                                        }).ToList();

                 if (listaCategorias.Count > 0)
                 {
                     Categorium categoria = listaCategorias.First();
                     String activo = categoria.Activo.GetValueOrDefault() ? "Si" : "No";

                     mensaje += "Id    : " + categoria.Id.ToString() + "\n";
                     mensaje += "Nombre: " + categoria.Nombre + "\n";
                     mensaje += "Activo: " + activo;
                 }
                 else
                 {
                     mensaje = "El Producto no existe en la BD.";
                 }
             }

             return mensaje;
         }
        */
        public IActionResult MostrarCategoria(int Id)
        {
            Categorium categoria = new Categorium();

            using (TiendaVirtualBdContext BD = new TiendaVirtualBdContext())
            {
                var listaCategorias = (from c in BD.Categoria
                                       where c.Id == Id
                                       select new Categorium
                                       {
                                           Id = c.Id,
                                           Nombre = c.Nombre,
                                           Activo = c.Activo

                                       }).ToList();

                if (listaCategorias.Count > 0)
                {
                    categoria = listaCategorias.First();
                    ViewData["activo"] = categoria.Activo.GetValueOrDefault() ? "Si" : "No";
                }
            }

            return View(categoria);
        }

    }
}
