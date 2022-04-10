using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular la factorial de un número que se pida por teclado.");
            Console.WriteLine("-----------------------------------------------------------");

            Console.Write("Ingrse el numero del factorial a conocer: ");
            int numero = int.Parse(Console.ReadLine());
            int factorial = 1;

            while (numero != 0)
            {
                factorial *= numero;
                numero -= 1;
            }
            Console.WriteLine("El factorial es: " + factorial);
            Console.ReadLine();
        }
    }
}
