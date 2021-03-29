using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a constant for casino name
            const string casinoName = "Grand Hotel and Ca$ino";
        
            Console.WriteLine("Welcome to the {0}.  Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}.  Would you like to join a game of 21 right now? ", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //use Player constructor to create new player
                Player player = new Player(playerName, bank);
                //Assign player guid Id
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Libby\Documents\21Log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                //Create new game (using polymorphism
                Game game = new TwentyOneGame();
                //Add player to game
                game += player;
                player.isActivelyPlaying = true;

                //Check if player wants to play and has enough money
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                //remove player from game
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.Read();
        }
    }
}

