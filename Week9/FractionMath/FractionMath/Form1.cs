using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

            labelFraction1.Text = f1.GetString();
            labelFraction2.Text = f2.GetString();

           // Console.WriteLine("f1 numerator = " + f1.GetNumerator() + " AND f1 denominator = " + f1.GetDenominator());
           // Console.WriteLine("f2 numerator = " + f2.GetNumerator() + " AND f2 denominator = " + f2.GetDenominator());


           // old school way if operator overloading is not allowed.
            answer = new MixedFraction();
            answer.Add(f1, f2);

            // get mixed fractions for first and second entered fractions, print out as string
            MixedFraction mixedFraction1 = new MixedFraction();
            MixedFraction mixedFraction2 = new MixedFraction();

            mixedFraction1.ToMixedFraction(f1);
            mixedFraction2.ToMixedFraction(f2);

            labelFraction1.Text = mixedFraction1.GetMixedString();
            labelFraction2.Text = mixedFraction2.GetMixedString();


            //  Demonstration of operator overload use
            //            answer = f1 + f2;

            //            numResult.Text = Convert.ToString(answer.GetNumerator());
            //            denResult.Text = Convert.ToString(answer.GetDenominator());

            // Convert improper Fraction to mixed fraction
            MixedFraction mixedAnswer = new MixedFraction();

            mixedAnswer.ToMixedFraction(answer);

            lblResult.Text = mixedAnswer.GetMixedString();

            txtWholeResult.Text = Convert.ToString(mixedAnswer.GetWhole());
            numResult.Text = Convert.ToString(mixedAnswer.GetMixedNumerator());
            denResult.Text = Convert.ToString(mixedAnswer.GetMixedDen());


        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            
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

            //            numResult.Text = Convert.ToString(answer.GetNumerator());
            //            denResult.Text = Convert.ToString(answer.GetDenominator());
            //
            //            lblResult.Text = answer.GetString();


        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {

            f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

            // previously used, before mixed fractions
//            f1 = new Fraction(Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
//            f2 = new Fraction(Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

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

            //            numResult.Text = Convert.ToString(answer.GetNumerator());
            //            denResult.Text = Convert.ToString(answer.GetDenominator());
            //
            //            lblResult.Text = answer.GetString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {

            f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

            // used before mixed fractions
//            f1 = new Fraction(Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
//            f2 = new Fraction(Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

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
    }
}
