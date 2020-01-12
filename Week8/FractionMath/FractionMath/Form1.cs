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
        private MixedFraction f1, f2;
        private MixedFraction answer;
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            f1 = new MixedFraction(Convert.ToInt32(txtWhole1.Text), Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new MixedFraction(Convert.ToInt32(txtWhole2.Text), Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

            Console.WriteLine("f1 numerator = " + f1.GetNumerator() + " AND f1 denominator = " + f1.GetDenominator());
            Console.WriteLine("f2 numerator = " + f2.GetNumerator() + " AND f2 denominator = " + f2.GetDenominator());


            // old school way if operator overloading is not allowed.
            answer = new Fraction();
            answer.Add(f1, f2);

            
           // Demonstration of operator overload use
//            answer = f1 + f2;

            
            numResult.Text = Convert.ToString(answer.GetNumerator());
            denResult.Text = Convert.ToString(answer.GetDenominator());

            lblResult.Text = answer.GetString();

        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            
            f1 = new Fraction(Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new Fraction(Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

            answer = new Fraction();
            answer.Subtract(f1, f2);

            numResult.Text = Convert.ToString(answer.GetNumerator());
            denResult.Text = Convert.ToString(answer.GetDenominator());

            lblResult.Text = answer.GetString();


        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            f1 = new Fraction(Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new Fraction(Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

            answer = new Fraction();
            answer.Multiply(f1, f2);

            numResult.Text = Convert.ToString(answer.GetNumerator());
            denResult.Text = Convert.ToString(answer.GetDenominator());

            lblResult.Text = answer.GetString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            f1 = new Fraction(Convert.ToInt32(num1.Text), Convert.ToInt32(den1.Text));
            f2 = new Fraction(Convert.ToInt32(num2.Text), Convert.ToInt32(den2.Text));

            answer = new Fraction();
            answer.Divide(f1, f2);

            numResult.Text = Convert.ToString(answer.GetNumerator());
            denResult.Text = Convert.ToString(answer.GetDenominator());

            lblResult.Text = answer.GetString();
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
        }
    }
}
