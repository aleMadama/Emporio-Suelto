using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCEcommerce.Models;
using System.Collections.Generic;

namespace MVCEcommerce.Context
{
    public class NuevoYLiberadoDatabaseContext : DbContext
    {
        public NuevoYLiberadoDatabaseContext(DbContextOptions<NuevoYLiberadoDatabaseContext> options) : base(options) 
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
    }
}
