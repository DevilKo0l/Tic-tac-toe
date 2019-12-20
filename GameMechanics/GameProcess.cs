using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMechanics
{
    public class GameProcess
    {
        public static void MakeMove(string[,] board, string currentPlayer, string currentMarker)
        {
            Console.WriteLine(currentPlayer + "'s Move: ");
            int row;
            int col;
            do
            {
                Console.Write("Enter a row:");
            } while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row > 2);
            do
            {
                Console.Write("Enter a column: ");
            } while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col > 2);


            board[row, col] = currentMarker;
        }
        public static bool gameOn()
        {
            string input;
            do
            {
                Console.Write("\nAre you ready to play(Y/N): ");
                input = Console.ReadLine().ToUpper();

            } while (input != "Y" && input != "N");

            if (input == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static Tuple<string, string> ChooseName()
        {
            Console.Write("Player 1, Enter your name: ");
            string p1 = Console.ReadLine().ToUpper();
            Console.Write("Player 2, Enter your name: ");
            string p2 = Console.ReadLine().ToUpper();
            return Tuple.Create(p1, p2);
        }
        public static string GoFirst()
        {
            int n;
            Random rnd = new Random();
            n = rnd.Next(0, 6);
            if (n % 2 != 0)
            {
                return "Player 1";
            }
            else
            {
                return "Player 2";
            }

        }
        public static bool replay(string again)
        {
            again = Console.ReadLine();
            if (again.ToUpper() == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        public static int ReadInt()
        {
            int userInput;
            bool successfulConversion;
            do
            {
                successfulConversion = int.TryParse(Console.ReadLine(), out userInput) && userInput < 3 && userInput > 0;
                Console.WriteLine("Wrong");

            } while (!successfulConversion);

            return userInput;
        }
        
    }
}
