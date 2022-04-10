using System;

namespace Algoritmo28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S = 1/3 + 2/4 + 3/5... n/n");
            Console.WriteLine("==========================");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                int formula = i + 2;
                Console.Write(i + "/" + formula + " + ");
            }
            Console.ReadLine();
        }
    }
}
