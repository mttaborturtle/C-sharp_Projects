using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text I want to write to a file....";
            //File.WriteAllText(@"C:\Users\mttab\Logs\log.txt", text);
            //string stuff = File.ReadAllText(@"C:\Users\mttab\Logs\log.txt");
            //Console.WriteLine(stuff);
            //string text2 = "This is some stuff to add!!";
            //File.AppendAllText(@"C:\Users\mttab\Logs\log.txt", text2);


            //Main method that starts the game
            Console.WriteLine("Welcome to the MtTabor Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money are you willing to gamble today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to go get a drink and come back when you are ready to play. Bye for now.");
            Console.ReadLine();
        }

        
    }
}
