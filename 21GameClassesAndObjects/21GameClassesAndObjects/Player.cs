using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

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
