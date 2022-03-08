using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.Libreria
{
    public class Area
    {
        public int Id_Area { get; set; }
        public string Nombre { get; set; }
        public List<Seccion> Secciones { get; set; }
    }
}
