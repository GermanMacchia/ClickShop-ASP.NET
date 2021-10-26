using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        public string telefono { get; set; }

        [Required(ErrorMessage = "La direccion es un dato requerido")]
        public int direccionId { get; set; }

        [Required(ErrorMessage = "El email es un dato requerido")]
        public string mail { get; set; }

        [Required(ErrorMessage = "El nombre es un dato requerido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido es un dato requerido")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "El dni es un dato requerido")]
        public int dni { get; set; }
    }
}
