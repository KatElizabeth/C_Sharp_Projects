// Sum200 Chapter5 Ex 9
// Author: Kat Nelson
// Date  : 09/24/19

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace Sum200
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Sums the integers from 1 through 200 inclusive.\n");
     
            int sum =0;

            for (int i = 1; i <= 200; i++)
            {
                sum += i;
                if (i == 100)
                {
                    Write("The sum of 1 to 100 is: " + sum);
                }
            }

            WriteLine("\nThe sum total is: " + sum);

            WriteLine("\nPress any key to end.");
            ReadKey();

        }
    }
}
