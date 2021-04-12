using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //public Card()                      //constructor method() is always name of the class
        //{                                  //represents default values
        //    Suit = "Spades";                
        //    Face = "Two";

        //}
        public Suit Suit { get; set; }      //only two things you can do with an object property (get and set)
        public Face Face { get; set; }      //the card class has a property of data type string called Suit, and Face, later changed to Suit and Face since data types are now enums
                                            //and you can get this property or set this property. By making it public, it is available
                                            //to other parts of the program
        public override string ToString()   //every class has a built in method with a tostring (we will customize below)
        {
            return string.Format("{0} of {1}", Face, Suit); //when card.tostring will print out card 
        }
    }
    public enum Suit                        //use of enum, don't have to put "" around set of named values
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
