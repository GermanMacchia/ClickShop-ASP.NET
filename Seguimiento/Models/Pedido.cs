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

        public DateTime fechaInicio { get; set;}

        public Empleado encargado { get; set;}

        public List<Producto> productos { get; set;}

        public Direccion direccion { get; set;}

        public Estado estado { get; set; }

    }
}
