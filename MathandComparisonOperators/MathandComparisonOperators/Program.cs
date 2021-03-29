using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10; //addition
            //int othertotal = 20 + 22;
            //int combined = total + othertotal; //add variables together 
            //Console.WriteLine(combined);
            //Console.WriteLine("Five plus ten = " + total.ToString()); //casting int to string
            //Console.ReadLine();

            //int difference = 10 - 5; //subtraction
            //Console.WriteLine("Ten minus five = " + difference.ToString()); //casting int to string
            //Console.ReadLine();

            //int product = 10 * 5; //multiplication
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5; //division
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2; //modulus to determine remainder, where 0 means there isn't remainder, and 1 means there is
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueorfalse = 12 > 7; //boolean 
            //Console.WriteLine(trueorfalse.ToString()); //int to string
            //Console.ReadLine();

            //int roomTemperature = 70; //boolean
            //int currentTemperature = 72;
            //bool isWarm = currentTemperature > roomTemperature; //comparing two values (>=, <= can also be used and == checks for equality, and != checks for inequality)
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //*******************CONSOLE APPLICATION CHALLENGE********************************* 

            //Console.WriteLine("Insert Random Number");       
            //string random = Console.ReadLine();
            //int randomNumber = Convert.ToInt32(random); //casting string to int
            //int total = randomNumber * 50;        //multiplication to user input 
            //Console.WriteLine("The number you entered multiplied by 50 is: " + total);
            //Console.ReadLine();

            //Console.WriteLine("Insert Random Number");
            //string random = Console.ReadLine();
            //int randomNumber = Convert.ToInt32(random); //casting string to int
            //int total = randomNumber + 25;        //addition to user input 
            //Console.WriteLine("The number you entered plus 25 is: " + total);
            //Console.ReadLine();

            //Console.WriteLine("Insert Random Number");
            //string random = Console.ReadLine();
            //int randomNumber = Convert.ToInt32(random);  //casting string to int
            //int total = randomNumber/12;          //division to user input 
            //Console.WriteLine("The number you entered divided by 12.5 is: " + total);
            //Console.ReadLine();

            //Console.WriteLine("Insert Random Number"); 
            //string random = Console.ReadLine();
            //int randomNumber = Convert.ToInt32(random); //casting string to int
            //bool isGreaterThan = randomNumber > 50; //comparing two values w/ boolean 
            //Console.WriteLine(isGreaterThan);
            //Console.ReadLine();

            //Console.WriteLine("Insert Random Number");
            //string random = Console.ReadLine();
            //int randomNumber = Convert.ToInt32(random); //casting string to int
            //int remainder = randomNumber % 7; //prints remainder, 0 or 1 after dividing user input by 7
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //************************INCOME COMPARISON PROGRAM ASSIGNMENT**********************//
            Console.WriteLine("Anonymous Income Comparison Program"); //title

            Console.WriteLine("Person1");   //Person 1:

            Console.WriteLine("Hourly Rate");   //hourly rate
            int hourlyRate = Convert.ToInt32(Console.ReadLine());   //casting string to int w/ user input

            Console.WriteLine("Hours Worked Per Week");     //hours per week
            int hoursWorked = Convert.ToInt32(Console.ReadLine()); //casting string to int w/ user input 

            int total = (hourlyRate * hoursWorked *4) *12; //determining annual salary
            Console.WriteLine("Annual Salary: $" + total); //displaying total

            Console.WriteLine("Person2");       //Person 2:

            Console.WriteLine("Hourly Rate");      //hourly rate
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine()); //casting string to int w/ user input
      
            Console.WriteLine("Hours Worked Per Week");     //hours per week
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine()); //casting string to int w/ user input

            int total2 = (hourlyRate2 * hoursWorked2 *4) *12; //determining annual salary
            Console.WriteLine("Annual Salary: $" + total2); //displaying total

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compareEmployees = total > total2; //comparing person1 salary to person2 w/ boolean
            Console.WriteLine(compareEmployees);
            Console.ReadLine();
        }
    }
}
