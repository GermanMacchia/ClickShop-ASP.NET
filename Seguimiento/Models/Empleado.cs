using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Empleado
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        [Key]
        public int legajo { get; set; }

    }
}
