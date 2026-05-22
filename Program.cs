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
            // Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario.Agregar un case default.

            Console.WriteLine("Programa para saber el mes del año ingresando un numero del 1 al 12");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("Ingrese un numero del 1 al 12");
            byte numDelAño = byte.Parse(Console.ReadLine());

            switch (numDelAño)
            {
                case 1:
                    Console.Write("Enero");
                    break;
                case 2:
                    Console.Write("Febrero");
                    break;
                case 3:
                    Console.Write("Marzo");
                    break;
                case 4:
                    Console.Write("Abril");
                    break;
                case 5:
                    Console.Write("Mayo");
                    break;
                case 6:
                    Console.Write("Junio");
                    break;
                case 7:
                    Console.Write("Julio");
                    break;
                case 8:
                    Console.Write("Agosto");
                    break;
                case 9:
                    Console.Write("Septiembre");
                    break;
                case 10:
                    Console.Write("Octubre");
                    break;
                case 11:
                    Console.Write("Noviembre");
                    break;
                case 12:
                    Console.Write("Diciembre");
                    break;
                default:
                    Console.WriteLine("Solo puedes ingresar del 1 al 12");
                    break;
            }
            
            
            Console.ReadKey();
        }
 

    }
}       