// Exercise : Chap6 Test1
// Author   : Kat Nelson
// Date     : 10/01/19


using System.Linq;
using static System.Console;
using static System.Array;

namespace Chap6Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sales =
            {
                23.33, 233.2, 54, 56.7, 45.7, 45, 866.8, 54.5, 435.3, 34.1,
                2345.6, 465.2, 77.8, 59.7, 34.2, 123.8, 345.3, 23.77, 54.33, 87.08,
                68.7, 23.9}; 

            WriteLine("Value of sales [0] = " + sales[0]);
            WriteLine("Value of sales [9] = " + sales[9]);
            WriteLine("Value of sales [19] = " + sales[19]);

            WriteLine("\nFor loop: ");

            for (int i = 0; i < sales.Length; i++)
            {
                WriteLine("Value of sales [" + i + "] = " + sales[i]);
            }


            foreach (double value in sales)
            {
                WriteLine("Value of sales = " + value);
            }

            double sum = 0;
            double average = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                sum += sales[i];

            }

            average = sum / sales.Length;

            WriteLine("\nAverage of sales is: " + average);

            double quickAverage = sales.Average();

            WriteLine("\nAverage of sales is: " + quickAverage);


            WriteLine("\nSales figures greater than or equal to 90: \n");
            foreach (double value in sales)
            {
                if (value >= 90)
                {
                    WriteLine(value);
                }
            }

            // sorted array
            Sort(sales);

            WriteLine("\nSorted Array: \n");

            foreach (double value in sales)
            {
                WriteLine("Value of sales = " + value);
            }



            // binary search array - only works on ascending sorted arrays.

            double myValue = 54;
            WriteLine("\nBinary Search Array: ");

            int x = BinarySearch(sales, myValue);

            if (x < 0)
            {
                WriteLine("number not found. Value of x = " + x);
            }
            else
            {
                WriteLine("Number {0} found at position {1}.", myValue, x);
            }

            // reverse sorted array

            WriteLine("\nReverse Array: \n");
            Reverse(sales);

            foreach (double value in sales)
            {
                WriteLine("Value of sales = " + value);
            }

            // IndexOf search array
            WriteLine("\nIndex Search Array:\n" +
                      "value: " + myValue + " found at position: " + (IndexOf(sales, 54)));


            WriteLine("\nPress any key to end.");
            ReadKey();

        }
    }
}
