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

        [Required]
        public string nombre { get; set;}

        public double precio { get; set; }

        [Required]
        public int cantidad { get; set; }

        [Required]
        public int talle { get; set; }
        public string imagen { get; set; }
    }
}
