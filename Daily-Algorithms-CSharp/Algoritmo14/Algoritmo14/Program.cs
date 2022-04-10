using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que imprima los numeros del 1 al 100, que calcule la suma de los numeros pares y por otreo lado la suma de los impares");
            Console.WriteLine("======================================================================================================================");

            int numero = 100;
            int sumaImpar = 0;
            int sumaPar = 0;
            int contador = 0;

            while(contador<numero)
            {
                contador++;
                Console.WriteLine(contador);

                if(contador % 2 == 0)
                {
                    sumaPar += contador;
                }
                if(contador % 2 == 1)
                {
                    sumaImpar += contador;
                }
            }


            Console.WriteLine("La suma de los impares es: " + sumaImpar);
            Console.WriteLine("La suma de los pares es: " + sumaPar);

            Console.ReadLine();
        }
    }
}
