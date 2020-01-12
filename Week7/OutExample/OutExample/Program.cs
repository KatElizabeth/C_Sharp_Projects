using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;

namespace OutExample
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 11, num2 = 22, num3 = 33, num4 = 44;

            int summation = 0;
            double average = 0;

            Write("Before calling method...");
            WriteLine("num1 = " + num1 + " num2 = " + num2 + " num3 = " + num3 + " num4 = " +num4);
            WriteLine("Summation = " + summation + " Average = " + average);

            Calculate(num1, num2, num3, num4, out summation, out average);

            Write("\n\nAfter calling method...");
            WriteLine("num1 = " + num1 + " num2 = " + num2 + " num3 = " + num3 + " num4 = " + num4);
            WriteLine("Summation = " + summation + " Average = " + average);

            WriteLine("Press any key to exit");
            ReadKey();

        }

        static void Calculate(int one, int two, int three, int four, out int sum, out double average)
        {
            // computer the sum
            sum = one + two + three + four;
            
            // compute average
            average = sum / 4.0;
        }
    }
}
