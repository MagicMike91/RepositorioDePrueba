using EjercicioLainco.Libreria;
using EjercicioLainco.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.Models
{
    public class SeccionModel
    {
        /// <summary>
        /// Se encarga de recibir el Id del Area que se seleccionó
        /// y con ello devuelve todas las Secciones que le corresponden
        /// junto con sus Indicadores
        /// </summary>
        public static List<SeccionViewModel> DevolverSeccionesPorArea(int IdArea)
        {
            var areaDatos = new Datos();
            var seccionAux = areaDatos.ListaSecciones.Where(s => s.Id_Area == IdArea).ToList();
            List<SeccionViewModel> listaSecciones = null;

            foreach (var sec in seccionAux)
            {
                listaSecciones.Add(DevolverSeccion(sec.Id_Seccion));
            }

            return listaSecciones;
        }

        /// <summary>
        /// Se encarga de recibir que Seccion debe ser cargada y devolver todos sus datos
        /// </summary>
        public static SeccionViewModel DevolverSeccion(int IdSeccion)
        {
            //Creo el ViewModel a devolver
            var vm = new SeccionViewModel();
            //Cargo el que corresponda
            CargarSeccion(vm, IdSeccion);

            return vm;
        }

        /// <summary>
        /// Se encarga de cargar los datos de la Seccion que se debe enviar
        /// </summary>
        public static void CargarSeccion(SeccionViewModel vm, int IdSeccion)
        {
            var seccionDatos = new Datos();

            var seccionAux = seccionDatos.ListaSecciones.Where(s => s.Id_Seccion == IdSeccion).FirstOrDefault();

            vm.Id_Seccion = seccionAux.Id_Seccion;
            vm.Id_Area = seccionAux.Id_Area;
            vm.Nombre = seccionAux.Nombre;

            //Le cargo los indicadores que le corresponden
            vm.Indicadores = IndicadorModel.DevolverIndicadores(IdSeccion);
        }
    }
}
