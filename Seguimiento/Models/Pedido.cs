using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Pedido
    {
        public Cliente cliente  {get; set;}

        [Key]
        public int nroTraking {get; set;}

        public string comentarios { get; set;}

        public DateTime fechaEnvio { get; set;}

        [Required]
        public DateTime fechaInicio { get; set;}

        [Required]
        public Empleado encargado { get; set;}

        [Required]
        public List<Producto> productos { get; set;}

        public Direccion direccion { get; set;}

        [Required]
        public Estado estado { get; set; }

    }
}
