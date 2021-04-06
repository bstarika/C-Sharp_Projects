using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class mathoperations //created class
    {

        public void MultiplyCubed(int num, int num2) //void method does not require a return statement, takes in two integers as parameters 
        {
            int result = num * num * num;           //first parameter will be cubed

            Console.WriteLine(num2);                //second parameter will be displayed
        }
        
        
        
        
        //public int Add(int num1, int num2 = 10) //two parameters, one optional
        //{
        //    int result = num1 + num2;
        //    return result;                      //returns integer
        //}
        
        //public int mathOp(int num)                   //method mathOp()
        //{   
        //    int result = num + num;                  //takes integer and does addition 
        //    return result;                           //returns answer as integer 
       
        //}
        //public int mathOp(double dec)                //method mathOp()
        //{
        //    int result = Convert.ToInt32(dec - dec); //takes decimal and does subtraction
        //    return result;                           //returns answer as integer
        //}

        //public int mathOp(string strNum)            //method mathOp()
        //{
        //    int num = Convert.ToInt32(strNum);      //takes string and conversts to int
        //    int result = num * num;                 //does multiplication
        //    return result;                          //returns answer as integer
        //}
    }
}
