using System;

namespace Algoritmo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrar los números impares entre el 0 y el 100");
            Console.WriteLine("------------------------------------------------");
            int numeros = 100;
            int contador = 0;

            while (contador < numeros)
            {
                contador++;

                if (contador % 2 == 1)
                {
                    Console.WriteLine(contador);
                }
            }
            Console.ReadLine();
        }
    }
}
