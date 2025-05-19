using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class VentasAplicacion : IVentasAplicacion
    {
        private IConexion? IConexion = null;

        public VentasAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Ventas? Borrar(Ventas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos
            return entidad;
        }

        public Ventas? Guardar(Ventas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Calculos
            return entidad;
        }

        public List<Ventas> Listar()
        {
            return this.IConexion!.Ventas!
                .Take(20)
                .Include(x => x._Cliente)
                .Include(x => x._Vendedor)
                .Include(x => x._MetodoDePago)
                .Include(x => x._Sucursal)
                .ToList();
        }

        public List<Ventas> PorCodigo(Ventas? entidad)
        {
            return this.IConexion!.Ventas!
                .Where(x => x.Codigo!.Contains(entidad!.Codigo!))
                .Include(x => x._Cliente)
                .Include(x => x._Vendedor)
                .Include(x => x._MetodoDePago)
                .Include(x => x._Sucursal)
                .ToList();
        }

        public Ventas? Modificar(Ventas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            var entry = this.IConexion!.Entry<Ventas>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
