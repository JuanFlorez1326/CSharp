using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triqui
{
    class Game
    {
        public static void GameCat(string n1, string f1, string n2, string f2)
        {
            Console.Clear();
            Players pr1 = new Players();
            Players pr2 = new Players();
            Board board = new Board();

            pr1.Nombre = n1;
            pr1.Figura = f1;
            pr2.Nombre = n2;
            pr2.Figura = f2;

            bool esnumero;
            string spotition;
            string var = "";
            int var2 = 0;
            int ipotition;
            int njugador = 1;
            bool ganador = true;


            while (ganador)
            {
                Console.Clear();
                Formatter.BoardFormatter(board.Positions);

                if (njugador == 1)
                {

                    Console.Write(pr1.Nombre + " Posición: ");
                    spotition = Console.ReadLine();
                    try
                    {
                        esnumero = Int32.TryParse(spotition, out ipotition);
                        ipotition = ipotition - 1;
                        if (esnumero && ipotition < 0 || ipotition > 8)
                        {
                            Console.WriteLine("La posicion no existe, perdiste el turno :(");
                            System.Threading.Thread.Sleep(1000);

                        }
                        else if (esnumero && String.IsNullOrEmpty(board.Positions[ipotition]))
                        {
                            board.Positions[ipotition] = pr1.Figura;
                            var2 = var2 + 1;
                        }
                        else if (esnumero == false)
                        {
                            Console.WriteLine("¡TURNO PERDIDO! No ingresaste una posicion :(");
                            System.Threading.Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("Posicion ocupada, perdiste el turno :(");
                            System.Threading.Thread.Sleep(1000);

                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Posicion invalidad, turno perdido :(");
                    }

                }


                if (njugador == 2)
                {

                    Console.Write(pr2.Nombre + " Posición: ");
                    spotition = Console.ReadLine();
                    try
                    {
                        esnumero = Int32.TryParse(spotition, out ipotition);
                        ipotition = ipotition - 1;
                        if (esnumero && ipotition < 0 || ipotition > 8)
                        {
                            Console.WriteLine("La posicion no existe, perdiste el turno :(");
                            System.Threading.Thread.Sleep(1000);

                        }
                        else if (esnumero && String.IsNullOrEmpty(board.Positions[ipotition]))
                        {
                            board.Positions[ipotition] = pr2.Figura;
                            var2 = var2 + 1;
                        }
                        else if (esnumero == false)
                        {
                            Console.WriteLine("¡TURNO PERDIDO! No ingresaste una posicion :(");
                            System.Threading.Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("Posicion ocupada, perdiste el turno :(");
                            System.Threading.Thread.Sleep(1000);

                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Posicion invalidad, turno perdido :(");
                    }

                }


                var = Winner.PlayerWinner(board.Positions);
                if (var == "X")
                {
                    if (pr1.Figura == "X")
                    {
                        Console.WriteLine("¡¡¡Felicidades " + pr1.Nombre + " Ganaste la partida!!!");
                        System.Threading.Thread.Sleep(6000);
                    }
                    else
                    {
                        Console.WriteLine("¡¡¡Felicidades " + pr2.Nombre + " Ganaste la partida!!!");
                        System.Threading.Thread.Sleep(6000);
                    }
                    ganador = false;
                }


                else if (var == "O")
                {
                    if (pr1.Figura == "O")
                    {
                        Console.WriteLine("¡¡¡Felicidades " + pr1.Nombre + " ganaste la partida!!!");
                        System.Threading.Thread.Sleep(6000);
                    }
                    else
                    {
                        Console.WriteLine("¡¡¡Felicidades " + pr2.Nombre + " ganaste la partida!!!");
                        System.Threading.Thread.Sleep(6000);
                    }
                    ganador = false;
                }

                if (var2 == 9)
                {
                    Console.WriteLine("-----Empate-----");
                    System.Threading.Thread.Sleep(6000);
                    ganador = false;
                }

                if (njugador == 1)
                {
                    njugador = 2;
                }
                else if (njugador == 2)
                {
                    njugador = 1;
                }
            }
        }
    }
}
