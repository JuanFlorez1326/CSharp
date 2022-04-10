using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Algoritmo que solo nos permita ingresar S o N.");
            Console.WriteLine("==============================================");

            Console.Write("S/N: ");
            string opcion = Console.ReadLine();

            while (opcion == "n" || opcion == "N" || opcion == "S" || opcion == "s")
            {
                Console.Write("S/N: ");
                opcion = Console.ReadLine();
            }

            Console.WriteLine("Se termino el programa");
            Console.ReadLine();
        }
    }
}
