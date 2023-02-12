using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BibliotecaBd.Models;

namespace BibliotecaBd.Controllers
{
    public class InventariosController : Controller
    {
        private readonly BibliotecaBdContext _context;

        public InventariosController(BibliotecaBdContext context)
        {
            _context = context;
        }

        // GET: Inventarios
        public async Task<IActionResult> Index()
        {
            var bibliotecaBdContext = _context.Inventarios.Include(i => i.IdlibroNavigation).Include(i => i.IdsucursalNavigation);
            return View(await bibliotecaBdContext.ToListAsync());
        }

        // GET: Inventarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Inventarios == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventarios
                .Include(i => i.IdlibroNavigation)
                .Include(i => i.IdsucursalNavigation)
                .FirstOrDefaultAsync(m => m.Idinventario == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // GET: Inventarios/Create
        public IActionResult Create()
        {
            ViewData["Idlibro"] = new SelectList(_context.Libros, "Idlibro", "Idlibro");
            ViewData["Idsucursal"] = new SelectList(_context.Sucursals, "Idsucursal", "Idsucursal");
            return View();
        }

        // POST: Inventarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idinventario,Idlibro,Idsucursal,Existencia,Comentarios,Activo")] Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idlibro"] = new SelectList(_context.Libros, "Idlibro", "Idlibro", inventario.Idlibro);
            ViewData["Idsucursal"] = new SelectList(_context.Sucursals, "Idsucursal", "Idsucursal", inventario.Idsucursal);
            return View(inventario);
        }

        // GET: Inventarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Inventarios == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventarios.FindAsync(id);
            if (inventario == null)
            {
                return NotFound();
            }
            ViewData["Idlibro"] = new SelectList(_context.Libros, "Idlibro", "Idlibro", inventario.Idlibro);
            ViewData["Idsucursal"] = new SelectList(_context.Sucursals, "Idsucursal", "Idsucursal", inventario.Idsucursal);
            return View(inventario);
        }

        // POST: Inventarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idinventario,Idlibro,Idsucursal,Existencia,Comentarios,Activo")] Inventario inventario)
        {
            if (id != inventario.Idinventario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioExists(inventario.Idinventario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idlibro"] = new SelectList(_context.Libros, "Idlibro", "Idlibro", inventario.Idlibro);
            ViewData["Idsucursal"] = new SelectList(_context.Sucursals, "Idsucursal", "Idsucursal", inventario.Idsucursal);
            return View(inventario);
        }

        // GET: Inventarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Inventarios == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventarios
                .Include(i => i.IdlibroNavigation)
                .Include(i => i.IdsucursalNavigation)
                .FirstOrDefaultAsync(m => m.Idinventario == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // POST: Inventarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Inventarios == null)
            {
                return Problem("Entity set 'BibliotecaBdContext.Inventarios'  is null.");
            }
            var inventario = await _context.Inventarios.FindAsync(id);
            if (inventario != null)
            {
                _context.Inventarios.Remove(inventario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioExists(int id)
        {
          return _context.Inventarios.Any(e => e.Idinventario == id);
        }
    }
}
