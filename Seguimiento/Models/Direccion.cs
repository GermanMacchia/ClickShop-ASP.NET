using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Direccion
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "La provincia es un dato requerido")]
        public string provincia { get; set;}

        [Required(ErrorMessage = "La calle es un dato requerido")]
        public string calle { get; set; }

        [Required(ErrorMessage = "El numero es un dato requerido") ]
        public int numero { get; set; }

        [Required(ErrorMessage = "La localidad es un dato requerido")]
        public string localidad { get; set; }

        public string referencia { get; set; }

    }
}
