using System;

namespace Algoritmo27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo que imprima y ordene los numeros en forma de escalones");

            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            //Repetir lineas desde 1 hasta numero ingresado.
            for (int i = 1; i <= numero; i++)
            {
                //
                for (int j = 1; j <= i; j++)
                {
                    //Imprimir numeros en escalera.
                    Console.Write(j + " ");
                }
                //Salto de linea.
                Console.Write("\n");
            }
        }
    }
}
