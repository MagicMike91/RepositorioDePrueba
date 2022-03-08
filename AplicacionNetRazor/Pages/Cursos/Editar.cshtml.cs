using AplicacionNetRazor.Datos;
using AplicacionNetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacionNetRazor.Pages.Cursos
{
    public class EditarModel : PageModel
    {
        private readonly ApplicationDBContext _contexto;

        //Constructor
        public EditarModel(ApplicationDBContext contexto)
        {
            _contexto = contexto;
        }

        ///Le indica que es una propiedad de Vinculación
        [BindProperty]
        public Curso Curso { get; set; }

        //Carga el objeto recibido por Id
        public async Task OnGet(int Id)
        {
            Curso = await _contexto.Curso.FindAsync(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var CursoAux = await _contexto.Curso.FindAsync(Curso.Id);

                CursoAux.NombreCurso = Curso.NombreCurso;
                CursoAux.CantClases = Curso.CantClases;
                CursoAux.Precio = Curso.Precio;

                await _contexto.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
