using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class game                    //by adding abtract, you locked your code down and can no longer can instantiate it
    {                                             //inheritance
        public List<string> Players { get; set; } //type in prop tab tab
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();              //methods can only exist inside of an abstract class and contains NO implementation, any class inheriting this class must implement this method
        public virtual void ListPlayers()         //virtual keyword inside of an abstract class means that this method gets inherited by an inheriting class but has ability to override it
        {
            foreach (string player in Players) //looping through players property
            {
                Console.WriteLine(player);
            }
        }
    }
}
