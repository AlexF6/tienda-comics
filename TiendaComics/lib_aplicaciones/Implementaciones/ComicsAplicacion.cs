using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class ComicsAplicacion : IComicsAplicacion
    {
        private IConexion? IConexion = null;

        public ComicsAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Comics? Borrar(Comics? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos
            return entidad;
        }

        public Comics? Guardar(Comics? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Calculos
            return entidad;
        }

        public List<Comics> Listar()
        {
            return this.IConexion!.Comics!
                .Take(20)
                .Include(x => x._Editorial)
                .Include(x => x._Categoria)
                .ToList();
        }

        public List<Comics> PorCodigo(Comics? entidad)
        {
            return this.IConexion!.Comics!
                .Where(x => x.Codigo!.Contains(entidad!.Codigo!))
                .Include(x => x._Editorial)
                .Include(x => x._Categoria)
                .ToList();
        }

        public Comics? Modificar(Comics? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            var entry = this.IConexion!.Entry<Comics>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
