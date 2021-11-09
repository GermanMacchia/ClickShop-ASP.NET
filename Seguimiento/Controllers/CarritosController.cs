﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Seguimiento.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

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

           // GET: Carritos/Create
           public IActionResult Create()
           {
               return View();
           }

           // POST: Carritos/Create
           // To protect from overposting attacks, enable the specific properties you want to bind to.
           // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
           [HttpPost]
           [ValidateAntiForgeryToken]
           public async Task<IActionResult> Create([Bind("id,idProducto")] Carrito carrito)
           {
               if (ModelState.IsValid)
               {
                   _context.Add(carrito);
                   await _context.SaveChangesAsync();
                   return RedirectToAction(nameof(Index));
               }
               return View(carrito);
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
           // To protect from overposting attacks, enable the specific properties you want to bind to.
           // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
           [HttpPost]
           [ValidateAntiForgeryToken]
           public async Task<IActionResult> Edit(int id, [Bind("id,idProducto")] Carrito carrito)
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
           public async Task<IActionResult> DeleteConfirmed(int id)
           {
               var carrito = await _context.Carritos.FindAsync(id);
               _context.Carritos.Remove(carrito);
               await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
           }

           private bool CarritoExists(int id)
           {
               return _context.Carritos.Any(e => e.id == id);
           }


        /*
        public ActionResult ListaProductos(int? id)
            {
            List<Producto> productos = this.GetProductos();
            if(id != null)
            {
                List<int> codigoProductos;
                codigoProductos.Add(id.Value);
            }
            else{
               
            }
            return View(productos)

        */

        List<Producto> productos = new List<Producto>();

        public void agregarProductos(Producto producto)
        {
            if(producto != null)
            {
                productos.Add(producto);

            }
        }

        public ActionResult mostrarCarrito()
        {
            
            var carrito = new Carrito();
            carrito.ListaProductos = productos;

            return View(carrito);
        }


        // The static constructor is called as soon as the class is loaded into memory

    }
    }
    
