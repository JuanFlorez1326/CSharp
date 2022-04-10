using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir un numero por teclado, que nos diga si es posivivo o negativo");
            Console.WriteLine("========================================================================");

            Console.Write("Ingrese el numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El numero es Positivo");

            }else if (numero < 0)
            {
                Console.WriteLine("El numero es Negativo");
            }
            else
            {
                Console.WriteLine("El numero es Neutro");
            }
            Console.ReadLine();
        }
    }
}
