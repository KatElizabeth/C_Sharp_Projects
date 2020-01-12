using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ReverseFour
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 11, num2 = 22, num3 = 33, num4 = 44;

            Write("Before calling method...");
            WriteLine("num1 = " + num1 + " num2 = " + num2 + " num3 = " + num3 + " num4 = " + num4);

            Reverse(ref num1, ref num2, ref num3, ref num4);

            Write("\n\nAfter calling method...");
            WriteLine("num1 = " + num1 + " num2 = " + num2 + " num3 = " + num3 + " num4 = " + num4);

            WriteLine("Press any key to end...");
            ReadKey();
        }

        static void Reverse(ref int one, ref int two, ref int three, ref int four)
        {

            int temp;

            //swap end two values
            temp = four;
            four = one;
            one = temp;

            //swap middle two values
            temp = two;
            two = three;
            three = temp;

        }
    }
}
