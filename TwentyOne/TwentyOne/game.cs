using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class game                    //by adding abtract, you locked your code down and can no longer can instantiate it
    {                                             //inheritance
        public List<player> Players { get; set; } //type in prop tab tab
        public string Name { get; set; }
        public Dictionary<player, int> Bets { get; set; } //add property dictionary to best keep track of plater with key/value pairs

        public abstract void Play();              //methods can only exist inside of an abstract class and contains NO implementation, any class inheriting this class must implement this method
        public virtual void ListPlayers()         //virtual keyword inside of an abstract class means that this method gets inherited by an inheriting class but has ability to override it
        {
            foreach (player player in Players)   //looping through players property
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
