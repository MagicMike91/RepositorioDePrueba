using AplicacionNetRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicacionNetRazor.Datos
{
    public class ApplicationDBContext : DbContext
    {
        //Constructor de la clase
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {}

        //Instancia necesaria para la creación en BBDD por migración
        public DbSet<Curso> Curso { get; set; }
    }
}
