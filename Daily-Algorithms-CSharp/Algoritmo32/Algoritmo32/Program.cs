using System;

namespace Algoritmo32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generar e imprimir la serie y la suma los primero N números múltiplos de M.");

            Console.WriteLine("Digite el Multiplo: ");
            int multiplo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Primeros multiplos: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------");

            int suma = 0;
            int contador = 1;

            while (contador <= numero)
            {
                int mul = multiplo * contador;
                contador++;
                Console.WriteLine(mul);
                suma = suma + mul;
            }
            Console.WriteLine("La suma es: " + Convert.ToString(suma));
            Console.ReadLine();
        }
    }
}
