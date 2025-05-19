

using System.ComponentModel.DataAnnotations;

namespace lib_dominio.Entidades
{
    public class MetodosDePagos
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
    }
}
