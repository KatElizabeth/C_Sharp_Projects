using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class FormMain : Form
    {

        private int gamesPlayed = 0;

        Random randomNumber = new Random();

        enum Selection
        {
            ROCK,
            PAPER,
            SCISSORS
        };

        private Selection humanChoice, computerChoice;

        private int humanScore, computerScore, tieScore;



        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            humanScore = 0;
            computerScore = 0;
            tieScore = 0;

            labelChoice.Text = "";
            labelChoiceComp.Text = "";
            labelResult.Text = "";

            pictureHuman.BackgroundImage = null;
            pictureComp.BackgroundImage = null;


        }

        private void ButtonRock_Click(object sender, EventArgs e)
        {
            humanChoice = Selection.ROCK;
            CompareScores();

        }

        private void ButtonPaper_Click(object sender, EventArgs e)
        {
            humanChoice = Selection.PAPER;
            CompareScores();

        }

        private void ButtonScissors_Click(object sender, EventArgs e)
        {
            humanChoice = Selection.SCISSORS;
            CompareScores();

        }

        private void CompareScores()
        {
            gamesPlayed++;

            computerChoice = (Selection) randomNumber.Next(0, 3);

            switch (computerChoice)
            {
                case Selection.ROCK:
                    pictureComp.BackgroundImage = Properties.Resources.rock;
                    break;

                case Selection.PAPER:
                    pictureComp.BackgroundImage = Properties.Resources.paper;
                    break;

                case Selection.SCISSORS:
                    pictureComp.BackgroundImage = Properties.Resources.scissors;
                    break;
            }

            switch (humanChoice)
            {
                case Selection.ROCK:
                    pictureHuman.BackgroundImage = Properties.Resources.rock;
                    break;

                case Selection.PAPER:
                    pictureHuman.BackgroundImage = Properties.Resources.paper;
                    break;

                case Selection.SCISSORS:
                    pictureHuman.BackgroundImage = Properties.Resources.scissors;
                    break;
            }


            labelChoice.Text = Convert.ToString((Selection)humanChoice);
            labelChoiceComp.Text = Convert.ToString((Selection) computerChoice);
            textGamesPlayed.Text = Convert.ToString(gamesPlayed);

            // Tie selections
            if (humanChoice == computerChoice)
            {
                labelResult.ForeColor = Color.Black;
                labelResult.Text = "Tie";
                tieScore++;

            }
            else
            {
                // human wins

                if (humanChoice == Selection.ROCK && computerChoice == Selection.SCISSORS ||
                    humanChoice == Selection.PAPER && computerChoice == Selection.ROCK ||
                    humanChoice == Selection.SCISSORS && computerChoice == Selection.PAPER)
                {

                    labelResult.ForeColor = Color.DarkBlue;
                    labelResult.Text = "You win!";
                    humanScore++;
                }
                else
                {
                    // computer wins
                    labelResult.ForeColor = System.Drawing.Color.DarkRed;
                    labelResult.Text = "Computer won!";
                    computerScore++;


                }
            }

            textCompScore.Text = Convert.ToString(computerScore);
            textYourScore.Text = Convert.ToString(humanScore);
            textTieScore.Text = Convert.ToString(tieScore);

        }

       
    }
}
