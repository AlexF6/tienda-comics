
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class DetallesVentas
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public int Cantidad { get; set; }
        [ForeignKey("Ventas")] public Ventas? _Venta { get; set; }
        [ForeignKey("Comics")] public Comics? _Comic { get; set; }
    }
}
