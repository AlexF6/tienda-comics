using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class VendedoresAplicacion : IVendedoresAplicacion
    {
        private IConexion? IConexion = null;

        public VendedoresAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Vendedores? Borrar(Vendedores? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            this.IConexion!.Vendedores!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Vendedores? Guardar(Vendedores? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Calculos

            this.IConexion!.Vendedores!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Vendedores> Listar()
        {
            return this.IConexion!.Vendedores!.Take(20).ToList();
        }

        public List<Vendedores> PorCodigo(Vendedores? entidad)
        {
            return this.IConexion!.Vendedores!
                .Where(x => x.Carnet!.Contains(entidad!.Carnet!))
                .ToList();
        }

        public Vendedores? Modificar(Vendedores? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            var entry = this.IConexion!.Entry<Vendedores>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
