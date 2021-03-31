using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ////code two very similiar data types - arrays and lists:
        ////ARRAYS:
        ////integer array:
        //int[] numArray = new int[5]; //have to define length of array in brackets
        //numArray[0] = 5; //to add items to array, 0 based index
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////could also write the above this way, cleaner to read and easier to write
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //also don't have to set a length

        ////you also don't have to say you're creating a new int [] array
        ////you can write the above as follows...
        //int[] numArray2 = { 5, 2, 10, 200, 5000 };
        //numArray2[0] = 22; //changes number within array

        //Console.WriteLine(numArray[3]);
        //Console.WriteLine(numArray1[3]);
        //Console.WriteLine(numArray2[0]);
        //Console.ReadLine();

        //LISTS:
        //can create a list with any data type
        //List<int> intList = new List<int>(); //don't have to declare length, can replace <int> with <string>
        //                                     //and replace all of the below to strings
        //intList.Add(4); //adding integer to list
        //intList.Add(10); //adding integer to list, other methods include 
        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //ARRAY & LIST ASSIGNMENT
        //Array of strings, displays index of user input
        int userIndex = 0;
        while (userIndex != 20)
        {
            Console.WriteLine("I created an array that lists all of my dogs names \n Pick a number between 0 and 4. Type 20 to end.");
            string[] dogs = { "Shiloh", "Lilly", "Mochi", "Ziah", "Loki" };
            userIndex = Convert.ToInt32(Console.ReadLine());
            if (userIndex < 5)
            {
                Console.WriteLine(dogs[userIndex]);
            }

            if (userIndex > 4 && userIndex != 20)
            {
                Console.WriteLine("You didn't choose a number between 1 and 4. Try Again");
            }

        }


        //Array of integers, displays index of user input
        int userIndex2 = 0;
        while (userIndex2 != 20)
        {
            Console.WriteLine("I created an array that lists siblings age \n Pick a number between 0 and 3. Type 20 to end.");
            int[] ages = { 15, 18, 18, 25 };
            userIndex2 = Convert.ToInt32(Console.ReadLine());

            if (userIndex2 < 4)
            {
                Console.WriteLine(ages[userIndex2]);
            }

            if (userIndex2 > 3 && userIndex != 20)
            {
                Console.WriteLine("You didn't enter a number between 0 and 3. Try again.");
            }
        }

        //List of strings, displays index of user input
        int userIndex3 = 0;
        while (userIndex3 != 20)
        {
            Console.WriteLine("I created a list of my favorite netflix shows. Pick a number between 0 and 5. Type 20 to end.");
            List<string> stringList = new List<string>();
            stringList.Add("The Office"); //adding string to list
            stringList.Add("Game of Thrones");
            stringList.Add("Stranger Things");
            stringList.Add("Bridgerton");
            stringList.Add("Ozark");
            stringList.Add("Breaking Bad");
            userIndex3 = Convert.ToInt32(Console.ReadLine());

            if (userIndex3 < 6)
            {
                Console.WriteLine(stringList[userIndex3]);
            }

            if (userIndex3 > 5)
            {
                Console.WriteLine("You didn't enter a number between 0 and 5. Try again.");
            }
        }
    }
}

