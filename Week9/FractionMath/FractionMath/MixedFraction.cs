using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionMath
{
    class MixedFraction : Fraction
    {

        // Member Variables
        private int mixedWhole, mixedNum, mixedDen;

        // Constructor, if no input values are given

        public MixedFraction() : base()
        {
            mixedWhole = 0;

        }

        // Constructor with 3 params

        public MixedFraction(int whole, int numerator, int denominator) :

            base(CreateImproperNumerator(whole, numerator, denominator), Math.Abs(denominator))
        {
            whole = 0;
        }

        private static int CreateImproperNumerator(int whole, int numerator, int denominator)
        {
            int sign = 1;

            if (whole < 0)
            {
                sign *= -1;
                whole *= -1;
            }

            if (numerator < 0)
            {
                sign *= -1;
                numerator= -1;
            }

            if (denominator < 0)
            {
                sign *= -1;
                denominator *= -1;
            }

            numerator = sign * ((whole * denominator) + numerator);
            return numerator;

        }

        // getters
        public int GetWhole()
        {
            return mixedWhole;
        }

        public int GetMixedNumerator()
        {
            return mixedNum;
        }

        public int GetMixedDen()
        {
            return mixedDen;
        }

        public void ToMixedFraction(Fraction impFraction)
        {
            mixedWhole = impFraction.GetNumerator() / impFraction.GetDenominator();

            mixedNum = impFraction.GetNumerator() % impFraction.GetDenominator();

            if (mixedWhole < 0)
            {
                //strip negative off if whole is negative.
                mixedNum = Math.Abs(mixedNum);
            }

            mixedDen = impFraction.GetDenominator();

            if (mixedNum == 0)
            {
                mixedDen = 1;
            }


        }

        //convert fraction to string
        public String GetMixedString()
        {

            return Convert.ToString(this.mixedWhole) + " " + Convert.ToString(this.mixedNum) + "/ " +
                   Convert.ToString(this.mixedDen);
            
        }

    }
}
