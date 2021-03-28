using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    public class Player
    {
        //Player constructor
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }


        //Properties of Player
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        //Bet method, returns bool
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //Overload + operator to make it easy to add a player to a game
        public static Game operator+ (Game game, Player player)
        {
            //Takes game, adds player to it, returns game (with updated player list)
            game.Players.Add(player);
            return game;
        }
        //Overload - operator to make it easy to remove a player from a game
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
