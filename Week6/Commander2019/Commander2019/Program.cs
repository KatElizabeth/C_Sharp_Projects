using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace Commander2019
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;
            double result;

            try
            {
                a = Convert.ToDouble(args[0]);
                b = Convert.ToDouble(args[1]);
                result = a * b;
                WriteLine("Result = " + result);
            }
            catch (IndexOutOfRangeException e)
            {
                WriteLine("You must provide two values.");
                WriteLine("Error: " + e.Message);

            }
            catch (FormatException e)
            {
                WriteLine("You must provide numbers.");
                WriteLine("Error: " + e.Message);
            }


            ReadKey();

        }
    }
}
