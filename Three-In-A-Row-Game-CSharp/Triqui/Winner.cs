using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triqui
{
    class Winner
    {
        public static string PlayerWinner(string[] array)
        {
            string playerWinner = "";

            if (array[0] == "X" && array[1] == "X" && array[2] == "X") {playerWinner = "X";}

            else if (array[0] == "O" && array[1] == "O" && array[2] == "O") { playerWinner = "O"; }

            else if (array[3] == "X" && array[4] == "X" && array[5] == "X") { playerWinner = "X"; }

            else if (array[3] == "O" && array[4] == "O" && array[5] == "O") { playerWinner = "O"; }

            else if (array[6] == "X" && array[7] == "X" && array[8] == "X") { playerWinner = "X"; }

            else if (array[6] == "O" && array[7] == "O" && array[8] == "O") { playerWinner = "O"; }

            else if (array[0] == "X" && array[3] == "X" && array[6] == "X") { playerWinner = "X"; }

            else if (array[0] == "O" && array[3] == "O" && array[6] == "O") { playerWinner = "O"; }

            else if (array[1] == "X" && array[4] == "X" && array[7] == "X") { playerWinner = "X"; }

            else if (array[1] == "O" && array[4] == "O" && array[7] == "O") { playerWinner = "O"; }

            else if (array[2] == "X" && array[5] == "X" && array[8] == "X") { playerWinner = "X"; }

            else if (array[2] == "O" && array[5] == "O" && array[8] == "O") { playerWinner = "O"; }

            else if (array[0] == "X" && array[4] == "X" && array[8] == "X") { playerWinner = "X"; }

            else if (array[0] == "O" && array[4] == "O" && array[8] == "O") { playerWinner = "O"; }

            else if (array[2] == "X" && array[4] == "X" && array[6] == "X") { playerWinner = "X"; }

            else if (array[2] == "O" && array[4] == "O" && array[6] == "O") { playerWinner = "O"; }

            return playerWinner;
        }
    }
}
