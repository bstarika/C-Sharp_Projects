using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person //abstract class called Person with two properties: 
    {
        public string firstName { get; set; } //string firstName 
        public string lastName { get; set; } //string lastName.

        public virtual void SayName() //virtual methods allow subclasses of the type to override the method
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); 
        }

    }
}
