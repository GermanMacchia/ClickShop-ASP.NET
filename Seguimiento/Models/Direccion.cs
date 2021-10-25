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

        [Required]
        public string provincia { get; set;}

        [Required]
        public string calle { get; set; }

        [Required]
        public int numero { get; set; }

        public string localidad { get; set; }

        public string referencia { get; set; }

    }
}
