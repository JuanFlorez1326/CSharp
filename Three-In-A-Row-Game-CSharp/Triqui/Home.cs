using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triqui
{
    class Home
    {
        public static void Values()
        {
            Players player1 = new Players();
            Players player2 = new Players();

            Console.Write("Nombre del Jugador 1: ");
            player1.Nombre = Console.ReadLine();

            Console.Write("Nombre del Jugador 2: ");
            player2.Nombre = Console.ReadLine();


            player1.Figura = "X";
            player2.Figura = "O";


            Console.WriteLine("-----------------------------------");
            Console.WriteLine(player1.Nombre + ": " + player1.Figura);
            Console.WriteLine(player2.Nombre + ": " + player2.Figura);

            Console.WriteLine("Preparando la Partida...");
            System.Threading.Thread.Sleep(2000);
            Game.GameCat(player1.Nombre, player1.Figura, player2.Nombre, player2.Figura);
        }
    }
}
