using System;

namespace Algoritmo26
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Algoritmo que determine si un numero es perfecto.");
            Console.WriteLine("=================================================");

            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if(numero % i == 0)
                {
                    Console.WriteLine("El " + i + " es multiplo de " + numero);
                    suma += i;
                }
            }

            if (suma == numero)
            {
                Console.WriteLine("=================================================");
                Console.WriteLine("El numero " + numero + " es perfecto.");
            }

            else
            {
                Console.WriteLine("=================================================");
                Console.WriteLine("El numero " + numero + " no es perfecto.");
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("La suma de los numeros multiplos de " + numero + " es: " + suma);
            Console.WriteLine("-------------------------------------------------");


            Console.ReadLine();
        }
    }
}
