using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Categorias? Categorias()
        {
            var entidad = new Categorias();
            entidad.Codigo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas";
            entidad.EdadRecomendada = "Pruebas";
            return entidad;
        }

        public static Clientes? Clientes()
        {
            var entidad = new Clientes();
            entidad.Cedula = "Pruebas" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas";
            entidad.Email = "Pruebas";
            return entidad;
        }
        public static Editoriales? Editoriales()
        {
            var entidad = new Editoriales();
            entidad.Codigo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas";
            entidad.DistribuidorAsociado = "Pruebas";
            return entidad;
        }
        public static MetodosDePagos? MetodosDePagos()
        {
            var entidad = new MetodosDePagos();
            entidad.Codigo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas";
            entidad.Tipo = "Pruebas";
            return entidad;
        }
        public static Sucursales? Sucursales()
        {
            var entidad = new Sucursales();
            entidad.Codigo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas";
            entidad.Direccion = "Pruebas";
            return entidad;
        }
        public static Vendedores? Vendedores()
        {
            var entidad = new Vendedores();
            entidad.Carnet = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas";
            return entidad;
        }
        public static Ventas? Ventas()
        {
            var entidad = new Ventas();
            entidad.Codigo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Fecha = DateTime.Now;
            entidad.Cliente = 1;
            entidad.Vendedor = 1;
            entidad.MetodoDePago = 1;
            entidad.Sucursal = 1;
            return entidad;
        }

        public static Comics? Comics()
        {
            var entidad = new Comics();
            entidad.Codigo = "Pruebas";
            entidad.Nombre = "Pruebas";
            entidad.Precio = 1000.0m;
            entidad.Categoria = 1;
            entidad.Editorial = 1;
            return entidad;
        }
        public static DetallesVentas? DetallesVentas()
        {
            var entidad = new DetallesVentas();
            entidad.Codigo = "Pruebas";
            entidad.Cantidad = 1;
            entidad.Venta = 1;
            entidad.Comic = 1;
            return entidad;
        }
    }
}
