using lib_dominio.Entidades;

namespace lib_presentaciones.Interfaces
{
    public interface IComicsPresentacion
    {
        Task<List<Comics>> Listar();
        Task<List<Comics>> PorCodigo(Comics? entidad);
        Task<Comics?> Guardar(Comics? entidad);
        Task<Comics?> Modificar(Comics? entidad);
        Task<Comics?> Borrar(Comics? entidad);
    }
}