using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsingEnums
{
    class Program
    {
        public string Days { get; set; }
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
    Console.WriteLine("Enter in the day of the week");
    string Day = Console.ReadLine();
    }
}