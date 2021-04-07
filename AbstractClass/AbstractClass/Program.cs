using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(); //instantiate an Employee object with: 
            e.firstName = "Sample"; //firstName “Sample” 
            e.lastName = "Student"; //and lastName “Student”.
            e.SayName(); //call the SayName() method on the object
            Console.ReadLine();
        }
    }
}
