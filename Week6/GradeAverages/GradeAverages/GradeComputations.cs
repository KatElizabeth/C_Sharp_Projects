using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeAverages
{
    static class GradeComputations
    {

        public static String PrintArray(int[] myArray)
        {
            string result = "";
            foreach (int value in myArray)
            {
                result += value + " ";
            }

            return result;
        }

        public static int FindSum(int[] myArray)
        {
            int sum = 0;
            foreach (int value in myArray)
            {
                sum += value;
            }

            return sum;
        }


        public static double FindAverage(int[] myArray)
        {
            return FindSum(myArray) / (double)myArray.Length; // Casted one number to double to prevent integer division\
        }
    }



}

