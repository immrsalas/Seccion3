using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Security.Permissions;

namespace Seccion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.

            Console.WriteLine("Programa para saber si un numero es par o impar");

            Console.Write("Ingresa un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) { Console.WriteLine("Tu numero {0} es par", numero); }

            else { Console.WriteLine("Tu numero {0} es impar", numero); }
           
            Console.ReadKey();
        }
 

    }
}       