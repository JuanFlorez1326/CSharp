using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que imprima y sume los primeros 100 numeros");
            Console.WriteLine("-------------------------------------------");

            int numero = 100;
            int contador = 0;
            int suma = 0;

            while (contador < numero)
            {
                contador++;
                suma += contador;
                Console.WriteLine(contador);
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("La suma de los numeros es: " + suma);
            Console.ReadLine();
        }
    }
}
