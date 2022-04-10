using System;

namespace Clculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para Sumar");
            Console.WriteLine("Digite 2 para Restar");
            Console.WriteLine("Digite 3 para Multiplicar");
            Console.WriteLine("Digite 4 para Dividir");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Opcion: ");
            int opcion = int.Parse(Console.ReadLine());          
            Console.WriteLine("---------------------------");

            if (opcion == 1)
            {
                Console.WriteLine("Numero 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Numero2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int suma = num1 + num2;
                Console.WriteLine("La suma de los numeros da: " + suma);

            }

            if (opcion == 2)
            {
                Console.WriteLine("Numero 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Numero2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int resta = num1 - num2;
                Console.WriteLine("La resta de los numeros da: " + resta);

            }

            if (opcion == 3)
            {
                Console.WriteLine("Numero 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Numero2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int multiplicacion = num1 * num2;
                Console.WriteLine("La multiplicacion de los numeros da: " + multiplicacion);

            }

            if (opcion == 4)
            {
                Console.WriteLine("Numero 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Numero2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int division = num1 / num2;
                Console.WriteLine("La division de los numeros da: " + division);

            }
            Console.ReadLine();
        }
    }
}
