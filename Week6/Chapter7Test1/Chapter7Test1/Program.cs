using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using static System.Console;

namespace Chapter7Test1
{
    class Program
    {
        private static int total = 76;

        static void Main(string[] args)
        {
           
            int value = 99;
            
            WriteLine("Value inside Main is = " + value);
            WriteLine("Total outside main = " + total);

            WriteLine("Enter the total sale : " );
            double totalSale = Convert.ToDouble(ReadLine());

            DoSomething(55);
            DoSomething(44.4);
            DoSomething("stupid");

            var myInitials = GetInitials("Kat", "Elizabeth", "Nelson");
            WriteLine("My initials are: " + myInitials);

            WriteLine("Your initials are: " + GetInitials("mister", "Fancy", "Pants"));


            // I am passing the user entered number into the DoTotal method.
            if (DoTotal(totalSale))
            {
                WriteLine("True was returned from DoTotal();");
            }
            else
            {
                WriteLine("False was returned from DoTotal();");
            }


            WriteLine("Press any key to exit.");
            ReadKey();
        }

        private static void DoSomething(int saleAmount)
        {

            int value = 34;

            int total;

            int x = 50;
            WriteLine("value inside DoSomething() = " + value);

            total = 100;

            WriteLine("Total inside DoSomething() = " + total);
            WriteLine("Global Total inside DoSomething() = " + Program.total);
            WriteLine("saleAmount inside DoSomething() = " + saleAmount);

        }

        private static void DoSomething(double saleAmount)
        {
            WriteLine("saleAmount from DoSomething(double) is: " + saleAmount);
         
        }

        private static void DoSomething(string sillyString)
        {
            WriteLine("sillyString from DoSomething(string) is: " + sillyString);

        }

        private static bool DoTotal(double total)
        {
            if (total >= 0 && total <= 100)
            {
                WriteLine("DoTotal() total = " + total);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static String GetInitials(string firstName, string middleName, string lastName)
        {
            string initials = "";

            initials = firstName.Substring(0, 1);
            initials += middleName.Substring(0, 1);
            initials += lastName.Substring(0, 1);
            initials = initials.ToUpper();

            return initials;
        }


    }
}
