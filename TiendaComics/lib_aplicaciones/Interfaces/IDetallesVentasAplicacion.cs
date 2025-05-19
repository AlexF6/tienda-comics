using lib_dominio.Entidades;

namespace lib_aplicaciones.Interfaces
{
    public interface IDetallesVentasAplicacion
    {
        void Configurar(string StringConexion);
        List<DetallesVentas> PorCodigo(DetallesVentas? entidad);
        List<DetallesVentas> Listar();
        DetallesVentas? Guardar(DetallesVentas? entidad);
        DetallesVentas? Modificar(DetallesVentas? entidad);
        DetallesVentas? Borrar(DetallesVentas? entidad);
    }
}