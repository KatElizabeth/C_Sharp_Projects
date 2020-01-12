namespace CountVowels
{
    partial class CountVowels
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.labelVowelCount = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textFinalCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(12, 25);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(341, 48);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Enter some text. I will count the vowels! Y is not a vowel. All upper and lower c" +
    "ase are counted.";
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.Location = new System.Drawing.Point(16, 89);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(337, 156);
            this.textInput.TabIndex = 1;
            this.textInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // labelVowelCount
            // 
            this.labelVowelCount.AutoSize = true;
            this.labelVowelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVowelCount.Location = new System.Drawing.Point(154, 279);
            this.labelVowelCount.Name = "labelVowelCount";
            this.labelVowelCount.Size = new System.Drawing.Size(100, 17);
            this.labelVowelCount.TabIndex = 2;
            this.labelVowelCount.Text = "Vowels Found:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(59, 268);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 38);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit!";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // textFinalCount
            // 
            this.textFinalCount.Location = new System.Drawing.Point(260, 276);
            this.textFinalCount.Name = "textFinalCount";
            this.textFinalCount.ReadOnly = true;
            this.textFinalCount.Size = new System.Drawing.Size(56, 20);
            this.textFinalCount.TabIndex = 5;
            // 
            // CountVowels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 347);
            this.Controls.Add(this.textFinalCount);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelVowelCount);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.labelInstructions);
            this.Name = "CountVowels";
            this.Text = "Count Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label labelVowelCount;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textFinalCount;
    }
}

