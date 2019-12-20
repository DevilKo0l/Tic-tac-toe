using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDisplay
{
    public class MainMenu
    {
        public static void gameMenu()
        {
            var builder = new StringBuilder();
            builder.Append('=', 48);
            builder.AppendLine();
            builder.Append('*', 1);
            builder.Append(' ', 4);
            builder.Append("Welcome to tic - tac - toe game ^ __ ^");
            builder.AppendLine();
            builder.Append('=', 48);
            builder.AppendLine();
            builder.Append('*', 1);
            builder.Append(' ', 15);            
            builder.Append("[1] New Game");
            builder.Append(' ', 15);
            builder.Append('*', 1);
            builder.AppendLine();
            builder.Append('*', 1);
            builder.Append(' ', 15);
            builder.Append("[2] Stats");
            builder.AppendLine();
            builder.Append('*', 1);
            builder.Append(' ', 15);
            builder.Append("[3] Quit");
            builder.AppendLine();
            builder.Append('=', 48);
            Console.WriteLine(builder);

        }
       
    }
}
