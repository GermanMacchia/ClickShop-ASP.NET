using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Compra
    {

        [Key]
        public int id { get; set; }

        [Required]
        public int idCarrito { get; set; }

        [Required]
        public int idProducto { get; set; }

        public Compra(int idCarrito, int idProducto)
        {
            this.idCarrito = idCarrito;
            this.idProducto = idProducto;
        }
    }


}
