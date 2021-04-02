using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static object Main(string[] args)
        {
            ////iterate integer array
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            ////create for loop with three conditions (starting value, do for loop for how many times there are items in array
            //// and last condition is what you want to do after loops runs, in this case add 1 to i
            //for (int i = 0; i < testScores.Length; i++)
            ////what you want to do in for loop goes in between curly braces
            //{
            //    //if statement [i] is item that you are targeting
            //    if (testScores[i] > 85)
            //    {
            //        //goes through each item and logs it if greater than 85
            //        Console.WriteLine("Passing Test Score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            ////iterate string array
            //string[] names = { "Breanna", "Stayce", "Brandon", "Kurt", "Ken" };
            //for (int n = 0; n < names.Length; n++)
            //{
            //    if (names[n] == "Breanna")
            //        Console.WriteLine(names[n]);
            //}
            //Console.ReadLine();

            ////iterate string array
            //string[] names = { "Breanna", "Stayce", "Brandon", "Kurt", "Ken" };
            //for (int n = 0; n < names.Length; n++)
            //{
            //    //instead of if loop, print each one to console (as sometimes, you don't know what is inside of array)
            //    Console.WriteLine(names[n]);
            //}
            //Console.ReadLine();

            ////iterate list int 
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            ////use of for each loop (for int score you can type anything, including i to represent items in list)
            //foreach (int score in testScores)
            //{
            //    if (score>85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            ////iterate list string
            //List<string> names = new List<string>() { "Breanna", "Stayce", "Brandon", "Kurt", "Ken" };
            ////use of for each loop
            //foreach (string name in names )
            //{
            //    if (name=="Breanna")
            //    {
            //        Console.WriteLine(name);
            //    }
            //    //or you can print ALL the names by erasing if statement and 
            //    //leave Console.WriteLine(name);
            //}
            //Console.ReadLine();

            ////iterate list int
            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //create a blank list (unlike an array where you have to define length)
            List<int> passingScores = new List<int>();
            //use of for each loop
            //below code will add passing cores from list testScores to list passingScores
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            //property Count will tell us how many elements in list scored above 85 and were added to list
            //whereas an array has length which will do same thing
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();


        }
    }
}
