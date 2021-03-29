using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne

{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        //Implement Play() method (program won't run unless you do this b/c Play() is abstract method
        public override void Play()
        {
            //Reset values for each new game
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(3);
            

            // PLAYERS PLACE BETS //
            foreach (Player player in Players)
            {
                //Make sure user enters bet in correct format
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter valid digits only, no decimals");
                }

                if (bet < 0)
                {
                    throw new FraudException();
                }
                
                //Pass bet amount into Bet() method 
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    //end method
                    return;
                }
                //Add player's bet to Bets dictionary
                Bets[player] = bet;
            }

            

            // DEAL HANDS //
            for (int i = 0; i <2; i++)
            {
                Console.WriteLine("Dealing...");
                //In each loop, each person's Hand gets one Card, loop twice so each player ends up with two cards in his hand
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    //Call Deal(method) with payer hand as argument
                    Dealer.Deal(player.Hand);

                    //Check for blackjack
                    if (i == 1)//Just means second card has been dealt
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            //Player gets bet back and wins 1.5x his bet
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                //Dealer deals himself a hand
                Dealer.Deal(Dealer.Hand);
                if (i == 1)//second card is dealt
                {
                    //Check for blackjack
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        //Iterate through list of each player's bets
                        foreach (KeyValuePair<Player, int> entry in Bets) 
                        {
                            //Give dealer balance of every player
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }

            // SEE IF PLAYERS WANT TO 'HIT' OR 'STAY' //
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    //Show player's cards//
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }


                    //Ask to hit or stay
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    //If they stay, break while loop
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    //Otherwise deal a card
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }


                    // Check if hand is over 21 //
                    bool busted = TwentyOneRules.IsBusted(player.Hand);

                    //If player busts, add player's bet to dealer's balance
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lost your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        
                        //Ask if player wants to play again
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer =="yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            //This ends game bc in order for play() to run, isActivelyPlaying must equal true
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }


            // DEALER'S TURN //

            //Check if dealer busted
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            //Check if dealer should stay
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            //While dealer is not staying and has not busted: (if he busts or stays, it breaks the while loop)
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                //Dealer gets another card
                Dealer.Deal(Dealer.Hand);

                //Check if busted again
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                //Check if dealer stays
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            //If dealer busts...
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!!");
                //Each player wins the amount of his bet
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //Add each player's winnings to his balance (multiply by 2 bc bet has already been taken from his balance)
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);

                    //Remove amount of each player's bet from Dealer balance
                    Dealer.Balance -= entry.Value;                          
                }
                return;
            }

            // Compare players' hands to dealer's hand
            foreach (Player player in Players)
            {

                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);

                //If nobody wins give player his money back
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                         
                }

                //If player wins, add his earnings to his balance and remove that amount from dealer balance
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} wins {1}!", player.Name, Bets[player]);
                    player.Balance += Bets[player] * 2;
                    Dealer.Balance -= Bets[player]; 
                }

                //If dealer wins, add player's bet to dealer's balance
                else 
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                //See if player wants to play again
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }

            }

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
