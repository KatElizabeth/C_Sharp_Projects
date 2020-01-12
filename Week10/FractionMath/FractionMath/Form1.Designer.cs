namespace FractionMath
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.den1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.den2 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBlah = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.denResult = new System.Windows.Forms.TextBox();
            this.numResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtWhole1 = new System.Windows.Forms.TextBox();
            this.txtWhole2 = new System.Windows.Forms.TextBox();
            this.txtWholeResult = new System.Windows.Forms.TextBox();
            this.labelFraction1 = new System.Windows.Forms.Label();
            this.labelFraction2 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(164, 117);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(63, 29);
            this.num1.TabIndex = 1;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num1.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // den1
            // 
            this.den1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den1.Location = new System.Drawing.Point(164, 174);
            this.den1.Name = "den1";
            this.den1.Size = new System.Drawing.Size(63, 29);
            this.den1.TabIndex = 2;
            this.den1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.den1.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(243, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(243, 134);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(32, 28);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(243, 168);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(32, 28);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(243, 202);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(32, 28);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(158, 148);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(79, 23);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "__________";
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(345, 148);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(79, 23);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "__________";
            // 
            // den2
            // 
            this.den2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den2.Location = new System.Drawing.Point(351, 174);
            this.den2.Name = "den2";
            this.den2.Size = new System.Drawing.Size(63, 29);
            this.den2.TabIndex = 6;
            this.den2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.den2.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(351, 117);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(63, 29);
            this.num2.TabIndex = 5;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num2.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(275, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 26);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "The Fractionator!";
            // 
            // lblBlah
            // 
            this.lblBlah.AutoSize = true;
            this.lblBlah.Location = new System.Drawing.Point(226, 57);
            this.lblBlah.Name = "lblBlah";
            this.lblBlah.Size = new System.Drawing.Size(272, 16);
            this.lblBlah.TabIndex = 11;
            this.lblBlah.Text = "Fraction math is dangerous, don\'t go it alone.";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(430, 134);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(23, 56);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "=";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.Location = new System.Drawing.Point(526, 148);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(79, 23);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "__________";
            // 
            // denResult
            // 
            this.denResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denResult.Location = new System.Drawing.Point(534, 174);
            this.denResult.Name = "denResult";
            this.denResult.ReadOnly = true;
            this.denResult.Size = new System.Drawing.Size(63, 29);
            this.denResult.TabIndex = 14;
            this.denResult.TabStop = false;
            this.denResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numResult
            // 
            this.numResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResult.Location = new System.Drawing.Point(534, 117);
            this.numResult.Name = "numResult";
            this.numResult.ReadOnly = true;
            this.numResult.Size = new System.Drawing.Size(63, 29);
            this.numResult.TabIndex = 13;
            this.numResult.TabStop = false;
            this.numResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(519, 214);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(86, 16);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "fraction result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWhole1
            // 
            this.txtWhole1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhole1.Location = new System.Drawing.Point(95, 146);
            this.txtWhole1.Name = "txtWhole1";
            this.txtWhole1.Size = new System.Drawing.Size(63, 29);
            this.txtWhole1.TabIndex = 0;
            this.txtWhole1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWhole2
            // 
            this.txtWhole2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhole2.Location = new System.Drawing.Point(282, 146);
            this.txtWhole2.Name = "txtWhole2";
            this.txtWhole2.Size = new System.Drawing.Size(63, 29);
            this.txtWhole2.TabIndex = 4;
            this.txtWhole2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWholeResult
            // 
            this.txtWholeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWholeResult.Location = new System.Drawing.Point(457, 148);
            this.txtWholeResult.Name = "txtWholeResult";
            this.txtWholeResult.ReadOnly = true;
            this.txtWholeResult.Size = new System.Drawing.Size(63, 29);
            this.txtWholeResult.TabIndex = 19;
            this.txtWholeResult.TabStop = false;
            this.txtWholeResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFraction1
            // 
            this.labelFraction1.AutoSize = true;
            this.labelFraction1.Location = new System.Drawing.Point(116, 214);
            this.labelFraction1.Name = "labelFraction1";
            this.labelFraction1.Size = new System.Drawing.Size(86, 16);
            this.labelFraction1.TabIndex = 20;
            this.labelFraction1.Text = "fraction result";
            this.labelFraction1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFraction2
            // 
            this.labelFraction2.AutoSize = true;
            this.labelFraction2.Location = new System.Drawing.Point(343, 214);
            this.labelFraction2.Name = "labelFraction2";
            this.labelFraction2.Size = new System.Drawing.Size(86, 16);
            this.labelFraction2.TabIndex = 21;
            this.labelFraction2.Text = "fraction result";
            this.labelFraction2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResults
            // 
            this.labelResults.Location = new System.Drawing.Point(154, 307);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(412, 73);
            this.labelResults.TabIndex = 22;
            this.labelResults.Text = "Enter an integer into each box.";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(721, 425);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelFraction2);
            this.Controls.Add(this.labelFraction1);
            this.Controls.Add(this.txtWholeResult);
            this.Controls.Add(this.txtWhole2);
            this.Controls.Add(this.txtWhole1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.denResult);
            this.Controls.Add(this.numResult);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblBlah);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.den2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.den1);
            this.Controls.Add(this.num1);
            this.Name = "FormMain";
            this.Text = "Fraction Math";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox den1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox den2;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBlah;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox denResult;
        private System.Windows.Forms.TextBox numResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtWhole1;
        private System.Windows.Forms.TextBox txtWhole2;
        private System.Windows.Forms.TextBox txtWholeResult;
        private System.Windows.Forms.Label labelFraction1;
        private System.Windows.Forms.Label labelFraction2;
        private System.Windows.Forms.Label labelResults;
    }
}

