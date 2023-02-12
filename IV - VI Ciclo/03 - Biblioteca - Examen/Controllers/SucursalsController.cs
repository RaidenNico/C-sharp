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
    public class SucursalsController : Controller
    {
        private readonly BibliotecaBdContext _context;

        public SucursalsController(BibliotecaBdContext context)
        {
            _context = context;
        }

        // GET: Sucursals
        public async Task<IActionResult> Index()
        {
              return View(await _context.Sucursals.ToListAsync());
        }

        // GET: Sucursals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sucursals == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursals
                .FirstOrDefaultAsync(m => m.Idsucursal == id);
            if (sucursal == null)
            {
                return NotFound();
            }

            return View(sucursal);
        }

        // GET: Sucursals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sucursals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idsucursal,Sucursal1,Nombreencargado,Direccion,Ciudad,Telefono,Email,Comentario,Activo")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sucursal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sucursal);
        }

        // GET: Sucursals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sucursals == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursals.FindAsync(id);
            if (sucursal == null)
            {
                return NotFound();
            }
            return View(sucursal);
        }

        // POST: Sucursals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idsucursal,Sucursal1,Nombreencargado,Direccion,Ciudad,Telefono,Email,Comentario,Activo")] Sucursal sucursal)
        {
            if (id != sucursal.Idsucursal)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sucursal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SucursalExists(sucursal.Idsucursal))
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
            return View(sucursal);
        }

        // GET: Sucursals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sucursals == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursals
                .FirstOrDefaultAsync(m => m.Idsucursal == id);
            if (sucursal == null)
            {
                return NotFound();
            }

            return View(sucursal);
        }

        // POST: Sucursals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sucursals == null)
            {
                return Problem("Entity set 'BibliotecaBdContext.Sucursals'  is null.");
            }
            var sucursal = await _context.Sucursals.FindAsync(id);
            if (sucursal != null)
            {
                _context.Sucursals.Remove(sucursal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SucursalExists(int id)
        {
          return _context.Sucursals.Any(e => e.Idsucursal == id);
        }
    }
}
