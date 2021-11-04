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

        [Required(ErrorMessage = "El nombre es un dato requerido")]

        [StringLength(20)]
        public string nombre { get; set;}

        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Poner un precio válido para el producto")]
        public double precio { get; set; }

        [Required(ErrorMessage = "La cantidad es un dato requerido")]
        public int cantidad { get; set; }

        [Required(ErrorMessage = "El talle es un dato requerido")]
        public int talle { get; set; }

        public string imagen { get; set; }
    }
}
