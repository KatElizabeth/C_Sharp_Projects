using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guess100
{
    public partial class FormMain : Form
    {

        private int guesses = 0;

        private int humanGuess, computerGuess;

        Random randomNumber = new Random();

        public FormMain()
        {
            InitializeComponent();
            buttonReset.Visible = false; computerGuess = randomNumber.Next(1, 101);
            
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            humanGuess = Convert.ToInt32(textGuess.Text);

            CompareNumbers();

            guesses++;

            textNumOfTries.Text = Convert.ToString(guesses);

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

            guesses = 0;

            labelResult.Text = "New game starting...";

            computerGuess = randomNumber.Next(1, 101);

            textNumOfTries.Text = " ";

            textGuess.Text = " ";

            cheatText.Text = " ";

            buttonCheat.Enabled = true;

            buttonSubmit.Enabled = true;

            buttonReset.Visible = false;

        }

        private void ButtonCheat_Click(object sender, EventArgs e)
        {
            cheatText.Text = "You are a cheater! The computer's number is: " + Convert.ToString(computerGuess) + ". You may use this info to win now, you cheater.";
            buttonCheat.Enabled = false;

        }

        private void CompareNumbers()
        {
            if (humanGuess == computerGuess)
            {
                labelResult.Text = "You won! The correct number was " + computerGuess;
                buttonSubmit.Enabled = false;
                buttonReset.Visible = true;

            }
            else if (humanGuess > computerGuess)
            {
                labelResult.Text = "Your guess was too high.";

            }
            else
            {
                labelResult.Text = "Your guess was too low.";
            }
        }

    }
}
