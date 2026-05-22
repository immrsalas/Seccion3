using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Permissions;

namespace Seccion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para realizar operaciones basicas

            Console.WriteLine("Programa para realizar operaciones basicas");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.Write("Elige una opcion: ");
            byte opcion = byte.Parse(Console.ReadLine());

            Console.Write("Ingresa el primer valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = 0;
            bool operacionExitosa = true;

            switch (opcion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;

                case 2:
                    resultado = valor1 - valor2;
                    break;

                case 3:
                    resultado = valor1 * valor2;
                    break;

                case 4:
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }

                    else { operacionExitosa = false; }
                    break;

                default:
                    operacionExitosa = false;
                    break;
            }

            if (operacionExitosa)
            {
                Console.Write("El resultado es: {0}", resultado);
            }

            
          
            Console.ReadKey();
        }
 

    }
}       