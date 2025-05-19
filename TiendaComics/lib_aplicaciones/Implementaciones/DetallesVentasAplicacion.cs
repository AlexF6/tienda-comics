using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class DetallesVentasAplicacion : IDetallesVentasAplicacion
    {
        private IConexion? IConexion = null;

        public DetallesVentasAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public DetallesVentas? Borrar(DetallesVentas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos
            return entidad;
        }

        public DetallesVentas? Guardar(DetallesVentas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Calculos
            return entidad;
        }

        public List<DetallesVentas> Listar()
        {
            return this.IConexion!.DetallesVentas!
                .Take(20)
                .Include(x => x._Venta)
                .Include(x => x._Comic)
                .ToList();
        }

        public List<DetallesVentas> PorCodigo(DetallesVentas? entidad)
        {
            return this.IConexion!.DetallesVentas!
                .Where(x => x.Codigo!.Contains(entidad!.Codigo!))
                .Include(x => x._Venta)
                .Include(x => x._Comic)
                .ToList();
        }

        public DetallesVentas? Modificar(DetallesVentas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            var entry = this.IConexion!.Entry<DetallesVentas>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
