using EjercicioLainco.Libreria;
using EjercicioLainco.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.Models
{
    public class AreaModel
    {
        /// <summary>
        /// Se encarga de recibir que Area debe ser cargada y devolver todos sus datos
        /// </summary>
        public static AreaViewModel DevolverArea(int IdArea)
        {
            //Creo el ViewModel a devolver
            var vm = new AreaViewModel();
            //Cargo el que corresponda
            CargarArea(vm, IdArea);

            return vm;
        }

        /// <summary>
        /// Se encarga de cargar los datos de el Area que se debe enviar
        /// </summary>
        public static void CargarArea(AreaViewModel vm, int IdArea)
        {
            var areaDatos = new Datos();

            var areaAux = areaDatos.ListaAreas.Where(s => s.Id_Area == IdArea).FirstOrDefault();

            vm.Id_Area = areaAux.Id_Area;
            vm.Nombre = areaAux.Nombre;

            //Le cargo los indicadores que le corresponden
            vm.Secciones = SeccionModel.DevolverSeccionesPorArea(IdArea);
        }
    }
}
