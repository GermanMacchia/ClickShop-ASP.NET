using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }

        public string nombre { get; set;}

        public double precio { get; set; }

        public int cantidad { get; set; }

        public int talle { get; set; }
    }
}
