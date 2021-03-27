using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    public struct Card
    {
        //Card constructor:
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        public Face Face { get; set; }
        public Suit Suit { get; set; }
    }
    public enum Suit
    {
        //You can assign enums int values (default is index value)
        Clubs,
        Spade,
        Diamond,
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
