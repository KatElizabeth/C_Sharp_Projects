// kat nelson 09/24/19
// chapter 5 exercise Daily Temps

using System;
using static System.Console;

namespace DailyTemps
{
    class Program
    {
        static void Main()
        {

            int totalEntries = 0;
            double sum = 0;
            double average = 0;
            int temp = 0;

            string input; // user's input

            WriteLine("Please enter temperatures between -20 and 130F inclusive. I will calculate the average temp.\n" +
                      "Enter x to quit.\n");

            do {
                Write("Enter a temperature: ");
                input = ReadLine().ToLower();

                if (input != "x")
                {
                    if (int.TryParse(input, out temp) && temp >= -20 && temp <= 130)
                    {
                        sum += temp;
                        totalEntries++;
                    }
                    else
                    {
                        Write("\n**Error. Please enter a valid number between -20 and 130 inclusive. Enter x to quit.**\n\n");
                    }
                }

            } while (input != "x"); // end loop if user enters an X.

            average = sum / totalEntries; // sum the entries
            average = Math.Round(average, 2); // round to two decimal places

            WriteLine("\nYou entered " + totalEntries + " temperature(s).");
            WriteLine("\nThe average temperature is: " + average.ToString("0.00") + "°F.");
            WriteLine("\nPress any key to quit.");

            ReadKey();

        }
    }
}
