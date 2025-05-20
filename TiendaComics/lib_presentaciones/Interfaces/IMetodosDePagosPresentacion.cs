using lib_dominio.Entidades;

namespace lib_presentaciones.Interfaces
{
    public interface IMetodosDePagosPresentacion
    {
        Task<List<MetodosDePagos>> Listar();
        Task<List<MetodosDePagos>> PorCodigo(MetodosDePagos? entidad);
        Task<MetodosDePagos?> Guardar(MetodosDePagos? entidad);
        Task<MetodosDePagos?> Modificar(MetodosDePagos? entidad);
        Task<MetodosDePagos?> Borrar(MetodosDePagos? entidad);
    }
}