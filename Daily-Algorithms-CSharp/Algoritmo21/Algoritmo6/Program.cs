using System;

namespace Algoritmo21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizar un programa que pida tres notas de un alumno, calcule el promedio e imprima lo siguiente:");
            Console.WriteLine("Si el promedio es > 10 mostrar 'Aprobado'.");
            Console.WriteLine("Si el promedio es > 7 y <= 9 mostrar 'Desaprobado'.");
            Console.WriteLine("Si el promedio es < 6 mostrar 'Reprobado'.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            Console.Write("Ingrese la nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 3: ");
            int nota3 = int.Parse(Console.ReadLine());

            float promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Su promedio es: " + promedio);
            
            if(promedio >= 10)
            {
                Console.WriteLine("Usted aprobo");
            }
            else if(promedio >= 7 && promedio <= 9)
            {
                Console.WriteLine("Ustes desaprobo");
            }else
            {
                Console.WriteLine("Usted reprobo");
            }

            Console.ReadLine();
        }
    }
}
