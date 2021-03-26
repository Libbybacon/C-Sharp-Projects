using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    class Dealer
    {
        //Dealer properties
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //Method to deal cards
        //Takes in List of cards called Hand
        public void Deal(List<Card> Hand)
        {
            //Take first card from Deck and add to Hand
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            //Remove dealt card from deck
            Deck.Cards.RemoveAt(0);    
        }
    }
}
