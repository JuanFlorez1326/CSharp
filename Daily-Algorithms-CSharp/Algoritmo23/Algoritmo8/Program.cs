using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que muestre la tabla de multiplicar del número que se pida por teclado.");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.Write("Numero de la tabla de multiplicar que desea conocer: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;
            int numeros = 10;

            for (int i = 1; i <= numeros; i++)
            {
                
                Console.WriteLine(numero + " X " + contador +" = " + numero * contador);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
