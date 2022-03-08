using System;
using System.Globalization;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creo las variables
            int opcion = 0;

            //Pido la operacion a realizar
            Console.WriteLine("Bienvenido a la calculadora \r\nIngrese la opcion deseada: \r\n1-Sumar. \r\n2-Restar. \r\n3-Multiplicar. \r\n4-Dividir.");
            //Guardo los valores
            opcion = int.Parse(Console.ReadLine());

            //if (opcion > 4 || opcion < 1) mal
            //if(!(opcion > 4 || opcion < 1))//bien
            if (opcion < 5 && opcion > 0)//bien
            {
                switch (opcion)
                {
                    case 1://Suma
                        Suma();
                        break;
                    case 2://Resta
                        Resta();
                        break;
                    case 3://Multiplicacion
                        Multiplicacion();
                        break;
                    case 4://Division
                        Division();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ha ingreado un número no valido.");
            }
        }
       

        /// <summary>
        /// Pido el ingreso de dos numeros enteros y resto el valor del segundo al primero
        /// </summary>
        public static void Resta() 
        {
            //Declaro las variables
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            Console.Clear();
            Console.WriteLine("Ingrese el primer valor:");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ingrese el segundo valor:");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            resultado = num1 - num2;
            Console.WriteLine("Su resultado es: {0}", resultado);
        }

        /// <summary>
        /// Pido que ingrese dos numeros y divido el primero al valor del segundo
        /// </summary>
        public static void Division()
        {
            float num1 = 0;
            float num2 = 0;
            float resultado = 0;

            Console.Clear();
            Console.WriteLine("Ingrese un numero:");
            num1 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ingrese otro numero:");
            num2 = float.Parse(Console.ReadLine());
            Console.Clear();
            resultado = num1 / num2;

            Console.WriteLine("Su resultado es: {0}", resultado);
        }

        /// <summary>
        /// Pido que ingrese dos numeros y devuelvo la suma de ambos
        /// </summary>
        public static void Suma()
        {
            int num1 = 0;
            int num2 = 0;
            int resultado  = 0;
            Console.WriteLine("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ingrese otro numero:");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            resultado = num1 + num2;
            Console.WriteLine("Su resultado es: {0}", resultado);
        }

        /// <summary>
        /// Pido el ingreso de dos numeros y los multiplico
        /// </summary>
        public static void Multiplicacion()
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;
            Console.Clear();
            Console.WriteLine("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ingrese el segundo numero:");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            resultado = num1 * num2;
            Console.WriteLine("Su resultado es: {0}", resultado);
        }

     }
}
    

