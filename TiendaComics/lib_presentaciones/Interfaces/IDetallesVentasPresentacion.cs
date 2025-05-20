using lib_dominio.Entidades;

namespace lib_presentaciones.Interfaces
{
    public interface IDetallesVentasPresentacion
    {
        Task<List<DetallesVentas>> Listar();
        Task<List<DetallesVentas>> PorCodigo(DetallesVentas? entidad);
        Task<DetallesVentas?> Guardar(DetallesVentas? entidad);
        Task<DetallesVentas?> Modificar(DetallesVentas? entidad);
        Task<DetallesVentas?> Borrar(DetallesVentas? entidad);
    }
}