namespace GuessAWord
{
    partial class GuessWord
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
            this.hiddenWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textGuess = new System.Windows.Forms.TextBox();
            this.numTries = new System.Windows.Forms.TextBox();
            this.textLettersUsed = new System.Windows.Forms.TextBox();
            this.submitGuess = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.statusMsg = new System.Windows.Forms.Label();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hiddenWord
            // 
            this.hiddenWord.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenWord.Location = new System.Drawing.Point(149, 18);
            this.hiddenWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiddenWord.Name = "hiddenWord";
            this.hiddenWord.Size = new System.Drawing.Size(207, 24);
            this.hiddenWord.TabIndex = 0;
            this.hiddenWord.Text = "Hidden Word";
            this.hiddenWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess a letter: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of tries:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Letters used:";
            // 
            // textGuess
            // 
            this.textGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGuess.Location = new System.Drawing.Point(198, 87);
            this.textGuess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textGuess.Name = "textGuess";
            this.textGuess.Size = new System.Drawing.Size(76, 29);
            this.textGuess.TabIndex = 4;
            // 
            // numTries
            // 
            this.numTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTries.Location = new System.Drawing.Point(198, 136);
            this.numTries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numTries.Name = "numTries";
            this.numTries.ReadOnly = true;
            this.numTries.Size = new System.Drawing.Size(76, 29);
            this.numTries.TabIndex = 5;
            this.numTries.TabStop = false;
            // 
            // textLettersUsed
            // 
            this.textLettersUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLettersUsed.Location = new System.Drawing.Point(26, 218);
            this.textLettersUsed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLettersUsed.Multiline = true;
            this.textLettersUsed.Name = "textLettersUsed";
            this.textLettersUsed.ReadOnly = true;
            this.textLettersUsed.Size = new System.Drawing.Size(450, 57);
            this.textLettersUsed.TabIndex = 6;
            this.textLettersUsed.TabStop = false;
            this.textLettersUsed.Text = "abcde";
            // 
            // submitGuess
            // 
            this.submitGuess.AutoSize = true;
            this.submitGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitGuess.Location = new System.Drawing.Point(312, 87);
            this.submitGuess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitGuess.Name = "submitGuess";
            this.submitGuess.Size = new System.Drawing.Size(79, 34);
            this.submitGuess.TabIndex = 7;
            this.submitGuess.Text = "Guess!";
            this.submitGuess.UseVisualStyleBackColor = true;
            this.submitGuess.Click += new System.EventHandler(this.SubmitGuess_Click);
            // 
            // playAgain
            // 
            this.playAgain.AutoSize = true;
            this.playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(26, 289);
            this.playAgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(114, 34);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "Play Again!";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // statusMsg
            // 
            this.statusMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMsg.Location = new System.Drawing.Point(49, 51);
            this.statusMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Size = new System.Drawing.Size(390, 36);
            this.statusMsg.TabIndex = 9;
            this.statusMsg.Text = "status";
            this.statusMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(312, 148);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(93, 17);
            this.chkSound.TabIndex = 11;
            this.chkSound.Text = "Sound Effects";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(321, 294);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 29);
            this.txtName.TabIndex = 13;
            this.txtName.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Player Name:";
            // 
            // GuessWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(506, 338);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkSound);
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.submitGuess);
            this.Controls.Add(this.textLettersUsed);
            this.Controls.Add(this.numTries);
            this.Controls.Add(this.textGuess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hiddenWord);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GuessWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess A Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuessWord_FormClosing);
            this.Load += new System.EventHandler(this.GuessWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hiddenWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGuess;
        private System.Windows.Forms.TextBox numTries;
        private System.Windows.Forms.TextBox textLettersUsed;
        private System.Windows.Forms.Button submitGuess;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label statusMsg;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
    }
}

