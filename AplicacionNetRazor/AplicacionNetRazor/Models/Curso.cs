using System.ComponentModel.DataAnnotations;

namespace AplicacionNetRazor.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombre del Curso")]
        public string NombreCurso { get; set; }
        [Display(Name = "Cantidad de clases")]
        public int CantClases { get; set; }
        [Display(Name = "Precio")]
        public int Precio { get; set; }
        [Display(Name = "Fecha de creación")]
        public DateTime FechaCreacion { get; set; }
    }
}
