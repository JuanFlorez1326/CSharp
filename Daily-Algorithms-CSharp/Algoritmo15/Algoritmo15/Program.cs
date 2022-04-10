using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que permita leer 2 numeros distintos, determinar que valor es mayor y mostrarlo.");
            Console.WriteLine("================================================================================");

            Console.Write("Numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("El numero " + num1 + " es mayor que " + num2);
            }
            else
            {
                Console.WriteLine("El numero " + num2 + " es mayor que " + num1);
            }
            Console.ReadLine();
        }
    }
}
