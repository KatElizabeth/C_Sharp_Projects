using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using static System.Console;

namespace FractionMath
{
    class Fraction
    {
        private int numerator, denominator;


        // default constructor
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }

        public Fraction(int num, int denom)
        {
            this.numerator = num;
            this.denominator = denom;
            Reduce();
        }

        public int GetNumerator()
        {
            return numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        // private helper method to do reduction
        private void Reduce()
        {

            int sign = 1;

            if (numerator < 0)
            {
                sign *= -1;
                numerator *= -1;
            }

            if (denominator < 0)
            {
                sign *= -1;
                denominator *= -1;
            }

            for (int i = numerator; i > 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    // if true, found biggest number on top and bottom
                    // that is evenly divisible.
                    numerator /= i;
                    denominator /= i;
                    break;
                }
            }

            numerator *= sign;

        } // end Reduce()

        public Fraction Add(Fraction fraction1, Fraction fraction2)
        {
            this.numerator = (fraction1.numerator * fraction2.denominator) +
                             (fraction1.denominator * fraction2.numerator);
            this.denominator = fraction1.denominator * fraction2.denominator;
            this.Reduce();
            return this;
        }

        //example using operator overload
        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();

            result.numerator = (fraction1.numerator * fraction2.denominator) +
                             (fraction1.denominator * fraction2.numerator);

            result.denominator = fraction1.denominator * fraction2.denominator;
            result.Reduce();
            return result;
        } 


        // subtract fractions
        public Fraction Subtract(Fraction fraction1, Fraction fraction2)
        {
            this.numerator = (fraction1.numerator * fraction2.denominator) -
                             (fraction1.denominator * fraction2.numerator);
            this.denominator = fraction1.denominator * fraction2.denominator;

            this.Reduce();
            return this;

        }

        // multiply
        public Fraction Multiply(Fraction fraction1, Fraction fraction2)
        {
            this.numerator = fraction1.numerator * fraction2.numerator;
            this.denominator = fraction1.denominator * fraction2.denominator;

            this.Reduce();
            return this;
        }

        // divide
        public Fraction Divide(Fraction fraction1, Fraction fraction2)
        {
            this.numerator = fraction1.numerator * fraction2.denominator;
            this.denominator = fraction1.denominator * fraction2.numerator;

            this.Reduce();
            return this;
        }
        
        //convert fraction to string
        public String GetString()
        {
            return Convert.ToString(this.GetNumerator()) + "/" + Convert.ToString(this.GetDenominator());
        }
    }
}

