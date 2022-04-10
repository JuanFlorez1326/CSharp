using System;

namespace Algoritmo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que nos imprima si un numero es positivo o negativo");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Ingrese un numero: ");
            int n = int.Parse(Console.ReadLine());

            if(n > 0)
            {
                Console.WriteLine("El numero " + n + " es positivo");
            }
            else if(n < 0) 
            {
                Console.WriteLine("El numero " + n + " es negativo");
            }
            else if (n == 0)
            {
                Console.WriteLine("El numero " + n + " es neutro");
            }

            Console.ReadLine();
        }
    }
}
