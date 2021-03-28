using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _21GameClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Welcome to the Grand Hotel and Ca$ino.  Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}.  Would you like to join a game of 21 right now? ", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //use Player constructor to create new player
                Player player = new Player(playerName, bank);
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

