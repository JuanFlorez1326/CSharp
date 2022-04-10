using System;

namespace Algoritmo22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El promedio de prácticas de un curso se calcula con base en cuatro notas " +
            "calificadas de las cuales se elimina la nota menor y se promedian las tres notas más altas.");

            Console.Write("Nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            int nota3 = int.Parse(Console.ReadLine());

            Console.Write("Nota 4: ");
            int nota4 = int.Parse(Console.ReadLine());

            if(nota1 < nota2 || nota1 < nota3 || nota1 < nota4)
            {
                int promedio = (nota2 + nota3 + nota4) / 3;
                Console.WriteLine("El promedio de las notas menos la Nota 1 es: " + promedio);

            }else if (nota2 < nota1 || nota2 < nota3 || nota2 < nota4)
            {
                int promedio = (nota1 + nota3 + nota4) / 3;
                Console.WriteLine("El promedio de las notas menos la Nota 2 es: " + promedio);

            }else if(nota3 < nota1 || nota3 < nota2 || nota3 < nota4)
            {
                int promedio = (nota1 + nota2 + nota4) / 3;
                Console.WriteLine("El promedio de las notas menos la Nota 3 es: " + promedio);

            }else if (nota4 < nota3 || nota4 < nota2 || nota4 < nota1)
            {
                int promedio = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine("El promedio de las notas menos la Nota 4 es: " + promedio);

            }
            Console.ReadLine();           
        }
    }
}
