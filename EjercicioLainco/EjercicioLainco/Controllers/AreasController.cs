using EjercicioLainco.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EjercicioLainco.Controllers
{
    public class AreasController : Controller
    {
        /// <summary>
        /// Se encarga de cargar la vista inicial cuando se levanta la ventana
        /// </summary>
        public ActionResult Index ()
        {
            return View();
        }

        /// <summary>
        /// Se encarga de recibir que Area fué seleccionada
        /// y dependiendo de ello, carga a sus Secciones e Indicadores
        /// </summary>
        [HttpPost]
        public JsonResult BuscarDatosArea(int IdArea)
        {
            var vm = AreaModel.DevolverArea(IdArea);
            return Json(vm);           
        }
    }
}
