using lib_dominio.Entidades;

namespace lib_aplicaciones.Interfaces
{
    public interface ISucursalesAplicacion
    {
        void Configurar(string StringConexion);
        List<Sucursales> PorCodigo(Sucursales? entidad);
        List<Sucursales> Listar();
        Sucursales? Guardar(Sucursales? entidad);
        Sucursales? Modificar(Sucursales? entidad);
        Sucursales? Borrar(Sucursales? entidad);
    }
}