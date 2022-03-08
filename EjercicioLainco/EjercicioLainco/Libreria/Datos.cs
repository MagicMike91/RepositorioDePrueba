using EjercicioLainco.Libreria.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioLainco.Libreria
{
    public class Datos
    {
        public List<Area> ListaAreas { get; set; }
        public List<Seccion> ListaSecciones { get; set; }
        public List<Indicador> ListaIndicadores { get; set; }
        public Datos()
        {
            #region Cargar la lista de Areas
            this.ListaAreas.Add(new Area { Id_Area = 1, Nombre = "Desarrollo", Secciones = null });
            this.ListaAreas.Add(new Area { Id_Area = 2, Nombre = "Administración", Secciones = null });
            this.ListaAreas.Add(new Area { Id_Area = 3, Nombre = "Seguridad", Secciones = null });
            #endregion

            #region Cargar la lista de Secciones 
            //Desarrollo
            this.ListaSecciones.Add(new Seccion { Id_Area = 1, Id_Seccion = 1, Nombre = "Relevamiento", Indicadores = null});
            this.ListaSecciones.Add(new Seccion { Id_Area = 1, Id_Seccion = 2, Nombre = "Desarrollo", Indicadores = null });
            this.ListaSecciones.Add(new Seccion { Id_Area = 1, Id_Seccion = 3, Nombre = "Implementación", Indicadores = null });
            //Administración
            this.ListaSecciones.Add(new Seccion { Id_Area = 2, Id_Seccion = 4, Nombre = "Relevamiento", Indicadores = null });
            this.ListaSecciones.Add(new Seccion { Id_Area = 2, Id_Seccion = 5, Nombre = "Desarrollo", Indicadores = null });
            this.ListaSecciones.Add(new Seccion { Id_Area = 2, Id_Seccion = 6, Nombre = "Implementación", Indicadores = null });
            //Seguridad
            this.ListaSecciones.Add(new Seccion { Id_Area = 3, Id_Seccion = 7, Nombre = "Relevamiento", Indicadores = null });
            this.ListaSecciones.Add(new Seccion { Id_Area = 3, Id_Seccion = 8, Nombre = "Desarrollo", Indicadores = null });
            this.ListaSecciones.Add(new Seccion { Id_Area = 3, Id_Seccion = 9, Nombre = "Implementación", Indicadores = null });
            #endregion

            #region Cargar la lista de Indicadores
            //Relevamiento
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 1, Id_Indicador = 1, Nombre = "Documentos", Limite = 4, TipoLimite = TipoLimite.Unidad, Valor = 7});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 1, Id_Indicador = 2, Nombre = "Desvíos", Limite = 5, TipoLimite = TipoLimite.Porcentaje, Valor = 14 });
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 4, Id_Indicador = 3, Nombre = "Documentos", Limite = 4, TipoLimite = TipoLimite.Unidad, Valor = 7 });
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 4, Id_Indicador = 4, Nombre = "Desvíos", Limite = 5, TipoLimite = TipoLimite.Porcentaje, Valor = 14 });
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 7, Id_Indicador = 5, Nombre = "Documentos", Limite = 4, TipoLimite = TipoLimite.Unidad, Valor = 7 });
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 7, Id_Indicador = 6, Nombre = "Desvíos", Limite = 5, TipoLimite = TipoLimite.Porcentaje, Valor = 14 });
            //Desarrollo
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 2, Id_Indicador = 7, Nombre = "Desvíos", Limite = 20, TipoLimite = TipoLimite.Unidad, Valor = 14 });
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 5, Id_Indicador = 8, Nombre = "Desvíos", Limite = 20, TipoLimite = TipoLimite.Unidad, Valor = 14 });
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 8, Id_Indicador = 9, Nombre = "Desvíos", Limite = 20, TipoLimite = TipoLimite.Unidad, Valor = 14 });
            //Implementación
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 3, Id_Indicador = 10, Nombre = "Implementaciones", Limite = 20, TipoLimite = TipoLimite.Unidad, Valor =  7});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 6, Id_Indicador = 11, Nombre = "Implementaciones", Limite = 20, TipoLimite = TipoLimite.Unidad, Valor =  7});            
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 9, Id_Indicador = 12, Nombre = "Implementaciones", Limite = 20, TipoLimite = TipoLimite.Unidad, Valor =  7});

            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 3, Id_Indicador = 13, Nombre = "Tasa de Reimpl.", Limite = 10, TipoLimite = TipoLimite.Porcentaje, Valor =  11});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 6, Id_Indicador = 14, Nombre = "Tasa de Reimpl.", Limite = 10, TipoLimite = TipoLimite.Porcentaje, Valor =  11});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 9, Id_Indicador = 15, Nombre = "Tasa de Reimpl.", Limite = 10, TipoLimite = TipoLimite.Porcentaje, Valor =  11});

            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 3, Id_Indicador = 16, Nombre = "Lorem", Limite = 20, TipoLimite = TipoLimite.Porcentaje, Valor =  14});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 6, Id_Indicador = 17, Nombre = "Lorem", Limite = 20, TipoLimite = TipoLimite.Porcentaje, Valor =  14});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 9, Id_Indicador = 18, Nombre = "Lorem", Limite = 20, TipoLimite = TipoLimite.Porcentaje, Valor =  14});

            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 3, Id_Indicador = 19, Nombre = "Ipsum", Limite = 5, TipoLimite = TipoLimite.Porcentaje, Valor =  4});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 6, Id_Indicador = 20, Nombre = "Ipsum", Limite = 5, TipoLimite = TipoLimite.Porcentaje, Valor =  4});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 9, Id_Indicador = 21, Nombre = "Ipsum", Limite = 5, TipoLimite = TipoLimite.Porcentaje, Valor =  4});

            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 3, Id_Indicador = 22, Nombre = "Lorem", Limite = 7, TipoLimite = TipoLimite.Porcentaje, Valor =  6});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 6, Id_Indicador = 23, Nombre = "Lorem", Limite = 7, TipoLimite = TipoLimite.Porcentaje, Valor =  6});
            this.ListaIndicadores.Add(new Indicador { Id_Seccion = 9, Id_Indicador = 24, Nombre = "Lorem", Limite = 7, TipoLimite = TipoLimite.Porcentaje, Valor =  6});

            #endregion
        }
    }
}
