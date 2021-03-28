using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    public struct Card
    {
    
        public Face Face { get; set; }
        public Suit Suit { get; set; }

        //Custom to string method for Card
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        //You can assign enums int values (default is index value)
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }
    public enum Face
    {
       Two,
       Three,
       Four,
       Five,
       Six,
       Seven,
       Eight,
       Nine,
       Ten,
       Jack,
       Queen,
       King,
       Ace

    }
}
