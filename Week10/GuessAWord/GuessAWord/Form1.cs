using System;
using System.Windows.Forms;
using System.Media;
using GuessAWord.Properties;


// Guess a word with exception handling 11/5/19
// by Kat

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

            // myLetter = textGuess.Text;

            try
            {

                myLetter = GetLetter(textGuess.Text);

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

            }
            catch (NonLetterException ex)
            {


                statusMsg.Text = "You entered a bad character: " + ex.OffendingCharacter;
              

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


        // Sanitize input, make sure only one character.
        private string GetLetter(string myString)
        {
            char letter;

            if (Char.TryParse(myString, out letter))
            {
                // have exactly one character

                letter = char.ToLower(letter);

                if (letter < 'a' || letter > 'z')
                {
                    // problem!
                    string badLetter = Convert.ToString(letter);
                    
                    throw (new NonLetterException(badLetter));
                    
                }

                string goodLetter = Convert.ToString(letter);
                return goodLetter;
            }
            else
            {
                throw (new NonLetterException("null or multiple characters"));

            }

            
        }
    } // end public class main

    // Custom exception class that book exercise asks us to create.

    public class NonLetterException : Exception
    {
        private string offendingChar;

        public NonLetterException() : base("A non-letter was entered.")
        {

        }

        public NonLetterException(string nonletter) : base("The non-letter '" + nonletter + "' was entered.")
        {
            offendingChar = nonletter;
        }

        public string OffendingCharacter
        {
            get { return offendingChar; }
        }

    } // end exception class
     
}
