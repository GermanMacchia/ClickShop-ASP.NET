using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Empleado
    {
        [Required]
        public string nombre { get; set; }

        [Required]
        public string apellido { get; set; }

        [Key]
        public int legajo { get; set; }

    }
}
