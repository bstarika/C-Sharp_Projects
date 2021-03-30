using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching //if,else statement example
{
    class Program
    {
        static void Main(string[] args)
        {   //******************BRANCHING ASSIGNMENT*******************

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter package weight");
            int pkgWeight = Convert.ToInt32(Console.ReadLine()); //taking input converting to integer and assigning to int pkgWeight
            //if statement
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            //else statement
            else

                Console.WriteLine("Enter package width");
            int pkgWidth = Convert.ToInt32(Console.ReadLine()); //taking input converting to integer and assigning to int pkgWidth
            Console.WriteLine("Enter package height");
            int pkgHeight = Convert.ToInt32(Console.ReadLine()); //taking input converting to integer and assigning to int pkgHeight
            Console.WriteLine("Enter package length");
            int pkgLength = Convert.ToInt32(Console.ReadLine()); //taking input and converting to integer and assigning to intLength
            //if statement
            if (pkgWidth + pkgHeight + pkgLength > 50) 
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            //else statement
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: ");
                Console.WriteLine("$" + (pkgHeight * pkgLength * pkgWeight) * pkgWeight / 100);
                Console.WriteLine("Thank you!");
            }



            //Console.WriteLine("What is your favorite number");
            //int favNum = Convert.ToInt32(Console.ReadLine()); //taking input converting to integer and assigning it to int favNum
            //string result = favNum == 12 ? "That is also my favorite number" : "We do not have the same favorite number";
            //Console.WriteLine(result);


            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine(); //user input
            //Console.WriteLine("Hi " + name + " what is the temperature where you are?"); //concatenate strings
            //int currentTemperature = Convert.ToInt32(Console.ReadLine()); //user types something in, its converted to integer,and is assigned to currentTemperature
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("This wouldn't happen as there are only three possibilites :D");
            //}
            //int currentTemperature = 80;
            //int roomTemperature = 70;
            ////use of ternary operature (makes code much more compact and neat)


            //string comparisonResults = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResults);

            //if //if statement
            //    (currentTemperature == roomTemperature)
            //    {
            //        Console.WriteLine("It is exactly room temperature");
            //    }
            //else if (currentTemperature>roomTemperature) //goes after if and before else statement
            //    {
            //        Console.WriteLine("It is warmer than room temperature");
            //    }
            //else if (roomTemperature>currentTemperature)
            //    {
            //        Console.WriteLine("Room temperature is warmer than current temperature");
            //    }
            //else //else statement
            //    {
            //        Console.WriteLine("It is not exactly room temperature");
            //    }
            Console.ReadLine();
        }
    }
}