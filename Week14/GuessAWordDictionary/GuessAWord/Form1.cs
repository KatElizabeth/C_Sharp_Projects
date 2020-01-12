// Guess A Word with dictionary
// Date: 12/03/19
// By:   Kat Nelson

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using GuessAWord.Properties;
using System.IO;  // need for file I/O to get dictionary words
using System.Net;

namespace GuessAWord
{
    public partial class GuessWord : Form
    {
       // private string[] words =
       // {"hello", "world", "smart", "taco", "mother", "dad", "dog", "funny", "happy", "school", "unicorn"};

        List<string> words = new List<string>();

        readonly Random randomNumber = new Random();

        private string word;
        private string definition;
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

            // Read in our preferences
            const string FILENAMEPREF = "preferences.txt";
            string lineInPref;

            try
            {

                FileStream preferencesFileStream = new FileStream(FILENAMEPREF, FileMode.Open, FileAccess.Read);
                StreamReader prefReader = new StreamReader(preferencesFileStream);


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

            string content;

            try
            {
                using (WebClient client = new WebClient())
                {
                  

                    string url = "https://randomwordgenerator.org/Word/generate/quantity/1";
                    content = client.DownloadString(url);
                    //Console.WriteLine(content);


                    string randomWordStart = @"<p class='result'><b>";
                    int startWord = content.IndexOf(randomWordStart) + 21;
                    int stopWord = content.IndexOf("</b>", startWord);

                    //Console.WriteLine("startWord=" + startWord + " stopWord = " + stopWord);

                    if (content.IndexOf(randomWordStart) != -1)
                    {
                        // string was found
                        word = content.Substring(startWord, stopWord - startWord).ToLower();

//                        word = "Taco-party ok!";
//                        word = word.ToLower();
//                        Console.WriteLine("word = " + word);

                    }
                    else
                    {
                        // word not found
                        lblDefinition.ForeColor = Color.Red;
                        lblDefinition.Text = "Error, word wasn't found";
                    }

                    string randomDefStart = @"<p class='mean'>";
                    int startDefinition = content.IndexOf(randomDefStart) + 16;
                    int stopDefinition = content.IndexOf("</p>", startDefinition);

                 //   Console.WriteLine("startDefinition=" + startDefinition + " stopDef = " + stopDefinition);

                    if (content.IndexOf(randomDefStart) != -1)
                    {
                        // string was found
                        definition= content.Substring(startDefinition, stopDefinition - startDefinition);
                      // Console.WriteLine("def = " + definition);

                        definition = definition.Replace("&nbsp;&nbsp;", "\r\n");

                        lblDefinition.Text = definition;
                    }
                    else
                    {
                        // def not found
                        lblDefinition.ForeColor = Color.Red;
                        lblDefinition.Text = "Error. Definition was not found.";

                    }

                }

            }
            catch (WebException ex)
            {
              //  Console.WriteLine(ex.ToString());
                lblDefinition.Text = "Online dictionary not found.";
            }


            

            secretWord = "";

            // build secret word
            for (int i = 0; i < word.Length; i++)
            {
                secretWord += "*";
            }


//            prefill all hyphens

//            String myLetter = "-";
//            char[] arrayHiddenWord = secretWord.ToCharArray();
//
//            for (int i = 0; i < word.Length; i++)
//            {
//                // if match found, replace * with letter that was guessed.
//                if (word.Substring(i, 1) == myLetter)
//                {
//                    arrayHiddenWord[i] = Convert.ToChar(myLetter);
//
//                }
//            }


            // *** CHANGES BY ME ** 
            // I decided to try to take this one step further and make it check for any chars that are not letters.
            // this checks for ALL punctuation within a secret word, not just letters.
            char[] arrayHiddenWord = secretWord.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                char c = Convert.ToChar(word.Substring(i, 1));

                // if the char is not a letter, reveal it in our word.
                if (!char.IsLetter(c)) 
                {
                    arrayHiddenWord[i] = c;
                }
            }

            secretWord = new string(arrayHiddenWord);
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
