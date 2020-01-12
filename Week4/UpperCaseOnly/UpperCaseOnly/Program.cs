using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace UpperCaseOnly
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
          
            int x = 0;

            do
            {

                WriteLine("enter an uppercase letter ONLY. Enter any number to quit.");

                input = ReadLine();

                WriteLine("Your input was: " + input);
                
                if (int.TryParse(input, out x))
                {
                    break;
                } else if (input == input.ToUpper()) 
                {
                    WriteLine("ok");
                }

                else
                {
                    WriteLine("ERROR, lowercase detected.");
                }



            } while (true);

            WriteLine("Enter any key to close.");
            ReadKey();
        }
    }
}
