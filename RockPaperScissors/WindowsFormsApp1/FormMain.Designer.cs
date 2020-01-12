namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.labelChoice = new System.Windows.Forms.Label();
            this.labelChoiceComp = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCompScore = new System.Windows.Forms.Label();
            this.labelTie = new System.Windows.Forms.Label();
            this.textYourScore = new System.Windows.Forms.TextBox();
            this.textCompScore = new System.Windows.Forms.TextBox();
            this.textTieScore = new System.Windows.Forms.TextBox();
            this.labelGamesPlayed = new System.Windows.Forms.Label();
            this.textGamesPlayed = new System.Windows.Forms.TextBox();
            this.pictureHuman = new System.Windows.Forms.PictureBox();
            this.pictureComp = new System.Windows.Forms.PictureBox();
            this.labelHumanChose = new System.Windows.Forms.Label();
            this.labelComputerChose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRock
            // 
            this.buttonRock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRock.Location = new System.Drawing.Point(59, 24);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(90, 53);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.Text = "Rock";
            this.buttonRock.UseVisualStyleBackColor = false;
            this.buttonRock.Click += new System.EventHandler(this.ButtonRock_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPaper.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaper.Location = new System.Drawing.Point(166, 24);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(90, 53);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.UseVisualStyleBackColor = false;
            this.buttonPaper.Click += new System.EventHandler(this.ButtonPaper_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonScissors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScissors.Location = new System.Drawing.Point(270, 24);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(90, 53);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.Text = "Scissors";
            this.buttonScissors.UseVisualStyleBackColor = false;
            this.buttonScissors.Click += new System.EventHandler(this.ButtonScissors_Click);
            // 
            // labelChoice
            // 
            this.labelChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoice.Location = new System.Drawing.Point(29, 307);
            this.labelChoice.Name = "labelChoice";
            this.labelChoice.Size = new System.Drawing.Size(167, 23);
            this.labelChoice.TabIndex = 3;
            this.labelChoice.Text = "***";
            this.labelChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChoiceComp
            // 
            this.labelChoiceComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoiceComp.Location = new System.Drawing.Point(225, 307);
            this.labelChoiceComp.Name = "labelChoiceComp";
            this.labelChoiceComp.Size = new System.Drawing.Size(167, 23);
            this.labelChoiceComp.TabIndex = 4;
            this.labelChoiceComp.Text = "***";
            this.labelChoiceComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(109, 113);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(201, 22);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Last Match Result";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(136, 348);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(60, 13);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "Your Score";
            // 
            // labelCompScore
            // 
            this.labelCompScore.AutoSize = true;
            this.labelCompScore.Location = new System.Drawing.Point(136, 374);
            this.labelCompScore.Name = "labelCompScore";
            this.labelCompScore.Size = new System.Drawing.Size(83, 13);
            this.labelCompScore.TabIndex = 7;
            this.labelCompScore.Text = "Computer Score";
            // 
            // labelTie
            // 
            this.labelTie.AutoSize = true;
            this.labelTie.Location = new System.Drawing.Point(136, 400);
            this.labelTie.Name = "labelTie";
            this.labelTie.Size = new System.Drawing.Size(53, 13);
            this.labelTie.TabIndex = 8;
            this.labelTie.Text = "Tie Score";
            // 
            // textYourScore
            // 
            this.textYourScore.Location = new System.Drawing.Point(225, 345);
            this.textYourScore.Name = "textYourScore";
            this.textYourScore.ReadOnly = true;
            this.textYourScore.Size = new System.Drawing.Size(62, 20);
            this.textYourScore.TabIndex = 9;
            this.textYourScore.TabStop = false;
            this.textYourScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCompScore
            // 
            this.textCompScore.Location = new System.Drawing.Point(225, 371);
            this.textCompScore.Name = "textCompScore";
            this.textCompScore.ReadOnly = true;
            this.textCompScore.Size = new System.Drawing.Size(62, 20);
            this.textCompScore.TabIndex = 10;
            this.textCompScore.TabStop = false;
            this.textCompScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTieScore
            // 
            this.textTieScore.Location = new System.Drawing.Point(225, 397);
            this.textTieScore.Name = "textTieScore";
            this.textTieScore.ReadOnly = true;
            this.textTieScore.Size = new System.Drawing.Size(62, 20);
            this.textTieScore.TabIndex = 11;
            this.textTieScore.TabStop = false;
            this.textTieScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGamesPlayed
            // 
            this.labelGamesPlayed.AutoSize = true;
            this.labelGamesPlayed.Location = new System.Drawing.Point(136, 426);
            this.labelGamesPlayed.Name = "labelGamesPlayed";
            this.labelGamesPlayed.Size = new System.Drawing.Size(75, 13);
            this.labelGamesPlayed.TabIndex = 12;
            this.labelGamesPlayed.Text = "Games Played";
            // 
            // textGamesPlayed
            // 
            this.textGamesPlayed.Location = new System.Drawing.Point(225, 423);
            this.textGamesPlayed.Name = "textGamesPlayed";
            this.textGamesPlayed.ReadOnly = true;
            this.textGamesPlayed.Size = new System.Drawing.Size(62, 20);
            this.textGamesPlayed.TabIndex = 13;
            this.textGamesPlayed.TabStop = false;
            this.textGamesPlayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureHuman
            // 
            this.pictureHuman.Location = new System.Drawing.Point(29, 186);
            this.pictureHuman.Name = "pictureHuman";
            this.pictureHuman.Size = new System.Drawing.Size(167, 118);
            this.pictureHuman.TabIndex = 14;
            this.pictureHuman.TabStop = false;
            // 
            // pictureComp
            // 
            this.pictureComp.Location = new System.Drawing.Point(227, 186);
            this.pictureComp.Name = "pictureComp";
            this.pictureComp.Size = new System.Drawing.Size(167, 118);
            this.pictureComp.TabIndex = 15;
            this.pictureComp.TabStop = false;
            // 
            // labelHumanChose
            // 
            this.labelHumanChose.AutoSize = true;
            this.labelHumanChose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumanChose.Location = new System.Drawing.Point(73, 152);
            this.labelHumanChose.Name = "labelHumanChose";
            this.labelHumanChose.Size = new System.Drawing.Size(79, 17);
            this.labelHumanChose.TabIndex = 16;
            this.labelHumanChose.Text = "You chose:";
            // 
            // labelComputerChose
            // 
            this.labelComputerChose.AutoSize = true;
            this.labelComputerChose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerChose.Location = new System.Drawing.Point(253, 152);
            this.labelComputerChose.Name = "labelComputerChose";
            this.labelComputerChose.Size = new System.Drawing.Size(115, 17);
            this.labelComputerChose.TabIndex = 17;
            this.labelComputerChose.Text = "Computer chose:";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.labelComputerChose);
            this.Controls.Add(this.labelHumanChose);
            this.Controls.Add(this.pictureComp);
            this.Controls.Add(this.pictureHuman);
            this.Controls.Add(this.textGamesPlayed);
            this.Controls.Add(this.labelGamesPlayed);
            this.Controls.Add(this.textTieScore);
            this.Controls.Add(this.textCompScore);
            this.Controls.Add(this.textYourScore);
            this.Controls.Add(this.labelTie);
            this.Controls.Add(this.labelCompScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelChoiceComp);
            this.Controls.Add(this.labelChoice);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Label labelChoice;
        private System.Windows.Forms.Label labelChoiceComp;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelCompScore;
        private System.Windows.Forms.Label labelTie;
        private System.Windows.Forms.TextBox textYourScore;
        private System.Windows.Forms.TextBox textCompScore;
        private System.Windows.Forms.TextBox textTieScore;
        private System.Windows.Forms.Label labelGamesPlayed;
        private System.Windows.Forms.TextBox textGamesPlayed;
        private System.Windows.Forms.PictureBox pictureHuman;
        private System.Windows.Forms.PictureBox pictureComp;
        private System.Windows.Forms.Label labelHumanChose;
        private System.Windows.Forms.Label labelComputerChose;
    }
}

