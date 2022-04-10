using System;

namespace Algoritmo30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Juan Pablo Patiño Florez / Algoritmo Examen.
            Console.WriteLine("================================================================================================");
            Console.WriteLine("Realizar un algoritmo que permita recibir N numeros en una lista y ordenarla en forma asendente.");
            Console.WriteLine("================================================================================================");
            Console.WriteLine("");

            //Tamaño de la lista.
            Console.Write("Numeros que desea ingresar: ");
            int n = int.Parse(Console.ReadLine());

            //Lista
            Console.WriteLine("");
            int[] numeros = new int[n];

            //Agregando valores a la lista
            for (int i = 0; i < n; i++)
            {
                Console.Write("Numero {0} : ", i);
                numeros[i] = int.Parse(Console.ReadLine());
                
            }

            //Ordenando numeros de forma ascendente.
            int var = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int orden = 0; orden < numeros.Length; orden++)
                {
                    if (numeros[i] < numeros[orden])
                    {
                        var = numeros[i];
                        numeros[i] = numeros[orden];
                        numeros[orden] = var;
                    }
                }
            }

            //Imprimiendo la lista ordenada.
            Console.WriteLine("");
            Console.WriteLine("================================================================================================");
            Console.Write("Lista ordenada: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("({0}) ", numeros[i]);
            }
            Console.ReadLine();
        }
    }
}
