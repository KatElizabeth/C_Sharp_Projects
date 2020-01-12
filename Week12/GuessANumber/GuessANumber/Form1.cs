using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class Form1 : Form
    {

        int randomNumber;
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();

            randomNumber = random.Next(1, 6);

        }


        private void Button1_Click(object sender, EventArgs e)
        {

            String win = "You win! It was button " + randomNumber;
            String lose = "You lose, it was button " + randomNumber;

            switch (randomNumber)
            {
                case 1:
                    if (radioButton1.Checked)
                    {
                        lblOutcome.Text = win;
                        break;
                    }
                    else
                    {
                        lblOutcome.Text = lose;
                        break;
                    }
                case 2:
                    if (radioButton2.Checked)
                    {
                        lblOutcome.Text = win;
                        break;
                    }
                    else
                    {
                        lblOutcome.Text = lose;
                        break;
                    }
                case 3:
                    if (radioButton3.Checked)
                    {
                        lblOutcome.Text = win;
                        break;
                    }
                    else
                    {
                        lblOutcome.Text = lose;
                        break;
                    }
                case 4:
                    if (radioButton4.Checked)
                    {
                        lblOutcome.Text = win;
                        break;
                    }
                    else
                    {
                        lblOutcome.Text = lose;
                        break;
                    }
                case 5:
                    if (radioButton5.Checked)
                    {
                        lblOutcome.Text = win;
                        break;
                    }
                    else
                    {
                        lblOutcome.Text = lose;
                        break;
                    }
                default:
                    lblOutcome.Text = "Something went wrong!";
                    break;
            }
        
            // disable the buttons, enable play again.
            grpBox.Enabled = false;
            btnPlay.Enabled = true;
        
        }

        // give a hint when you mouse over, then disable further hints.
        private void LblHint_MouseHover(object sender, EventArgs e)
        {
            Random wrongRandom = new Random();
            int wrongNumber;

            while (true)
            {
                wrongNumber = wrongRandom.Next(1, 6);

                if (wrongNumber != randomNumber)
                {
                    lblHint.Text = "Button " + wrongNumber + " is not correct.";
                    lblHint.Enabled = false;
                    break;
                }
            }
        }

        // create new form to play again, reload all elements
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }


        // ensure all forms, even hidden ones, are closed upon exit.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
