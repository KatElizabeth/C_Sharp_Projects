//SumInts Chap5 Ex 2
//Author: Kat Nelson
//Date:   09/24/19


using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static System.Console;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; // data from user
            int sum = 0;
            int num = 0;

            WriteLine("Enter integers one at a time.");
            WriteLine("Enter any other key but a number to quit.");

            do
            {

                Write("Enter a number: ");

                input = ReadLine().ToLower();

                if (Int32.TryParse(input, out num))
                {

                    sum = sum + num;
                }
                else
                {
                    break;
                }

            } while (true);

            WriteLine("Sum = " + sum);

            WriteLine("Press any key to end.");
            ReadKey();

        }
    }
}
