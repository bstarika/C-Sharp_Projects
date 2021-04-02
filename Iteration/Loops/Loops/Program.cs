using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //************CREATE YOUR OWN WHILE LOOP****************
            int i = 0;
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }

            //************CREATE YOUR OWN DO WHILE LOOP****************
            
            //Console.WriteLine("Guess my age");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool isGuessed = number == 27;

            //do
            //{
            //    switch (number)
            //    {
            //        case 30:
            //            Console.WriteLine("Close...REALLY close. Try again");
            //            Console.WriteLine("Guess my age");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break; //checks to see if conditions are met, discontinues switch statement
            //        case 50:
            //            Console.WriteLine("That is my mom. Try again");
            //            Console.WriteLine("Guess my age");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 22:
            //            Console.WriteLine("Nope. But that is my lucky number. Try Again");
            //            Console.WriteLine("Guess my age");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 18:
            //            Console.WriteLine("I wish. Try Again");
            //            Console.WriteLine("Guess my age");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 27:
            //            Console.WriteLine("You guessed right! Good job!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong");
            //            Console.WriteLine("Guess my age");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //    }
            //}

            //while (!isGuessed);  //WHILE loop originally set to top of code before switch statements, however, with addition of do/while, it will be placed at bottom of code

            //*************GUESS A NUMBER DO WHILE LOOP****************
            //    Console.WriteLine("Guess a number?");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    bool isGuessed = number == 22; //is number equal to 22, will return true or false

            //    do //do while loop
            //    {
            //        switch (number) //switch statement
            //        {
            //            case 62: //if number equals 62...
            //                Console.WriteLine("You guessed 62! Try Again.");
            //                Console.WriteLine("Guess a number?");
            //                number = Convert.ToInt32(Console.ReadLine());
            //                break; //discontinues switch statement
            //            case 29: //if number equals 29...
            //                Console.WriteLine("You guessed 29! Try Again.");
            //                Console.WriteLine("Guess a number?");
            //                number = Convert.ToInt32(Console.ReadLine());
            //                break; //discontinues switch statement
            //            case 55: //if number equals 55...
            //                Console.WriteLine("You guessed 55! Try Again.");
            //                Console.WriteLine("Guess a number?");
            //                number = Convert.ToInt32(Console.ReadLine());
            //                break; //discontinues switch statement
            //            case 22: //if number equals 22...
            //                Console.WriteLine("You guessed 22! You Are Correct.");
            //                isGuessed = true;
            //                break; //discontinues switch statement
            //            default: //if no cases are entered
            //                Console.WriteLine("You Are Wrong");
            //                break; //discontinues switch statement
            //        }
            //    }

            //    while (!isGuessed); //while loop, also same as typing isGuessed==false, while isGuessed==false, do this...

            Console.ReadLine();
        }
    }
}
