namespace Guess100
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
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelYourGuess = new System.Windows.Forms.Label();
            this.textGuess = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textNumOfTries = new System.Windows.Forms.TextBox();
            this.labelTries = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.cheatText = new System.Windows.Forms.Label();
            this.buttonCheat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(71, 23);
            this.labelInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(388, 139);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "I\'m thinking of a number between 1 and 100  inclusive. Guess the number in the fe" +
    "west number of tries!";
            this.labelInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYourGuess
            // 
            this.labelYourGuess.AutoSize = true;
            this.labelYourGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourGuess.Location = new System.Drawing.Point(31, 178);
            this.labelYourGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYourGuess.Name = "labelYourGuess";
            this.labelYourGuess.Size = new System.Drawing.Size(121, 25);
            this.labelYourGuess.TabIndex = 1;
            this.labelYourGuess.Text = "Your Guess:";
            // 
            // textGuess
            // 
            this.textGuess.Location = new System.Drawing.Point(199, 178);
            this.textGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textGuess.Name = "textGuess";
            this.textGuess.Size = new System.Drawing.Size(99, 22);
            this.textGuess.TabIndex = 2;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(344, 166);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 50);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit Guess!";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // textNumOfTries
            // 
            this.textNumOfTries.Location = new System.Drawing.Point(183, 310);
            this.textNumOfTries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNumOfTries.Name = "textNumOfTries";
            this.textNumOfTries.ReadOnly = true;
            this.textNumOfTries.Size = new System.Drawing.Size(77, 22);
            this.textNumOfTries.TabIndex = 4;
            this.textNumOfTries.TabStop = false;
            // 
            // labelTries
            // 
            this.labelTries.AutoSize = true;
            this.labelTries.Location = new System.Drawing.Point(269, 314);
            this.labelTries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(63, 17);
            this.labelTries.TabIndex = 5;
            this.labelTries.Text = "# of tries";
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(16, 240);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(497, 28);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(215, 398);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 28);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset Game";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // cheatText
            // 
            this.cheatText.Location = new System.Drawing.Point(17, 430);
            this.cheatText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cheatText.Name = "cheatText";
            this.cheatText.Size = new System.Drawing.Size(483, 34);
            this.cheatText.TabIndex = 8;
            this.cheatText.Text = "...";
            this.cheatText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCheat
            // 
            this.buttonCheat.Location = new System.Drawing.Point(215, 362);
            this.buttonCheat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCheat.Name = "buttonCheat";
            this.buttonCheat.Size = new System.Drawing.Size(100, 28);
            this.buttonCheat.TabIndex = 9;
            this.buttonCheat.Text = "Cheat!";
            this.buttonCheat.UseVisualStyleBackColor = true;
            this.buttonCheat.Click += new System.EventHandler(this.ButtonCheat_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 464);
            this.Controls.Add(this.buttonCheat);
            this.Controls.Add(this.cheatText);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTries);
            this.Controls.Add(this.textNumOfTries);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textGuess);
            this.Controls.Add(this.labelYourGuess);
            this.Controls.Add(this.labelInstructions);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Kat\'s Guessing Game!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelYourGuess;
        private System.Windows.Forms.TextBox textGuess;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textNumOfTries;
        private System.Windows.Forms.Label labelTries;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label cheatText;
        private System.Windows.Forms.Button buttonCheat;
    }
}

