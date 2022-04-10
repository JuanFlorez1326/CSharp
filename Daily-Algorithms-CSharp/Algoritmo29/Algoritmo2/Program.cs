using System;
using System.Collections.Generic;

namespace Algoritmo29
{
    class Program
    {
        static void Main(string[] args)
        {
            //S = 4 + 8 - 12 + 15 + 18 - 21 + 23 + 25 + 27 - 28 + 29 + 30.
            Console.WriteLine("Imprimir la siguiete Serie: S = 4 + 8 - 12 + 15 + 18 - 21 + 23... 30");

            string n = "";
            for (int i = 4; i <= 12; i += 4)
            {
                n = n + i + " + ";
            }

            for (int i = 15; i<=21;i +=3)
            {
                n = n + i + " + ";
            }

            for (int i = 23; i <= 27; i += 2)
            {
                n = n + i + " + ";
            }

            for (int i = 28; i <= 30; i += 1)
            {
                n = n + i + " + ";
            }
            Console.WriteLine("S = " + n);

            Console.ReadLine();
        }
    }
}
