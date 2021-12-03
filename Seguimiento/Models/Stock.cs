using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Stock
    {

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "La cantidad es un dato requerido")]
        public int idProducto { get; set; }

        [Required(ErrorMessage = "La cantidad es un dato requerido")]
        public int cantidad { get; set; }

        public Stock(int idProducto, int cantidad)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
    }
}
