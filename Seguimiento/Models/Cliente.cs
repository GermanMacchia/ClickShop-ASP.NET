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

        [Phone(ErrorMessage = "Ingrese un telefono válido")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "La direccion es un dato requerido")]
        public int direccionId { get; set; }

        [Required(ErrorMessage = "El email es un dato requerido")]
        [EmailAddress(ErrorMessage = "Ingrese un email válido")]
        public string mail { get; set; }

        [Required(ErrorMessage = "El nombre es un dato requerido")]
        [StringLength(20)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido es un dato requerido")]
        [StringLength(20)]
        public string apellido { get; set; }

        [Required(ErrorMessage = "El dni es un dato requerido")]
        [RegularExpression(@"[0-9]{8}", ErrorMessage = "El dni debe tener 8 digitos")]
        public int dni { get; set; }
    }
}
