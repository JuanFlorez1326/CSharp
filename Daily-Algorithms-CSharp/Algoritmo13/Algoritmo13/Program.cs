using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir y contar los multiplos de 3 " +
            "desde la unidad hasta el numero introducido por teclado");
            Console.WriteLine("======================================" +
            "========================================================");

            Console.Write("Digite un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int multiplo = 3;
            int contador = 0;

            while(contador < numero)
            {
                contador++;
                if(contador % multiplo == 0)
                {
                    Console.WriteLine(contador);
                }
            }
            Console.ReadLine();
        }
    }
}
