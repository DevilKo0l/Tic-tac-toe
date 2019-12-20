using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDisplay
{
    public class Board
    {
        public static void DrawBoard(string[,] board)
        {
            Console.WriteLine();
            Console.WriteLine(" {0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine();

        }
        public static Tuple<string, string> ChooseMarker(string player_name)
        {
            string marker;
            do
            {
                Console.Write("{0}, please choose your marker: ", player_name);
                marker = Console.ReadLine().ToUpper();
            } while (marker != "X" && marker != "O");

            if (marker == "X")
            {
                return Tuple.Create("X", "O");
            }
            else
            {
                return Tuple.Create("O", "X");
            }
        }
        public static string[,] CreateBoard()
        {
            string[,] b = new string[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    b[row, col] = " ";
                }
            }
            return b;
        }
    }
}
