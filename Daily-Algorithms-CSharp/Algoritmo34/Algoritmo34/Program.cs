using System;

namespace Algoritmo34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular e imprimir la serie y el valor de S definida por:");
            Console.WriteLine("S = 1 + 2 – 3 + 4 + 5 – 6 + 7 + 8 – 9 + … + N");

            Console.WriteLine("Valor de N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");

            string texto = "S =";
            int contador = 1;
            int contapositivo = 0;

            while (contador <= n)
            {             
                if (contapositivo < 2)
                {
                    texto = texto + " + " + Convert.ToString(contador);
                    contapositivo++;
                }
                else
                {
                    texto = texto + " - " + Convert.ToString(contador);
                    contapositivo = 0;
                }
                contador++;
            }
            Console.WriteLine(texto);
            Console.ReadLine();
        }
    }
}
