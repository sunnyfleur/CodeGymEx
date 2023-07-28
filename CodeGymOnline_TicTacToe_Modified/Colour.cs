using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_TicTacToe_Modified
{
    internal class Colour
    {
        private const ConsoleColor X_COLOUR = ConsoleColor.Red;
        private const ConsoleColor O_COLOUR = ConsoleColor.DarkGreen;
        private const ConsoleColor BOARD_COLOR= ConsoleColor.DarkGray;

        public static void ColourBoard(string board)
        {
            if (board.Contains("|"))
            {
                Console.ForegroundColor = BOARD_COLOR;
                Console.Write(board);
            }
            else if (board.Contains("-"))
            {
                Console.ForegroundColor = BOARD_COLOR;
                Console.WriteLine(board);
            }
        }
        public static void ColourSign(char sign)
        {
            if (sign == 'X')
            {
                Console.ForegroundColor = X_COLOUR;
                Console.Write(sign);
            }
            else if (sign == 'O')
            {
                Console.ForegroundColor = O_COLOUR;
                Console.Write(sign);
            }
            else
            {
                Console.ResetColor();
                Console.Write(sign);
            }
        }
    }
}
