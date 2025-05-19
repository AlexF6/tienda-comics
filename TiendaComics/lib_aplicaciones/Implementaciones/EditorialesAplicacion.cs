using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class EditorialesAplicacion : IEditorialesAplicacion
    {
        private IConexion? IConexion = null;

        public EditorialesAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Editoriales? Borrar(Editoriales? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            this.IConexion!.Editoriales!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Editoriales? Guardar(Editoriales? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Calculos

            this.IConexion!.Editoriales!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Editoriales> Listar()
        {
            return this.IConexion!.Editoriales!.Take(20).ToList();
        }

        public List<Editoriales> PorCodigo(Editoriales? entidad)
        {
            return this.IConexion!.Editoriales!
                .Where(x => x.Codigo!.Contains(entidad!.Codigo!))
                .ToList();
        }

        public Editoriales? Modificar(Editoriales? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            var entry = this.IConexion!.Entry<Editoriales>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
