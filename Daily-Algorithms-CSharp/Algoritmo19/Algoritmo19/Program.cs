using System;

namespace Algoritmo19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir 5 veces la palabra Algoritmo.");
            Console.WriteLine("---------------------------------------");

            int palabra = 5;
            int contador = 0;

            while (contador < palabra)
            {
                Console.WriteLine("Algoritmo");
                contador++;
            }
            Console.ReadLine();
        }
    }
}

