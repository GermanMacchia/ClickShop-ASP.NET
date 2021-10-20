using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Cliente
    {
        public string telefono { get; set; }

        public string mail { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        [Key]
        public int dni { get; set; }
    }
}
