using EjercicioLainco.Libreria.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.Libreria
{
    public class Indicador
    {
        public int Id_Seccion { get; set; }
        public int Id_Indicador { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public int Limite { get; set; }
        public TipoLimite TipoLimite { get; set; }
    }
}
