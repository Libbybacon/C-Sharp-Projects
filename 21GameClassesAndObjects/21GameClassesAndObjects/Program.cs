using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Deck
            Deck deck = new Deck();
            deck.Shuffle();

            //Print deck to Console
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

           Console.WriteLine(deck.Cards.Count);
           Console.ReadLine();

           
        }
    }
}
