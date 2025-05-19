using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public partial class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Categorias>? Categorias { get; set; }
        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Comics>? Comics { get; set; }
        public DbSet<DetallesVentas>? DetallesVentas { get; set; }
        public DbSet<Editoriales>? Editoriales { get; set; }
        public DbSet<MetodosDePagos>? MetodosDePagos { get; set; }
        public DbSet<Sucursales>? Sucursales { get; set; }
        public DbSet<Vendedores>? Vendedores { get; set; }
        public DbSet<Ventas>? Ventas { get; set; }
    }
}
