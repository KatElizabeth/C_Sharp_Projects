// Guess A Word with dictionary
// Date: 12/03/19
// By:   Kat Nelson

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using GuessAWord.Properties;
using System.IO;  // need for file I/O to get dictionary words

namespace GuessAWord
{
    public partial class GuessWord : Form
    {
       // private string[] words =
       // {"hello", "world", "smart", "taco", "mother", "dad", "dog", "funny", "happy", "school", "unicorn"};

        List<string> words = new List<string>();

        readonly Random randomNumber = new Random();


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

                if (chkSound.Checked)
                {
                    playerFail.Play();
                }
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
                        
                        if (chkSound.Checked)
                        {
                            player.Play();
                        }

                    }
                }

                if (!found)
                {
                    statusMsg.Text = "Sigh...you fail!";
                    if (chkSound.Checked)
                    {
                        playerFail.Play();
                    }
                 
                }

                secretWord = new string(arrayHiddenWord);
                hiddenWord.Text = secretWord;
                numTries.Text = Convert.ToString(tries);

                // has word been guessed?

                if (!secretWord.Contains("*"))
                {
                    statusMsg.Text = "You solved the word!";

                    if (chkSound.Checked)
                    {
                        player.Play();
                    }

                    submitGuess.Enabled = false;
                    playAgain.Visible = true;

                    const string FILENAME = "scores.csv";

                    // if file doesn't already exist, it will write the header first
                    if (!File.Exists(FILENAME))
                    {
                        
                        // adds header to our output file
                        string clientHeader = $"\"Timestamp\",\"Word\",\"Attempts\"{Environment.NewLine}";
                        File.WriteAllText(FILENAME, clientHeader);
                    }

                    FileStream scoresFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(scoresFile);

                    // adds timestamp, word and # of tries on each word
                    writer.WriteLine(DateTime.Now.ToString("d") + " "  + DateTime.Now.ToString("t") + ", " + word + ", " + tries);

                    writer.Close();
                    scoresFile.Close();
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

       
        private void GuessWord_Load(object sender, EventArgs e)
        {

            // Read in our words...if dictionary fails to load these are backup words
            words.Add("ambidextrous");
            words.Add("keyboard");
            words.Add("intelligence");
            words.Add("philosophy");
            words.Add("message");
            words.Add("massage");
            words.Add("dexterity");
            words.Add("flamboyant");
            words.Add("acceleration");
            words.Add("realization");

            const string FILENAME = "dictionaryWords.txt";
            string lineIn;
            int lineCounter = 0;

            try
            {

                FileStream dictionaryFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(dictionaryFile);

                dictionaryFile.Position = 0;

                lineCounter = 0;

                lineIn = reader.ReadLine();

                while (lineIn != null)
                {
                    words.Add(lineIn);
                    lineCounter++;
                    lineIn = reader.ReadLine();
                }

                reader.Close();
                dictionaryFile.Close();

            }
            catch
            {
                MessageBox.Show("Dictionary not found.", "Reduced functionality", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            // Read in our preferences
            const string FILENAMEPREF = "preferences.txt";
            string lineInPref;

            try
            {

                FileStream preferencesFileStream = new FileStream(FILENAMEPREF, FileMode.Open, FileAccess.Read);
                StreamReader prefReader= new StreamReader(preferencesFileStream);


                // reads player name & sound pref
                chkSound.Checked = Convert.ToBoolean(prefReader.ReadLine());
                txtName.Text = prefReader.ReadLine();


                prefReader.Close();
                preferencesFileStream.Close();

            }
            catch
            {
                MessageBox.Show("Preferences not set.", "Preferences Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            NewGame();
        }

        // selects secret word, resets all fields to empty or zero.
        void NewGame()

        {
            word = words[randomNumber.Next(0, words.Count)];

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

        private void GuessWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string FILENAMEPREF = "preferences.txt";


            FileStream preferencesFileStream = new FileStream(FILENAMEPREF, FileMode.Create, FileAccess.Write);
            StreamWriter prefStreamWriter = new StreamWriter(preferencesFileStream);

            // saves sound prefrences & player's name
            prefStreamWriter.WriteLine(Convert.ToString(chkSound.Checked));
            prefStreamWriter.WriteLine(txtName.Text);

            prefStreamWriter.Close();
            preferencesFileStream.Close();

        }
    }
}
