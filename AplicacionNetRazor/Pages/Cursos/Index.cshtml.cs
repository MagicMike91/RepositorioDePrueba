using AplicacionNetRazor.Datos;
using AplicacionNetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AplicacionNetRazor.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _contexto;

        //Constructor
        public IndexModel(ApplicationDBContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Curso> Cursos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public async Task OnGet()
        {
            //Esta linea se encarga de ir a la BBDD y traer los datos de la tabla que le indique, en este caso "Curso"
            Cursos = await _contexto.Curso.ToListAsync();
        }

        public async Task<IActionResult> OnPostBorrar(int id)
        {
            var curso = await _contexto.Curso.FindAsync(id);

            //agrego
            if (curso == null)
                return NotFound();

            //Esta es la linea que impacta en BBDD
            _contexto.Curso.Remove(curso);
            await _contexto.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
