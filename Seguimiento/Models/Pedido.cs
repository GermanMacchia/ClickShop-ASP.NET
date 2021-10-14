using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Pedido
    {
        private Cliente cliente  {get; set;}

        private String nroTraking {get; set;}

        private String comentarios { get; set;}

        private DateTime fechaEnvio { get; set;}

        private DateTime fechaInicio { get; set;}

        private Empleado encargado { get; set;}

        private List<Producto> productos { get; set;}

        private Direccion direccion { get; set;}

        private Estado estado { get; set; }

    }
}
