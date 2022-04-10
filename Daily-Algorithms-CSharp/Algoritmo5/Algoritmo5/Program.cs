using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que imprima los numeros pares del 0 al 100.");
            Console.WriteLine("-------------------------------------------");

            int numero = 100;
            int contador = 0;

            while (contador < numero)
            {
                contador++;

                if(contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
            }
            Console.ReadLine();
        }
    }
}
