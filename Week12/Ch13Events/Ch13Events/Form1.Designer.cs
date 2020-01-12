namespace Ch13Events
{
    partial class Form1
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblFormSize = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(30, 29);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(111, 44);
            this.btnGo.TabIndex = 0;
            this.btnGo.TabStop = false;
            this.btnGo.Text = "Go Here";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            this.btnGo.MouseLeave += new System.EventHandler(this.BtnGo_MouseLeave);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(44, 116);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Label One";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(44, 143);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Label Two";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(44, 171);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(64, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Label Three";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(44, 199);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(57, 13);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Label Four";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(44, 231);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(56, 13);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Label Five";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(45, 260);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(50, 13);
            this.lbl6.TabIndex = 6;
            this.lbl6.Text = "Label Six";
            // 
            // lblFormSize
            // 
            this.lblFormSize.AutoSize = true;
            this.lblFormSize.Location = new System.Drawing.Point(144, 116);
            this.lblFormSize.Name = "lblFormSize";
            this.lblFormSize.Size = new System.Drawing.Size(53, 13);
            this.lblFormSize.TabIndex = 7;
            this.lblFormSize.Text = "Form Size";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(147, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 44);
            this.btnStop.TabIndex = 8;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            this.btnStop.MouseEnter += new System.EventHandler(this.BtnStop_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 355);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblFormSize);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblFormSize;
        private System.Windows.Forms.Button btnStop;
    }
}

