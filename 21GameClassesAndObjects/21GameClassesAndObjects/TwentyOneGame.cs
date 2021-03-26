using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    public class TwentyOneGame : Game, IWalkAway
    {
        //Implement Play() method (program won't run unless you do this b/c Play() is abstract method
        public override void Play()
        {
            throw new NotImplementedException();
        }

        //Implement and add to ListPlayers() method
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }

        //Implement interface IWalkAway()
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
