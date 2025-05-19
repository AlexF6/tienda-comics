
using System.ComponentModel.DataAnnotations;

namespace lib_dominio.Entidades
{
    public class Clientes
    {
        [Key] public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
    }
}
