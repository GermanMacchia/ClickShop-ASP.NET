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

        [Required]
        public int direccionId { get; set; }

        [Required]
        public string mail { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public string apellido { get; set; }

        [Key]
        public int dni { get; set; }
    }
}
