using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FractionMath
{
    public partial class FormMain : Form
    {
        private Fraction f1, f2;
        private MixedFraction answer;
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            // Verify Number will parse our entries. This version will use TryParse in the method VerifyNumbers().
            String badEntry = VerifyNumbers();


            // if VerifyNumbers didn't return null, it found bad character, break out of method and return to main for user to fix.
            if (badEntry != null)
            {
                labelResults.Text = "You entered an invalid number. Please enter a valid integer. Bad entry: " + badEntry;
                return;
            }

            // no bad entries found, continue with fraction creation and math!
            f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text),
                    Convert.ToInt32(den1.Text));
            f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text),
                    Convert.ToInt32(den2.Text));


//            // If I wanted to use Try/Catch: This code would replace above code. It will print out an error message.
//
//            try
//            {
//                f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text),
//                    Convert.ToInt32(den1.Text));
//                f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text),
//                    Convert.ToInt32(den2.Text));
//            }
//            catch (FormatException exception)
//            {
//                labelResults.Text = "Data entered was not valid. Enter valid integers. Error: " + exception.Message;
//                return;
//            }


            labelFraction1.Text = f1.GetString();
            labelFraction2.Text = f2.GetString();

            answer = new MixedFraction();
            answer.Add(f1, f2);

            // get mixed fractions for first and second entered fractions, print out as string
            MixedFraction mixedFraction1 = new MixedFraction();
            MixedFraction mixedFraction2 = new MixedFraction();

            mixedFraction1.ToMixedFraction(f1);
            mixedFraction2.ToMixedFraction(f2);

            labelFraction1.Text = mixedFraction1.GetMixedString();
            labelFraction2.Text = mixedFraction2.GetMixedString();

            // Convert improper Fraction to mixed fraction
            MixedFraction mixedAnswer = new MixedFraction();

            mixedAnswer.ToMixedFraction(answer);

            lblResult.Text = mixedAnswer.GetMixedString();

            txtWholeResult.Text = Convert.ToString(mixedAnswer.GetWhole());
            numResult.Text = Convert.ToString(mixedAnswer.GetMixedNumerator());
            denResult.Text = Convert.ToString(mixedAnswer.GetMixedDen());
            labelResults.Text = ("All your numbers were valid!");

        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {

            // Verify Number will parse our entries. This version will use TryParse in the method VerifyNumbers().
            String badEntry = VerifyNumbers();


            // if VerifyNumbers didn't' null, it found bad character, break out of method and return to main for user to fix.
            if (badEntry != null)
            {
                labelResults.Text = "You entered an invalid number. Please enter a valid integer. Bad entry: " + badEntry;
                return;
            }


            f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

            answer = new MixedFraction();
            answer.Subtract(f1, f2);

            // get mixed fractions for first and second entered fractions, print out as string
            MixedFraction mixedFraction1 = new MixedFraction();
            MixedFraction mixedFraction2 = new MixedFraction();

            mixedFraction1.ToMixedFraction(f1);
            mixedFraction2.ToMixedFraction(f2);

            labelFraction1.Text = mixedFraction1.GetMixedString();
            labelFraction2.Text = mixedFraction2.GetMixedString();

            // Convert improper Fraction to mixed fraction
            MixedFraction mixedAnswer = new MixedFraction();

            mixedAnswer.ToMixedFraction(answer);


            lblResult.Text = mixedAnswer.GetMixedString();

            txtWholeResult.Text = Convert.ToString(mixedAnswer.GetWhole());
            numResult.Text = Convert.ToString(mixedAnswer.GetMixedNumerator());
            denResult.Text = Convert.ToString(mixedAnswer.GetMixedDen());
            labelResults.Text = ("All your numbers were valid!");

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {

            // Verify Number will parse our entries. This version will use TryParse in the method VerifyNumbers().
            String badEntry = VerifyNumbers();


            // if VerifyNumbers didn't' null, it found bad character, break out of method and return to main for user to fix.
            if (badEntry != null)
            {
                labelResults.Text = "You entered an invalid number. Please enter a valid integer. Bad entry: " + badEntry;
                return;
            }

            f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));


            answer = new MixedFraction();
            answer.Multiply(f1, f2);

            // get mixed fractions for first and second entered fractions, print out as string
            MixedFraction mixedFraction1 = new MixedFraction();
            MixedFraction mixedFraction2 = new MixedFraction();

            mixedFraction1.ToMixedFraction(f1);
            mixedFraction2.ToMixedFraction(f2);

            labelFraction1.Text = mixedFraction1.GetMixedString();
            labelFraction2.Text = mixedFraction2.GetMixedString();


            // Convert improper Fraction to mixed fraction
            MixedFraction mixedAnswer = new MixedFraction();

            mixedAnswer.ToMixedFraction(answer);


            lblResult.Text = mixedAnswer.GetMixedString();

            txtWholeResult.Text = Convert.ToString(mixedAnswer.GetWhole());
            numResult.Text = Convert.ToString(mixedAnswer.GetMixedNumerator());
            denResult.Text = Convert.ToString(mixedAnswer.GetMixedDen());
            labelResults.Text = ("All your numbers were valid!");

        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {

            // Verify Number will parse our entries. This version will use TryParse in the method VerifyNumbers().
            String badEntry = VerifyNumbers();


            // if VerifyNumbers didn't' null, it found bad character, break out of method and return to main for user to fix.
            if (badEntry != null)
            {
                labelResults.Text = "You entered an invalid number. Please enter a valid integer. Bad entry: " + badEntry;
                return;
            }

            f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));


            answer = new MixedFraction();
            answer.Divide(f1, f2);

            // get mixed fractions for first and second entered fractions, print out as string
            MixedFraction mixedFraction1 = new MixedFraction();
            MixedFraction mixedFraction2 = new MixedFraction();

            mixedFraction1.ToMixedFraction(f1);
            mixedFraction2.ToMixedFraction(f2);

            labelFraction1.Text = mixedFraction1.GetMixedString();
            labelFraction2.Text = mixedFraction2.GetMixedString();

            // Convert improper Fraction to mixed fraction
            MixedFraction mixedAnswer = new MixedFraction();

            mixedAnswer.ToMixedFraction(answer);

            lblResult.Text = mixedAnswer.GetMixedString();

            txtWholeResult.Text = Convert.ToString(mixedAnswer.GetWhole());
            numResult.Text = Convert.ToString(mixedAnswer.GetMixedNumerator());
            denResult.Text = Convert.ToString(mixedAnswer.GetMixedDen());
            labelResults.Text = ("All your numbers were valid!");

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        public void ClearResult(object sender, EventArgs e)
        {
            numResult.Text = "";
            denResult.Text = "";
            lblResult.Text = "";
            txtWholeResult.Text = "";
        }

        
        // This method will parse all user-entrered characters. It will return null if all entries are good. If it finds bad characters, it will
        // return the first offending character that was found.
        public String VerifyNumbers()

        {

            bool passTest;
            int number; // used for parsing

            string[] myArray = new string[] {txtWhole1.Text, txtWhole2.Text, num1.Text, num2.Text, den1.Text, den2.Text };


            // go through all entered numbers, try to parse to int. If it won't parse, return first offending number for correction.
            for (int i = 0; i < myArray.Length; i++)
            {
                passTest = Int32.TryParse(myArray[i], out number);
                if (!passTest)
                {
                    // if it doesn't parse, pass it back to request correction.
                    return myArray[i];
                }
            }

            return null;

        }

    }
}
