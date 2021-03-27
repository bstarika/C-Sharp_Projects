using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //program with assigned value to variable
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine(); //assigning output to string variable
            //Console.WriteLine("Your name is: " + yourName); //string concatenation
            //Console.ReadLine();

            //program with casted string to integer
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine(); //assigning output to string variable, cannot assign to int
            //Console.WriteLine("Your favorite number is: " + favoriteNumber); //string concatenation
            //Console.ReadLine();

            //program continued from above casted string to integer
            Console.WriteLine("what is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();
        }
    }
}
