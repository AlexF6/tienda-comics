using lib_dominio.Entidades;

namespace lib_aplicaciones.Interfaces
{
    public interface IMetodosDePagosAplicacion
    {
        void Configurar(string StringConexion);
        List<MetodosDePagos> PorCodigo(MetodosDePagos? entidad);
        List<MetodosDePagos> Listar();
        MetodosDePagos? Guardar(MetodosDePagos? entidad);
        MetodosDePagos? Modificar(MetodosDePagos? entidad);
        MetodosDePagos? Borrar(MetodosDePagos? entidad);
    }
}