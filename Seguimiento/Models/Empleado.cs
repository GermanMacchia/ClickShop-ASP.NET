using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Empleado
    {
        [Required(ErrorMessage = "El nombre es un dato requerido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido es un dato requerido")]
        public string apellido { get; set; }

        [Key]
        public int legajo { get; set; }

    }
}
