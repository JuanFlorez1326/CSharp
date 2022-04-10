using System;

namespace Algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pedir 2 números por teclado y sumarlos.");
            Console.WriteLine("---------------------------------------");

            Console.Write("Numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("La suma de los numeros da: " + suma);

            Console.ReadLine();
        }
    }
}
