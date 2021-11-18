using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Seguimiento.Models
{
    public class Carrito
    {
        [Key]
        public int id { get; set; }

        public int idProducto { get; set; }

        [StringLength(20)]
        public string idNombre { get; set; }

        public int idTalle { get; set; }

        public double idPrecio { get; set; }

        public double totalCompra { get; set; }
        
    }
}
