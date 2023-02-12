using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TiendaVirtualBD.Models;

namespace TiendaVirtualBD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }
    }
}