using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguimiento.Models
{
    public enum Estado
    {
        Pendiente = 0,
        Preparado_ya_pago = 1,
        preparado_no_pago = 2,
        Enviado = 3,
        Recibido = 4
    }
}
