using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class MetodosDePagosAplicacion : IMetodosDePagosAplicacion
    {
        private IConexion? IConexion = null;

        public MetodosDePagosAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public MetodosDePagos? Borrar(MetodosDePagos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            this.IConexion!.MetodosDePagos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public MetodosDePagos? Guardar(MetodosDePagos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Calculos

            this.IConexion!.MetodosDePagos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<MetodosDePagos> Listar()
        {
            return this.IConexion!.MetodosDePagos!.Take(20).ToList();
        }

        public List<MetodosDePagos> PorCodigo(MetodosDePagos? entidad)
        {
            return this.IConexion!.MetodosDePagos!
                .Where(x => x.Codigo!.Contains(entidad!.Codigo!))
                .ToList();
        }

        public MetodosDePagos? Modificar(MetodosDePagos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            var entry = this.IConexion!.Entry<MetodosDePagos>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
