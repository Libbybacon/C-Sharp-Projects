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
            //Using over-ridden operators to add/remove player
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Phoeny";
            //game += player;
            //game -= player;

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            ////Cast enum to int to see what it's int value is
            //int underlyingValue = (int)(Suit.Clubs);
            //Console.WriteLine(underlyingValue);

            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;



            //Instantiate Deck
            Deck deck = new Deck();
            ////lambda function to find how many aces are in deck
            //int count = deck.Cards.Count(x => x.Face ==Face.Ace);

            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            foreach (Card card in newList)
            {
                Console.WriteLine(card.Face);
            }
            


            ////Call shuffle method
            //deck.Shuffle(3);

            ////Print deck to Console
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
    }
}
