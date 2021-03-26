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
            //Object initialization
            //Card card = new Card() {Face = "King", Suit = "Clubs" };
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Libby", "Phoeny", "Granmary" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();
           // //Instantiate Deck
           // Deck deck = new Deck();
           // //Call shuffle method
           // deck.Shuffle(3);

           // //Print deck to Console
           // foreach (Card card in deck.Cards)
           // {
           //     Console.WriteLine(card.Face + " of " + card.Suit);
           // }
          
           //Console.WriteLine(deck.Cards.Count);
           //Console.ReadLine();
 
        }
    }
}
