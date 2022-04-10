using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triqui
{
    class Formatter
    {
        public static void BoardFormatter(string[] board)
        {
            var newBoard = new string[board.Length];
            board.CopyTo(newBoard, 0);
            for (int i = 0; i <= 8; i++)
            {
                if (newBoard[i] == null)
                {
                    int x = i + 1;
                    newBoard[i] = Convert.ToString(x);
                }
            }
            Console.WriteLine("\n     " + newBoard[0] + " | " + newBoard[1] + "  | " + newBoard[2]);
            Console.WriteLine("\n   ___  ___  ___");
            Console.WriteLine("\n     " + newBoard[3] + " | " + newBoard[4] + "  | " + newBoard[5]);
            Console.WriteLine("\n   ___  ___  ___");
            Console.WriteLine("\n     " + newBoard[6] + " | " + newBoard[7] + "  | " + newBoard[8]);

        }
    }
}
