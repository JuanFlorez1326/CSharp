using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("Dado un número entre 1 y 7 escriba su correspondiente día de la semana ");
            Console.WriteLine("1:Lunes - 2:Martes - 3:Miercoles - 4:Jueves - 5:Viernes - 6:Sabado - 7:Domingo");
            Console.WriteLine("================================================================================");

            Console.Write("Numero de dia que desea conocer: ");
            int dia = int.Parse(Console.ReadLine());

            while ( dia <= 0 || dia >=8)
            {
                Console.Write("Numero de dia que desea conocer: ");
                dia = int.Parse(Console.ReadLine());
            }

            if (dia == 1)
            {
                Console.WriteLine("El dia de numero " + dia + " es Lunes");

            }else if (dia == 2)
            {
                Console.WriteLine("El dia de numero " + dia + " es Martes");

            }else if (dia == 3)
            {
                Console.WriteLine("El dia de numero " + dia + " es Miercoles");

            }else if (dia == 4)
            {
                Console.WriteLine("El dia de numero " + dia + " es Jueves");

            }else if (dia == 5)
            {
                Console.WriteLine("El dia de numero " + dia + " es Viernes");

            }else if (dia == 6)
            {
                Console.WriteLine("El dia de numero " + dia + " es Sabado");

            }else if (dia == 7)
            {
                Console.WriteLine("El dia de numero " + dia + " es Domingo");
            }
            Console.ReadLine();
        }
    }
}
