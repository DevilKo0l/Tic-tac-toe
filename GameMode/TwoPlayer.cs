using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDisplay;
using GameMechanics;
using System.IO;

namespace GameMode
{
    public class TwoPlayer
    {

        struct PlayerScores
        {
            public string playerName { get; set; }
            public int numWin { get; set; }
            public int numGames { get; set; }
            public int numTie { get; set; }
            public PlayerScores(string pName, int nWin=0, int nGame=0, int nTie=0)
            {
                playerName = pName;
                numWin = nWin;
                numGames = nGame;
                numTie = nTie;
            }

            public void DisplayInfo()
            {
                Console.WriteLine(playerName);
                Console.WriteLine(numWin);
                Console.WriteLine(numGames);
                Console.WriteLine(numTie);

            }
        }
        public static void TwoPlayerGamePlay()
        {

            PlayerScores[] scoreArray = new PlayerScores[20];
            string[] playerArr = new string[20];
           

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
                    int i = 0;
                    Board.DrawBoard(boardPos);
                    if (turn == "Player 1")
                    {
                        GameProcess.MakeMove(boardPos, player1_name, player1_marker);
                        
                        if (GameResults.CheckWin(boardPos, player1_marker))
                        {
                            Console.WriteLine("Congratulation, {0} has won the game :>", player1_name);
                            Board.DrawBoard(boardPos);
                            if (!scoreArray.Any(x => x.playerName == player1_name))
                            {
                                playerArr[i] = player1_name;
                                scoreArray[i].playerName = player1_name;
                                scoreArray[i].numWin = 1;
                                scoreArray[i].numGames = 1;
                                i += 1;
                            }
                            else
                            {
                                var pIndex = Array.IndexOf(playerArr, player1_name);
                                scoreArray[pIndex].numWin += 1;
                                scoreArray[pIndex].numGames += 1;
                            }
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

                if (restart.ToUpper() == "Y")
                {
                    continue;
                }
                else

                {
                    break;
                }
                

            }

            
        }


        //private static void WriteStats(int[] winGames, List<string> playerList)
        //{
        //    using (StreamWriter writer = new StreamWriter(@"e:\playerlist.txt", true))
        //    {
        //        for (int i = 0; i < playerList.Count; i++)
        //        {
        //            writer.Write(playerList[i] + "      ");
        //        }

        //    }
        //    using (StreamWriter writer = new StreamWriter(@"e:\playerlist.txt", true))
        //    {
        //        for (int i = 0; i < winGames.Length; i++)
        //        {
        //            writer.Write(winGames[i] + "   ");
        //        }
        //    }
        //}
    }
}
