using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace MathExcept
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            int result;

            Write("Enter 1st Number: ");
            num1 = Convert.ToInt32(ReadLine());

            Write("Enter 2nd Number: ");
            num2 = Convert.ToInt32(ReadLine());

         
            WriteLine("Number 1: " + num1);
            WriteLine("Number 2: " + num2);

            try
            {
                result = num1 / num2;
                WriteLine("Result: " + result);
            } 
            catch(DivideByZeroException e)
            {
                WriteLine("can't divide by zero. Result fail. \nError: \n" + e.Message);
             
            }

            

            WriteLine("Press any key to end.");
            ReadKey();


            
        }
    }
}
