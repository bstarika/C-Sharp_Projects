using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{

    public class itEmployee
    {
        public itEmployee() : this(80000)
        {
            
        }

        public itEmployee(int sal)
        {
            Console.WriteLine("This IT Employee's Salary is $" + sal);
        }


    }
}
