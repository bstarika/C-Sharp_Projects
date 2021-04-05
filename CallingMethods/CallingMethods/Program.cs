using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            mathoperation m = new mathoperation(); //created object to call methods in mathoperation class
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine()); //user input

            m.Add(userInput); //calling method Add
            m.Subtract(userInput); //calling method Subtract
            m.Multiply(userInput); //caling method Multiply

            Console.ReadLine();
        }
    }
}



