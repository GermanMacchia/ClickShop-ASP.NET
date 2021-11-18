using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public class Pedido
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El cliente es un dato requerido")]
        public int clienteId  {get; set;}

        public int nroTraking {get; set;}

        [StringLength(300)]
        public string comentarios { get; set;}

        public DateTime fechaEnvio { get; set;}

        [Required(ErrorMessage = "La Fecha Actual es un dato requerido")]
        public DateTime fechaInicio { get; set;}

        [Required(ErrorMessage = "El Encargado del Pedido es un dato requerido")]
        public int empleadoId { get; set;}

        public double totalCompra { get; set; }

        public Estado estado { get; set; }

    }
}
