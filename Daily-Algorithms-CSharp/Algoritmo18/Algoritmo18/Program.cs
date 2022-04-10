using System;

namespace Algoritmo18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrar los números de 1 hasta el número ingresado por teclado.");
            Console.WriteLine("---------------------------------------------------------------");

            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= numero)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
