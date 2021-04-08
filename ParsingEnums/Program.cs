﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum Days                       //use of enum, don't have to put "" around set of named values
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
        
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Enter in the day of the week.");
                string userInput = Console.ReadLine();
                Days day = (Days)Enum.Parse(typeof(Days), userInput);
                Console.WriteLine(day);
                    Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
        
    }
}
