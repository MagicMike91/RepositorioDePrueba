using AplicacionNetRazor.Datos;
using AplicacionNetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacionNetRazor.Pages.Cursos
{
    public class CrearModel : PageModel
    {
        private readonly ApplicationDBContext _contexto;

        //Constructor
        public CrearModel(ApplicationDBContext contexto)
        {
            _contexto = contexto;
        }

        //Le indica que es una propiedad de Vinculación
        [BindProperty]
        public Curso Curso { get; set; } 

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            //Realiza las validaciones sobre el Formulario
            if(!ModelState.IsValid)
                return Page();

            Curso.NombreCurso = PrimeraEnMayuscula(Curso.NombreCurso);

            Curso.FechaCreacion = DateTime.Now;

            //Se encarga de agregar un objeto a la lista
            _contexto.Add(Curso);
            //Esta sentencia es quién impacta el cambio en la BBDD
            await _contexto.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        public string Minuscula(string cadena)
        {
            var respuesta = "";

            respuesta = cadena.ToLower();

            return respuesta;   
        }

        public string PrimeraEnMayuscula(string cadena)
        {
            var a = Minuscula(cadena);
            a = a.First().ToString().ToUpper() + a.Substring(1);
            return a;
        }
    }
}
