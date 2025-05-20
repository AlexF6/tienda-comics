
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class DetallesVentas
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public int Cantidad { get; set; }
        public int Venta { get; set; }
        public int Comic { get; set; }
        [ForeignKey("Venta")] public Ventas? _Venta { get; set; }
        [ForeignKey("Comic")] public Comics? _Comic { get; set; }
    }
}
