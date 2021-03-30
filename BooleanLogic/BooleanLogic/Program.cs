using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information below to see if you qualify for car insurance.");
            Console.WriteLine("What is your age?");
            int customerAge = Convert.ToInt32(Console.ReadLine()); //string to int
            Console.WriteLine("Have you ever had a DUI? Please Answer Yes or No");
            string customerDUI = Console.ReadLine(); 
            Console.WriteLine("How many speeding tickets do you have?");
            int customerTickets = Convert.ToInt32(Console.ReadLine()); //string to int
            Console.WriteLine("Do you qualify for car insurance?");
            bool customerQualifies = (customerAge > 15 && customerDUI == "No" && customerTickets <= 3); //boolean 
            Console.WriteLine(customerQualifies);
            Console.ReadLine();
        }
    }
}
