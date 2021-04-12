using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()                                                                                  //constructors always go at top of class before properties
        {
            Cards = new List<Card>();                                                                  //Cards is referring to property of class, Deck
            for (int i = 0; i < 13; i++)                                                               //for loop
            {
                for (int j = 0; j < 4; j++)                                                            //another for loop that will run 52 times total(13*4)
                {
                    Card card = new Card();                                                            //assigns card a face and suit
                    card.Face = (Face)i;                                                               //casting
                    card.Suit = (Suit)j;                                                               //casting
                    Cards.Add(card);
                }
            }




            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };    //first create list that contains suits                              
            //List<string> Faces = new List<string>()
            //{
            //      "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",                          //create second list with faces
            //      "Nine", "Ten", "Jack", "Queen", "King", "Ace"  
            //};

            //foreach (string face in Faces)                                                          //create nested loop to filter through 52 cards
            //{
            //      foreach (string suit in Suits)
            //      {
            //          Card card = new Card();                                                       //create new card
            //          card.Suit = suit;
            //          card.Face = face;
            //          Cards.Add(card);
            //      }
            //}

        }
        public List<Card> Cards { get; set; }                                                         //property

        public void Shuffle(int times = 1)                                                            //Deck is type of data returning, Shuffle is name of function, takes parameter of type Deck
        {                                                                                             //to create an optional paramter, add a default value (int times = 1)
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();                                               //temporary list to store shuffled items 
                Random random = new Random();

                while (Cards.Count > 0)                                                               //while loop to shuffle deck
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

        }
    }
}

