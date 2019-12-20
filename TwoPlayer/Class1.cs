using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDisplay;
using GameMechanics;

namespace TwoPlayer
{
    public class Class1
    {
        public void TwoPlayerGamePlay()
        {
            while (true)
            {

                var pickName = GameProcess.ChooseName();
                string player1_name = pickName.Item1;
                string player2_name = pickName.Item2;
                string turn = GameProcess.GoFirst();
                Tuple<string, string> pickMark;
                if (turn == "Player 1")
                {
                    Console.WriteLine("\n{0} goes first :D", player1_name);
                    pickMark = Board.ChooseMarker(player1_name);
                }
                else
                {
                    Console.WriteLine("\n{0} goes first :D", player2_name);
                    pickMark = Board.ChooseMarker(player2_name);
                }

                string player1_marker = pickMark.Item1;
                string player2_marker = pickMark.Item2;
                string[,] boardPos = Board.CreateBoard();
                bool gameStart = GameProcess.gameOn();
                while (gameStart)
                {
                    Board.DrawBoard(boardPos);
                    if (turn == "Player 1")
                    {
                        GameProcess.MakeMove(boardPos, player1_name, player1_marker);

                        if (GameResults.CheckWin(boardPos, player1_marker))
                        {
                            Console.WriteLine("Congratulation, {0} has won the game :>", player1_name);
                            Board.DrawBoard(boardPos);
                            break;
                        }
                        else if (GameResults.CheckTie(boardPos))
                        {
                            Console.WriteLine("This game is tie!!!");
                            Board.DrawBoard(boardPos);
                            break;
                        }

                        turn = "Player 2";

                    }
                    else
                    {
                        GameProcess.MakeMove(boardPos, player2_name, player2_marker);

                        if (GameResults.CheckWin(boardPos, player2_marker))
                        {
                            Console.WriteLine("Congratulation, {0} has won the game :>", player2_name);
                            Board.DrawBoard(boardPos);
                            break;
                        }
                        else if (GameResults.CheckTie(boardPos))
                        {
                            Console.WriteLine("This game is tie!!!!");
                            Board.DrawBoard(boardPos);
                            break;
                        }

                        turn = "Player 1";
                    }
                }
                Console.WriteLine("Do you want to start again(Y/N): ");
                string restart = Console.ReadLine();
                GameProcess.replay(restart);

            }
        }
    }
}
