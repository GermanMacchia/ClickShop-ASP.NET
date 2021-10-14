using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Seguimiento
    {
        public string nombre { get; set; }

        public int id { get; set; }

        public List<Pedido> pedidos { get; set; }

        public List<Empleado> empleados { get;set;}

        public List <Cliente> clientes { get; set; }

    }
}
