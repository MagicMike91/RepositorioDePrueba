using Ejercicio1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio1.Datos
{
    public class ApplicationDBContext : DbContext
    {
        //Constructor de la clase
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {}

        //Instancia necesaria para la creación de la BBDD por migración
        public DbSet<Login> Login { get; set; }
    }
}
