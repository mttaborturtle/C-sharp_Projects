using System;
using System.Collections.Generic;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "MtTaborTurtle Hotel and Casino";
            

            //Main method that starts the game
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money are you willing to gamble today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                var player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\mttab\Logs\namelog.txt", true))
                {
                    file.WriteLine(player.Id + " : " + player.Name + " : " + DateTime.Now);
                }
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
