using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CountBackwards
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Count backwards from 10 to -2 by twos.");

            WriteLine("hello world!");


//            for (int i = 10; i >= -10; i-=2)
//            {
//                WriteLine("i = " + i);
//            }

            int i = 0;

            int x = 0;

            WriteLine("i = "+ i++);
            WriteLine("x = " + ++x);

            WriteLine("i = " + i++);
            WriteLine("x = " + ++x);

            WriteLine("press any key to exit.");

            ReadKey();
        }
    }
}
