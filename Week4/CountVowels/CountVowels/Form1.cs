// by kat nelson
// count vowels ch 5
// 9/24/19 
// This program takes input of text from a user and outputs the number of vowels in the text.

using System;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class CountVowels : Form
    {
        private int count; //tracks number of vowels found

        public CountVowels()
        {
            InitializeComponent();
        }

        // submit button starts process of counting vowels.
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // changes user input to lowercase and stores in string.
            var input = textInput.Text.ToLower();


            // takes each char from the string, checks if it is a vowel, and if so, adds to vowel count.
            foreach (char c in input)
                if (c == 'e' || c == 'a' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            
            // outputs final vowel count
            textFinalCount.Text = count.ToString();
        }


        // if user changes text in the text box, count is reset to zero and must be submitted again to get count.
        private void TextInput_TextChanged(object sender, EventArgs e)
        {
            count = 0;
            textFinalCount.Text = "";
        }
    }
}