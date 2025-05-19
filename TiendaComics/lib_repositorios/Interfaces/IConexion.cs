using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }
        
        DbSet<Categorias>? Categorias { get; set; }
        DbSet<Clientes>? Clientes { get; set; }
        DbSet<DetallesVentas>? DetallesVentas { get; set; }
        DbSet<Editoriales>? Editoriales { get; set; }
        DbSet<MetodosDePagos>? MetodosDePagos { get; set; }
        DbSet<Sucursales>? Sucursales { get; set; }
        DbSet<Vendedores>? Vendedores { get; set; }
        DbSet<Ventas>? Ventas { get; set; }
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
