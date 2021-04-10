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
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21?", playerName); //{0} = string formatting / variable placeholder in some curly braces (will be players name)
            string answer = Console.ReadLine().ToLower(); //checking answer w/ tolower() method (will check for all with uppercase letters as well)
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                player player = new player(playerName, bank); //create new player object if they want to play, initialize player with name and bank
                game game = new TwentyOneGame(); //polymorphism: twentyonegame is also game, exposes overloaded operators
                game += player; //adding player to the game (overloaded operator)
                player.isActivelyPlaying = true; //property of player, set to true for while loop (when player is actively playing, play the game)
                while (player.isActivelyPlaying && player.Balance >0) //as long as both conditions are met...
                {
                    game.Play(); //will play one hand and continue to loop through as long as above conditions are met 
                }
                game -= player; //is player exists while loop, subtract from game (overloaded operator)
                Console.WriteLine("Thank you for playing");  //after game is over
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now"); //don't need else statement, this is if player didn't answer yes to playing game
            Console.Read();
        }
    }
}
