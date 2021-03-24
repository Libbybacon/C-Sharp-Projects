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
            Deck deck = new Deck();
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
                Console.ReadLine();
            }

           Console.WriteLine(deck.Cards.Count);
           Console.ReadLine();

           
        }
    }
}
