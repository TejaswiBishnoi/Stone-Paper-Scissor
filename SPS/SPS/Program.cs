using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Engine;

namespace SPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stone, Paper and Scissor V0.1 alpha\n" + "-----------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------\n" + "This game is written in C# by Koala");
            Console.WriteLine("-----------------------------------------------------\n" + "-----------------------------------------------------");
            Console.WriteLine("This is an open source fun project under development\nFuture versions will be in WPF GUI");

            Console.WriteLine("-----------------------------------------------------\n" + "-----------------------------------------------------");
            GameEngine NewGame = new GameEngine();
            Console.WriteLine("-----------------------------------------------------\n" + "-----------------------------------------------------");

            Console.WriteLine("\nYou have 3 options to choose from:- \n1. Stone \n2. Paper \n3. Scissor" + "\nPress the number key written in front of the option to choose.");
            Console.WriteLine("\nPress P to pause \nPress R to resume \nPress H for help.");
            Console.WriteLine("\n\nHi Player, press any button when ready.....");
            NewGame.Start();
            Console.ReadKey();
        }
    }
}
