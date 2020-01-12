using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Averages
{
    class Program

    {
        static void Main(string[] args)
        {

            double[] myNumbers = {22, 34, 75, 99, 10}; // first Array

            WriteLine("Passing in an ARRAY of { 22, 34, 75, 99, 10 }");
            Average(myNumbers);

            WriteLine("Passing in ONE number: 5");
            Average(5);

            WriteLine("Passing in TWO numbers: 6, 8.9");
            Average(6,8.9);

            WriteLine("Passing in THREE numbers: 5, 34, 4");
            Average(5, 34, 4);

            WriteLine("The average of this array is: " + Average(myNumbers));

            WriteLine("\nPress any key to exit...");
            ReadKey();

            WriteLine("The average of this array is: " + Average(myNumbers));
        }

        static double Average(params double[] numbers)
        {
            double sum =0;

            foreach (var number in numbers)
            {
                sum += number;
            }
            
            double average = sum / numbers.Length;

            WriteLine("The sum of this array is: " + sum);
            
            WriteLine("\n");

            return average;
        }
    }


}
