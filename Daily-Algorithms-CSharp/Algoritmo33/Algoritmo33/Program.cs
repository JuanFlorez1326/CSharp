using System;

namespace Algoritmo33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14. Calcular e imprimir el valor de S definida por la siguiente serie.");
            Console.WriteLine("S = 1/1**2 + 1/3**2 + 1/5**2 + 1/7**2 + 1/N**2");

            Console.WriteLine("Valor de N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");

            int contador = 0;
            
            while (contador < n)
            {
                contador = contador + 1;
                int exponente = contador * 2;
                int numerador = 1 / exponente;

                if (contador % 2 == 1)
                {
                    Console.Write("1/" + Convert.ToString(contador) + "²" + " + ");
                }               
            }
            Console.ReadLine();
        }
    }
}
