using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    public abstract class Game
    {
        //Game properties

        //Instantiate empty list and dictionary so program doesn't throw errors
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        //Method must be implemented in inheirited classes
        public abstract void Play();

        //Method must be implemented in inherited classes, but can be overwritten
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
