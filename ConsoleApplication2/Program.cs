using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMode;
using GameDisplay;
using System.IO;
using GameMechanics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool quit = true;
            while (quit)
            {
                MainMenu.gameMenu();
                int chooseNum;
                do
                {
                    Console.Write("Your selection: ");
                    

                } while (!int.TryParse(Console.ReadLine(),out chooseNum));              
                
                switch (chooseNum)
                {
                    case 1:
                        TwoPlayer.TwoPlayerGamePlay();
                        break;
                    case 2:
                        Console.WriteLine();
                        GameResults.ReadStats();
                        Console.WriteLine();
                        break;
                    case 3:
                        quit = false;
                        break;

                    default:
                        break;
                }
            }
        }

       
    }
}
