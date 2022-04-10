using System;

namespace Algoritmo31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular e imprimir la suma de S definida por la siguiente serie");
            Console.WriteLine("S = 1 – 2 + 3 – 4 + 5 – 6 … + n");

            Console.WriteLine("Valor de N:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------");

            int contador = 1;
            string textoSuma = "S = ";
            int esPositivo = 1;
            int suma = 1;

            while (contador <= n)
            {
                Console.WriteLine(contador);
                
                if (esPositivo == 1)
                {
                    textoSuma = textoSuma + " + " + Convert.ToString(contador);
                    suma = suma + contador;
                    esPositivo = 0;
                }
                else
                {
                    textoSuma = textoSuma + " - " + Convert.ToString(contador);
                    suma = suma - contador;
                    esPositivo = 1;
                }
                contador = contador + 1;    
            }
            Console.WriteLine("----------");
            Console.WriteLine(textoSuma);
            Console.WriteLine("----------");
            Console.WriteLine("Result Serie: " + Convert.ToString(suma));
            Console.ReadLine();

        }
    }
}
