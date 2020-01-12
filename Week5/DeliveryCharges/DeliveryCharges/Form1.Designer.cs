namespace DeliveryCharges
{
    partial class DeliveryCharges
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtDeliveryFees = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "We deliver to the following zip codes:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "56201, 56202, 56303, 56404, 56505, 56606, 56707, 56808, 56909, 56101";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(116, 146);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(242, 17);
            this.lblZip.TabIndex = 2;
            this.lblZip.Text = "Submit zipcode to check delivery fee:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(148, 195);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 22);
            this.txtZip.TabIndex = 3;
            // 
            // txtDeliveryFees
            // 
            this.txtDeliveryFees.Location = new System.Drawing.Point(38, 254);
            this.txtDeliveryFees.Name = "txtDeliveryFees";
            this.txtDeliveryFees.ReadOnly = true;
            this.txtDeliveryFees.Size = new System.Drawing.Size(419, 22);
            this.txtDeliveryFees.TabIndex = 4;
            this.txtDeliveryFees.TabStop = false;
            this.txtDeliveryFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(254, 195);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // DeliveryCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 344);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDeliveryFees);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeliveryCharges";
            this.Text = "Delivery Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtDeliveryFees;
        private System.Windows.Forms.Button btnSubmit;
    }
}

