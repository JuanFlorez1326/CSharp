using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que imprima los numeros impares hasta el 100 y que imprima cuantos impares hay.");
            Console.WriteLine("-------------------------------------------------------------------------------");

            int impares = 100;
            int contador = 0;
            int contadorImpar = 0;

            while (contador < impares)
            {
                contador++;

                if (contador % 2 == 1 )
                {
                    Console.WriteLine(contador);
                    contadorImpar += 1;
                }
            }
            Console.WriteLine("El total de los impares es: " + contadorImpar);

            Console.ReadLine();
        }
    }
}
