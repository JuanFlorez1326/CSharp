using System;

namespace Algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que permita calcular un promedio de 4 notas.");
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Nota 1: ");
            double nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            double nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            double nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota 4: ");
            double nota4 = int.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 +nota3 + nota4) / 4;
            Console.WriteLine("El promedio de las notas es: " + promedio);
            
            Console.ReadLine();
        }
    }
}
