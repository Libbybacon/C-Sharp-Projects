using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //Log each card dealt to text file 21Log.txt and time it was dealt
            using (StreamWriter file = new StreamWriter(@"C:\Users\Libby\Documents\21Log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
                //Remove dealt card from deck
                Deck.Cards.RemoveAt(0);    
        }
    }
}
