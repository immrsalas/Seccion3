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
            //Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00   

            Console.WriteLine("Precio por el servicio de estacionamiento");

            Console.WriteLine("- - - - - - - - - -");

            Console.WriteLine("¿Cuanto tiempo permaneció dentro del establecimiento? (Minutos)");

            int tiempoMinutos = int.Parse(Console.ReadLine());
            
            if (tiempoMinutos > 0 && tiempoMinutos <= 60) { Console.WriteLine("Total a pagar: $5.00"); }

            else if (tiempoMinutos >= 61 && tiempoMinutos <=120) { Console.WriteLine("Total a pagar: $15.00"); }
         
            else if (tiempoMinutos > 120) { Console.WriteLine("Total a pagar: $40.00"); }

            else { Console.WriteLine("Ingresa minutos validos"); }


            Console.ReadKey();
        }
 

    }
}       