
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seguimiento.Models
{
    public class SeguimientoContext : DbContext //hereda se pone ' : ' (lo traemos de fameworkCore)

    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Direccion> Direcciones { get; set; }
        DbSet<Empleado> Empleados { get; set; }
        DbSet<Pedido> Pedidos { get; set; }
        DbSet<Producto> Productos { get; set; }

        //DbContext nos permite crear la estructura de la tabla de DB
        //'Conection stream' (por lo gral 1 de desarrollo y otro de produccion) Servidor/Nombre/Seguridad:
        //¿Donde esta DB? ¿Como se llama? ¿Que nivel de seguridad?
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source = PC-DESKTOP; Initial Catalog = ClickShop; Integrated Security = true");
        }

    }
}
