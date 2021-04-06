using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSub
{
    class MathOp     //class static
    {
        public void Divide(int num)     //void method that outputs integer, method will divide the data passed to it by 2
        {
            int result = num / 2;
            Console.WriteLine(result);
        }

        public void declareValues(out int num, out int num2) //output parameters, overload method
        {
            num = 2;
            num2 = 4;
        }

        public void declareValues(out double num, out double num2) //output parameters, overload method
        {
            num = 2.0;
            num2 = 4.0;
        }
    }
}
