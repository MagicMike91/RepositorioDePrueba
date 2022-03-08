using EjercicioLainco.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.Controllers
{
    public class SeccionesController : Controller
    {

        /// <summary>
        /// Se encarga de recibir que seccion fué seleccionada
        /// y dependiendo de ello devuelve a la misma y a sus Indicadores correspondientes
        /// </summary>
        [HttpPost]
        public JsonResult BuscarDatosSecciones(int IdSeccion)
        {
            var vm = SeccionModel.DevolverSeccion(IdSeccion);
            return Json(vm);
        }
    }
}
