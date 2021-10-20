
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Seguimiento.Models
{
    public class SeguimientoContext : DbContext //hereda se pone ' : ' (lo traemos de fameworkCore)

    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }

        //DbContext nos permite crear la estructura de la tabla de DB
        //'Conection stream' (por lo gral 1 de desarrollo y otro de produccion) Servidor/Nombre/Seguridad:
        //¿Donde esta DB? ¿Como se llama? ¿Que nivel de seguridad?
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(@"Data Source = DESKTOP-9PL6VL2\SQLEXPRESS;" + "Initial Catalog = ClickShop;" + "Integrated Security = true");
        }

    }
}
