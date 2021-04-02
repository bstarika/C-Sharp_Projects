using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Let's divide the two numbers..");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex) //ex is variable
            //{
            //    Console.WriteLine(ex.Message); //reads error to screen, this catch is is used to detect when a user enters in a string vs int
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero"); //can display own message instead of using variable in above example
            //}
            //catch (Exception ex) //general exception
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally //finally will ALWAYS run, even when there is exceptions, will often contain database log
            //{
            //    Console.ReadLine();
            //}
            try //try catch block 
            {
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 100 };

                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int num in numbers)
                { 
                    Console.WriteLine(num / userInput); //divides user input by int in list
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero"); //personlized error message
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter in a number");    //personalized error message
            }
            finally
            {
                Console.WriteLine("program has emerged from the try/catch block and continued on with program execution");
                Console.ReadLine();
            }
        }
    }
}