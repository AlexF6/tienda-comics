
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Ventas
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public int Cliente { get; set; }
        public int Vendedor { get; set; }
        public int MetodoDePago { get; set; }
        public int Sucursal { get; set; }
        [ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
        [ForeignKey("Vendedor")] public Vendedores? _Vendedor { get; set; }
        [ForeignKey("MetodoDePago")] public MetodosDePagos? _MetodoDePago { get; set; }
        [ForeignKey("Sucursal")] public Sucursales? _Sucursal { get; set; }
    }
}
