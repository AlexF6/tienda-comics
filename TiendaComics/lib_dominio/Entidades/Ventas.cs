
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Ventas
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("Clientes")] public Clientes? _Cliente { get; set; }
        [ForeignKey("Vendedores")] public Vendedores? _Vendedor { get; set; }
        [ForeignKey("MetodosDePagos")] public MetodosDePagos? _MetodoDePago { get; set; }
        [ForeignKey("Sucursales")] public Sucursales? _Sucursal { get; set; }
    }
}
