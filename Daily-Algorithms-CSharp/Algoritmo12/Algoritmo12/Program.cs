using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que nos diga si un numero introducido por teclado es par o impar");
            Console.WriteLine("========================================");

            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("El numero " + numero +" es par");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " es impar");
            }
            Console.ReadLine();
        }
    }
}
