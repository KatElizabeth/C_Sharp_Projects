using System;
using System.Windows.Forms;
using System.Media;
using GuessAWord.Properties;

namespace GuessAWord
{
    public partial class GuessWord : Form
    {
        private string[] words =
            {"hello", "world", "smart", "taco", "mother", "dad", "dog", "funny", "happy", "school", "unicorn"};

        private Random randomNumber = new Random();


        private string word;
        private string secretWord;
        private int tries;

        // adds two different sounds to program.
        SoundPlayer player = new SoundPlayer(Resources.applause4);
        SoundPlayer playerFail = new SoundPlayer(Resources.crowd_groan);



        public GuessWord()
        {
            InitializeComponent();
      
        }

        private void SubmitGuess_Click(object sender, EventArgs e)
        {

            String myLetter = "";

            char[] arrayHiddenWord = secretWord.ToCharArray();

            myLetter = textGuess.Text;
            myLetter = myLetter.ToLower(); // convert to lowercase, so that capitals don't trigger as a different letter.

            if (textLettersUsed.Text.Contains(myLetter))
            {
                statusMsg.Text = "You already used that letter. Try again!";
                playerFail.Play();
            }
            else
            {
                textLettersUsed.Text += myLetter;
                tries++;

                bool found = false;

                for (int i = 0; i < word.Length; i++)
                {
                    // if match found, replace * with letter that was guessed.
                    if (word.Substring(i, 1) == myLetter)
                    {
                        arrayHiddenWord[i] = Convert.ToChar(myLetter);
                        found = true;
                        statusMsg.Text = "Clap clap clap!";
                        player.Play();
                      
                    }
                }

                if (!found)
                {
                    statusMsg.Text = "Sigh...you fail!";
                    playerFail.Play();
                }

                secretWord = new string(arrayHiddenWord);
                hiddenWord.Text = secretWord;
                numTries.Text = Convert.ToString(tries);

                // has word been guessed?

                if (!secretWord.Contains("*"))
                {
                    statusMsg.Text = "You solved the word!";
                    player.Play();
                    submitGuess.Enabled = false;
                    playAgain.Visible = true;
                }
            }
            // erase text box after each guess.
            textGuess.Text = "";
            textGuess.Focus();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        // selects secret word, resets all fields to empty or zero.
        void NewGame()

        {
            word = words[randomNumber.Next(0, words.Length)];

            secretWord = "";

            // build secret word
            for (int i = 0; i < word.Length; i++)
            {
                secretWord += "*";
            }

            hiddenWord.Text = secretWord;

            numTries.Text = "";

            statusMsg.Text = "";

            textLettersUsed.Text = "";

            tries = 0;

            textGuess.Text = "";

            playAgain.Visible = false;

            submitGuess.Enabled = true;

        }

        private void GuessWord_Load(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
