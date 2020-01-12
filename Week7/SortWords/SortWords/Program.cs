using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace SortWords
{
    class Program
    {
        static void Main(string[] args)
        {

            /*SortWords();

            SortWords("peach", "");

            SortWords("plum", "pear", "apple", "mango", "lemon");*/

            string[] colors = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "gray", "white"};

            foreach (var word in colors)
            {
                Write(word + " ");
            }
            WriteLine("\n\nRegular Sort:");

            SortWords(colors);

//            foreach (var word in colors)
//            {
//                Write(word + " ");
//            }
            WriteLine("\nReverse the sort:");

            SortWords(colors,true);


            int myNumber = Convert.ToInt32("FE", 16);
            WriteLine("\n\nMy number = " + myNumber);

            int myNumber1 = Convert.ToInt32("FE", 16);
            WriteLine("\n\nMy number1 = " + myNumber);

            string hexNumber = Convert.ToString(365, 16).ToUpper();
            WriteLine("\n\nMy hexNumber = " + hexNumber);


            string hexNumber1 = Convert.ToString(365, 10);
            WriteLine("\n\nMy hexNumber1 = " + hexNumber);

            string binaryNumber = Convert.ToString(365, 2);
            WriteLine("\n\nBinary Number = " + binaryNumber);


            WriteLine("\nPress any key to end...");
            ReadKey();
        }

        static void SortWords(string[] input, bool direction = false )
        {

            Array.Sort(input);

            if (direction)
            {
                Array.Reverse(input);
            }

            //Don''t normally write output from within an inner method.
            // This is for debug purposes only

            foreach (var word in input)
            {
                Write(word + " ");
                
            }
            WriteLine();
        }
    }
}
