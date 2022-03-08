using EjercicioLainco.Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.ViewModels
{
    public class SeccionViewModel
    {
        public int Id_Seccion { get; set; }
        public int Id_Area { get; set; }
        public string Nombre { get; set; }
        public List<IndicadorViewModel> Indicadores { get; set; }
    }
}
