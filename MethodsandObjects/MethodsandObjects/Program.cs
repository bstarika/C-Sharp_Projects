using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee n = new Employee(); // instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”
            //n.FirstName = "Sample";
            //n.LastName = "Student";

            //n.SayName(); //Call the superclass method SayName() on the Employee object
            //Console.ReadLine();

            //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
            Employee e = new Employee();
            Employee b = new Employee();

            int eId = 34; //use the newly overloaded == operator to compare two Employee objects by their Id
            int eId2 = 45;

            bool same = false;

            e.Id = eId;
            b.Id = eId2;

            same = e == b;
            Console.WriteLine(same);
            Console.ReadLine();

            
        }
    }
}
