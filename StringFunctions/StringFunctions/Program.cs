using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //escape, new line, and tab character 
            string quote = "The computer said \"Hello, Breanna\" \n \t \"How are you today?\" \n \t \t \"What is the weather like in Colorado?\"";
            //use of two blackslashes when representing file 
            string fileName = "C:\\Users\\Breanna";
            //OR, you can begin with @ symbol, which tells computer there isn't any escape sequences inside string
            string atSymbol = @"C:\Users\Breanna";
            //checks to see if name contains letter n
            string name = "Breanna";
            bool trueORfalse = name.Contains("n");
            //instead of name.Contains, you can also use other properties such
            //as .EndsWith, .Length, .ToUpper, .ToLower and so forth.
            //above are useful when parsing files when wanting to search for something particular
            Console.WriteLine(quote);
            Console.WriteLine(fileName);
            Console.WriteLine(atSymbol);
            Console.WriteLine(name);
            Console.WriteLine("Does name contain letter n?");
            Console.WriteLine(trueORfalse);
            Console.ReadLine();
        }
    }
}
