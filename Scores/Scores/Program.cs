using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\stari\source\repos\Scores\Scores\studentScores.txt"; //path to  imported file 
            string[] lines = System.IO.File.ReadAllLines(path); //store file as an array, IO function when you read file from Windows OS
            
            double tScore = 0.0; //initialize as 0

            Console.WriteLine("\nStudent Score: \n");
            foreach (string line in lines)//iterate through array with for each loop
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line); //convert data type scores from text file 
                tScore += score; //add score to running total
            }

            double avgScore = tScore / lines.Length; //(length of array), create variable to calculate average
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score " + avgScore);

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
