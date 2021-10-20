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

        public string provicia { get; set;}

        public string calle { get; set; }

        public int numero { get; set; }

        public string localidad { get; set; }
    }
}
