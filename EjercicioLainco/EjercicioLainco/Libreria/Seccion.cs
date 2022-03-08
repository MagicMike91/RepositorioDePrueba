using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.Libreria
{
    public class Seccion
    {
        public int Id_Area { get; set; }
        public int Id_Seccion { get; set; }
        public string Nombre { get; set; }
        public List<Indicador> Indicadores { get; set; }
    }
}
