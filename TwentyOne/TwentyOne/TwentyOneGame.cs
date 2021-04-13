using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : game, IWalkAway //to inherit class, use ":", inheriting interface 
    {
        public TwentyOneDealer Dealer { get; set; } //twentyonegame has it's own dealer property
        public override void Play()  //use overide keyword to "satisfy contract to define this method() from abract class" //implement Play() method
        {
            Dealer = new TwentyOneDealer(); //instantiate that dealer object as a new TwentyOneDealer
            foreach (player player in Players) //Players is a property of the game class
            {
                player.Hand = new List<Card>(); //want hand to be blank for each player a the start of a game
                player.Stay = false; //set at false for new game
            }
            Dealer.Hand = new List<Card>(); // want hand to be blank for dealer at the start of game
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); //refresh deck every single round
            Dealer.Deck.Shuffle();
            foreach (player player in Players) //loop through each player and have them place a bet
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!"); //next step in game
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, without decimals");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out."); //that way the user cant enter in a negative amount of money
                }
                bool successfullyBet = player.Bet(bet); //passes in user's bet into Bet() method and if they have enough it'll be true, if not false
                if (!successfullyBet) //if false
                {
                    return; //in void method, what return does is ends method
                }
                Bets[player] = bet; //if bet was successful, create a dictionary entry for player which will add player object with their bet amount to dictionary
            }
            for (int i = 0; i < 2; i++) //next step is to deal, will have cards face up for simplicity with for each loop 2x
            {
                Console.WriteLine("Dealing...");
                foreach (player player in Players) //loop through players, deal each player
                {
                    Console.Write("{0}: ", player.Name); //use of string shorthand to write players names so we know whos getting dealt. Writing something to console without pressing enter
                    Dealer.Deal(player.Hand); //passing in players hand and is given card and printed to console to see what you're given
                    if (i == 1)//check firsthand to see if you were dealt blackjack
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); //passing in players hand
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]); //blackjack! will return value of players bet 
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //player wins bet * 1.5 + original bet
                            return; //round is over 
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand); //dealer deals dealers hand
                if (1 == 1) //check for blackjack
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                        foreach (KeyValuePair<player, int> entry in Bets) //iterate through dictionary
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }
            foreach (player player in Players)
            {
                while (!player.Stay) //while player is not staying...
                {
                    Console.WriteLine("Your cards");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString()); //tostring method so we can show player their cards
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower(); //easy to compare users answer
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break; //end while loop, break, and check condition 
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand); //passing in hand and dealing player a card that will print to console
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); //did player go over 21, will return true or false
                    if (busted)
                    {
                        Dealer.Balance += Bets[player]; //if player busts, have to give dealer that money, access that through Bets table (dictionary)
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
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
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //dealer can wait to see if other players bust, highly unlikely but we will still put in the code for it
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks for sum between 16 and 22
            while (!Dealer.Stay && !Dealer.isBusted) //as long as dealer isn't busted and as long as dealer is staying...
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand); //deal dealer a card
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks again
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks again
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted"); //if dealer busted, give players their winnings
                foreach (KeyValuePair<player, int> entry in Bets) //loop through dictionary again
                {
                    Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value); //player won x amount, access values in keyvaluepair with entry.
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //use LAMBDA expression to get list of players where their name = name in the dictionary, giving them their money back + their winnings  
                    Dealer.Balance -= entry.Value;
                }
                return; //ends round
            }
            foreach (player player in Players) //if no one busts, next, you want to compare the dealers hand to the players hand, whoever has the closest to 21 wins. or if they tie they push
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //bool? can actually be set to null even though its a struct, useful when there are three options (dealer wins, player wins, they tie
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player]; //gets bet money back 
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2); //if player wins, they earn back their bets + their winnings 
                    Dealer.Balance -= Bets[player]; //subtract winnings from dealers balance
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
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

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(player player) //implementing interface 
        {
            throw new NotImplementedException();
        }
    }
}