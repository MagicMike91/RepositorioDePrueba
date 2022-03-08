using EjercicioLainco.Libreria;
using EjercicioLainco.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.Models
{
    public class IndicadorModel
    {
        /// <summary>
        /// Se encarga de recibir que Indicadores debe ser cargados y devolver todos sus datos
        /// </summary>
        public static List<IndicadorViewModel> DevolverIndicadores(int IdSeccion)
        {
            //Creo el ViewModel a devolver
            List<IndicadorViewModel> indicadoresLista = new List<IndicadorViewModel>();

            //Cargo el que corresponda
            CargarIndicadores(indicadoresLista, IdSeccion);

            return indicadoresLista;
        }

        /// <summary>
        /// Se encarga de cargar los datos de los Indicadores que se deben enviar
        /// </summary>
        public static void CargarIndicadores(List<IndicadorViewModel> vm, int idSeccion)
        {
            //Instancio la clase de ejemplo de la que sacaré los datos que necesito
            var datosBase = new Datos();

            foreach (var ind in datosBase.ListaIndicadores)
            {
                if (ind.Id_Seccion == idSeccion)
                {
                    var indAux = new IndicadorViewModel();

                    indAux.Id_Indicador = ind.Id_Indicador;
                    indAux.Id_Seccion = ind.Id_Seccion;
                    indAux.Nombre = ind.Nombre;
                    indAux.Valor = ind.Valor;
                    indAux.Limite = ind.Limite;
                    indAux.TipoLimite = ind.TipoLimite;

                    if (ind.Valor > ind.Limite)
                        indAux.ExcedeLimite = true;
                    else
                        indAux.ExcedeLimite = false;


                    vm.Add(indAux);
                }
            }
        }
    }
}
