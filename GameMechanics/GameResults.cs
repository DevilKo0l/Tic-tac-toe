using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameMechanics
{
    public class GameResults
    {
        public static bool CheckWin(string[,] board, string marker)

        {
            return (board[0, 0] == marker && board[0, 1] == marker && board[0, 2] == marker ||
                   board[1, 0] == marker && board[1, 1] == marker && board[1, 2] == marker ||
                   board[2, 0] == marker && board[2, 1] == marker && board[2, 2] == marker ||
                   board[0, 0] == marker && board[1, 0] == marker && board[2, 0] == marker ||
                   board[0, 1] == marker && board[1, 1] == marker && board[2, 1] == marker ||
                   board[0, 2] == marker && board[1, 2] == marker && board[2, 2] == marker ||
                   board[0, 0] == marker && board[1, 1] == marker && board[2, 2] == marker ||
                   board[0, 2] == marker && board[1, 1] == marker && board[2, 0] == marker);
        }

        public static bool CheckTie(string[,] board)
        {
            bool checkDraw = true;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == " ")
                    {
                        return false;
                    }
                    break;

                }
            }
            return checkDraw;
        }
        public static void ReadStats()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Stats.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }



    }
}
