using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.ViewModels
{
    public class AreaViewModel
    {
        public int Id_Area { get; set; }
        public string Nombre { get; set; }
        public List<SeccionViewModel> Secciones { get; set; }
    }
}
