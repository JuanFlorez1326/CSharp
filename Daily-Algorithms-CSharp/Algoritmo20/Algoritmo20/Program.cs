using System;

namespace Algoritmo20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que pida el peso, la estatura y muestre el índice de la masa corporal.");
            Console.WriteLine("Fórmula: Peso / Estatura ^ 2");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.Write("Ingrese su peso: ");
            double peso = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su estatura: ");
            double estatura = double.Parse(Console.ReadLine());

            double indice = peso / (estatura * estatura);

            Console.WriteLine("Su indice de masa corporal es: " + indice);
            Console.ReadLine();
        }
    }
}
