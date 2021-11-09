﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Seguimiento.Models
{
    public class Carrito
    {
        [Key]
        public int id { get; set; }

        public List<Producto> ListaProductos { get; set; }

    }
}
