using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SentenceGeneration
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            // call method on button click, store returned string in variable.
            var mySentence = GenerateSentence();

            // output our sentence to the screen
            txtOutput.AppendText(mySentence + "\r\n");
        }


        // MY METHOD to generate the sentence
        private String GenerateSentence()
        {

            // arrays
            String[] nouns = new string[] {"boy", "girl", "dog", "unicorn", "taco"};
            String[] article = new string[] {"the", "a", "one", "some", "any"};
            String[] verb = new string[] {"drove", "jumped", "ran", "walked", "skipped"};
            String[] preposition = new string[] {"to", "from", "over", "under", "on"};

            // create random number to choose a word
            Random random = new Random();

            // sentence starts blank
            string sentence = "";


            // for each array, use a random number to get a word. random number will be between 0 and 4 as array is 5 long and starts counting at zero.
            sentence += article[random.Next(5)] + " ";
            sentence += nouns[random.Next(5)] + " ";
            sentence += verb[random.Next(5)] + " ";
            sentence += preposition[random.Next(5)] + " ";
            sentence += article[random.Next(5)] + " ";
            sentence += nouns[random.Next(5)] + ".";

            // capitalize the first letter of our sentence
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);

            //completed sentence returned to program to be outputted. 
            return sentence;
        }


    }

    
}
