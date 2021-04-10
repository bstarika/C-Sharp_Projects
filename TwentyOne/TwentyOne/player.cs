using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class player
    {
        public player(string name, int beginningBalance)               //contructor takes two parameters that will assign values 
        {
            Hand = new List<Card>();                                   //create empty list, have to initialize property before adding items to it
            Balance = beginningBalance;                                //constructor is taking two arguements and assigning them to properties in the class
            Name = name;
        }
        
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }                                 //Stay boolean property could be very specific to TwentyOneGame, could create another class called TwentyOnePlayer
        public bool Bet (int amount)
        {
            if (Balance - amount < 0 )                                 //defining bet() method in player class
            {
                Console.WriteLine("You do not have enough to place a bet that size");
                return false;
            }
            else
            {
                Balance -= amount;                                      //same thing as writing Balance = Balance - amount;
                return true;
            }
        }

        public static game operator+ (game game, player player)        //overload an operator
        {
            game.Players.Add(player);
            return game;
        }
        public static game operator -(game game, player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
