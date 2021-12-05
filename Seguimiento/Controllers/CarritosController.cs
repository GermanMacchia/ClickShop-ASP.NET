using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Seguimiento.Models;

namespace Seguimiento.Controllers
{
    public class CarritosController : Controller
    {
        private readonly SeguimientoContext _context;

        public CarritosController(SeguimientoContext context)
        {
            _context = context;
        }

        // GET: Carritos
        public async Task<IActionResult> Index()
        {
            var empleados = await _context.Empleados.ToListAsync();
            var clientes = await _context.Clientes.ToListAsync();
            var listado = await _context.Carritos.ToListAsync();
            if(listado.Count() != 0)
            {
                ViewBag.total = listado[listado.Count() - 1].totalCompra;
            }
            ViewBag.emp = empleados;
            ViewBag.cli = clientes;
            return View(await _context.Carritos.ToListAsync());
        }

        // GET: Carritos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carritos
                .FirstOrDefaultAsync(m => m.id == id);
            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        //ACTION CUSTOM, EJECUTA Y LLAMA A INDEX DE HOME
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Crear([Bind("id, idProducto, idNombre, idPrecio, idTalle, totalCompra")] Carrito carrito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrito);
                int id = carrito.idProducto;

                var prod = await _context.Productos.FindAsync(id);
                prod.cantidad = prod.cantidad - 1;
                _context.Update(prod);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home", null);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAll()
        {
            var lista = await _context.Carritos.ToListAsync();


            foreach (var i in lista)
            {
                var carrito = await _context.Carritos.FindAsync(i.id);
                int id = carrito.idProducto;
                var prod = await _context.Productos.FindAsync(id);

                if (prod != null)

                {
                    prod.cantidad = prod.cantidad + 1;
                    _context.Update(prod);
                }

                _context.Carritos.Remove(i);
                await _context.SaveChangesAsync();
            }

            return View("Index");
        }


        // GET: Carritos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carritos.FindAsync(id);
            if (carrito == null)
            {
                return NotFound();
            }
            return View(carrito);
        }

        // POST: Carritos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id, idProducto, idNombre, idPrecio, idTalle")] Carrito carrito)
        {
            if (id != carrito.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarritoExists(carrito.id))
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
            return View(carrito);
        }

        // GET: Carritos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carritos
                .FirstOrDefaultAsync(m => m.id == id);

            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        // POST: Carritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var carrito = await _context.Carritos.FindAsync(id);

            int idNuevo = carrito.idProducto;

            var prod = await _context.Productos.FindAsync(idNuevo);
            
            if (prod!= null)
            
            {
                prod.cantidad = prod.cantidad + 1;
                _context.Update(prod);
            }

            _context.Carritos.Remove(carrito);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home", null);
        }

        private bool CarritoExists(int id)
        {
            return _context.Carritos.Any(e => e.id == id);
        }
    }
}
