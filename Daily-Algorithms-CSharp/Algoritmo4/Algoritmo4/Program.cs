using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que imprima los numeros del 100 al 0 de forma descendente.");
            Console.WriteLine("---------------------------------------------------------");

            int numero = 0;
            int contador = 101;

            while (contador > numero)
            {
                contador--;
                Console.WriteLine(contador);
            }
            Console.ReadLine();
        }
    }
}
