using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class hrEmployee : itEmployee //Chain two constructors together by inheriting from another class
    {
        public hrEmployee() //constructor
        {
            Console.WriteLine("There is a new HR employee");
        }
    }
}
