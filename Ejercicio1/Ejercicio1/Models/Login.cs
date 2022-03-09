using System.ComponentModel.DataAnnotations;

namespace Ejercicio1.Models
{
    public class Login
    {
        [Key]
        public int IdLogin { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }  
        public string Password { get; set; }
        public int IdCliente { get; set; }
        public bool Habilitado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
