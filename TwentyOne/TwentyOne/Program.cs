using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame(); //inheriting from TwentyOneGame (won't run play until it is defined)
            game.Players = new List<player>()/* { "Breanna", "Stayce", "Brandon" };*/ //inherited properties from game class 
            game.ListPlayers(); //called superclass method() (when you're calling a method from a class you are inheriting from)
            game.Play(); //calling play method from twentyonegame class
            Console.ReadLine();

            player player = new player();
            player.Name = "Breanna";
            game += player; //same thing as writing game = game + player;
            game -+ player;
            
            /*Card card = new Card() { Face = "King", Suit = "Spades" }*/ //object initialization

            Deck deck = new Deck();
            deck.Shuffle();                                  //optional parameter, can change to deck=Shuffle(deck, 3); or any amount of times you want deck shuffled   

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
      
        //public static Deck Shuffle(Deck deck, int times) //method to shuffle deck x amount of times
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
