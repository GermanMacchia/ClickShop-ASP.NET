using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Seguimiento.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//La SEPARACION DE INTERESES del modelo MVC hace de los controllers el intermediario
//entre los Modelos y las Vistas 
namespace Seguimiento.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SeguimientoContext _context;

        public HomeController(ILogger<HomeController> logger, SeguimientoContext context)
        {
            _logger = logger;
            _context = context;
        }


        //Ver startup endpoint
        public async Task<IActionResult> Index()
        {
            var empleados = await _context.Empleados.ToListAsync();
            ViewBag.emp = empleados;

            return View(await _context.Productos.ToListAsync());     
        }

        //..../CONTROLLER/ACTION/PARAMS
        //PRUEBA => .../home/detalle/id
        public IActionResult Detalle(int id)
        {
            return Ok("Pusiste en el parametro el numero " +  id);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
