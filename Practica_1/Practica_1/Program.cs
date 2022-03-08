using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,,] triple = new double[2, 2, 3] {   /*fila 0*/{ /*col 0*/{ 1.0, 1.1, 1.2 }, /*col 1*/{ 2.0, 2.1, 2.2 }}, 
            //                                            /*fila 1*/{ /*col 0*/{ 3.0, 3.1, 3.2 }, /*col 1*/{ 4.0, 4.1, 4.2 }} };

            ////Console.WriteLine("Dato: {0}", triple[0,1,2]);
            ////Console.ReadKey();

            //int[,,] triple2 = new int[2, 2, 3];
            //triple2[0, 0, 0] = 0;
            //triple2[0, 0, 1] = 1;
            //triple2[0, 0, 2] = 2;
            //triple2[0, 1, 0] = 3;
            //triple2[0, 1, 1] = 4;
            //triple2[0, 1, 2] = 5;

            //Console.WriteLine("Dato: {0}", triple2[0, 0, 2]);
            //Console.ReadKey();
            var aux = new Ejemplo("", 2);
        }

        public class Ejemplo 
        {
            readonly public int numero;
            const string nombre = "A";

            public Ejemplo()
            {
                numero = 1;
            }
            public Ejemplo(string a, int x)
            {

            }
        }
    }

}
