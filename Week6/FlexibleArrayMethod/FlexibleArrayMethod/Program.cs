// Kat Nelson
// Oct 2019
// Ch 7 Exercise 10 Flexible array method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using static System.Console;

namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] grades1 = {89, 65, 34, 99, 100, 76, 88};
            int[] grades2 = {85, 99, 87, 76, 84};
            int[] grades3 = {89, 93, 79, 85, 93, 91, 82, 81, 94, 95};

            WriteLine("grades1 is: " + PrintArray(grades1));
            WriteLine("grades2 is: " + PrintArray(grades2));
            WriteLine("grades3 is: " + PrintArray(grades3));
            WriteLine();

            WriteLine("grades1 sum: " + FindSum(grades1));
            WriteLine("grades2 sum: " + FindSum(grades2));
            WriteLine("grades3 sum: " + FindSum(grades3));
            WriteLine();

            WriteLine("grades1 average:" + "{0:N2}", FindAverage(grades1));
            WriteLine("grades2 average:" + "{0:N2}", FindAverage(grades2));
            WriteLine("grades3 average:" + "{0:N2}", FindAverage(grades3));


            WriteLine();

            WriteLine("Press any key to end.");
            ReadKey();
        }

        private static String PrintArray(int[] myArray)
        {
            string result = "";
            foreach (int value in myArray)
            {
                result += value + " ";
            }

            return result;
        }

        private static int FindSum(int[] myArray)
        {
            int sum = 0;
            foreach (int value in myArray)
            {
                sum += value;
            }

            return sum;
        }


        private static double FindAverage(int[] myArray)
        {
            return FindSum(myArray) / (double)myArray.Length; // Casted one number to double to prevent integer division\
        }
    }
}
