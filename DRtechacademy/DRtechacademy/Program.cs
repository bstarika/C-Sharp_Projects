using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRtechacademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); ///title
            Console.WriteLine("Student Daily Report"); //title
            Console.WriteLine("What is your name?"); //question with user input
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?"); //question with user input
            string course = Console.ReadLine();
            Console.WriteLine("What page number?"); //question with user input
            string page = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\" "); //question with user input
            string help = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics."); //question with user input
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific."); //question with user input
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?"); //question with user input
            string hours = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); //prompt after all questions answered
            Console.ReadLine(); //waits for user input
        }
    }
}
