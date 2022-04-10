using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que imprima los numeros del 0 hasta el numero ingresado por teclado.");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador < numero)
            {
                contador++;
                Console.WriteLine(contador);
            }

            Console.ReadLine();
        }
    }
}
