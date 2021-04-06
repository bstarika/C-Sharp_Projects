using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjects
{
    class Person
    {
        public string FirstName { get; set; } //two properties, each of data type string

        public string LastName { get; set; } //gets name, sets name in main method

        public void SayName() //void method() 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //takes no parameters and simply writes the person's full name to the console in the format of: “Name: [full name]”
        }

    }
}
