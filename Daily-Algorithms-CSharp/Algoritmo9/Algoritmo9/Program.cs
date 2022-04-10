using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("Introducir tantas frases como queramos y contarlas.");
            Console.WriteLine("===================================================");

            Console.WriteLine("Digite S para introducir una frase, o digite N para terminar el programa.");
            Console.WriteLine("----------");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine();
            int cantidad = 0;
            Console.WriteLine("----------");

            if (opcion == "N" || opcion == "n")
            {
                Console.WriteLine("Se termino el programa");
            }

            while (opcion == "S" || opcion == "s")
            {
                cantidad++;          
                Console.Write("Frase: ");
                string frase = Console.ReadLine();
                Console.Write("¿Desea introducir una frase nueva? S/N: ");
                opcion = Console.ReadLine();

                if(opcion == "N" || opcion == "n")
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("Se termino el programa");
                    Console.WriteLine("La cantidad de frases ingresadas es: " + cantidad);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
