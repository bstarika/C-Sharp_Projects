using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeLog
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; //print current date and time to console
            Console.WriteLine(now);
            Console.ReadLine();

            Console.WriteLine("Please enter in a number");
            int userNumber = Convert.ToInt32(Console.ReadLine()); //ask user for a number

            Console.WriteLine("{0} + {1} hours = {2}", DateTime.Now, userNumber, DateTime.Now.AddHours(userNumber)); //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.ReadLine();
        }
    }
}
