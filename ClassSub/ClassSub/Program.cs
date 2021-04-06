using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSub
{
     class Program
    {
        static void Main(string[] args)
        {
            MathOp m = new MathOp();        //object
            Console.WriteLine("Input number");  //user inputs number
            int userInput = Convert.ToInt32(Console.ReadLine());
            m.Divide(userInput); //data passed to Divide method()
            Console.ReadLine(); //outputs result 
        }

        
    }
}
