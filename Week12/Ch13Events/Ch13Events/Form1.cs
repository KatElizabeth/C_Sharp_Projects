using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch13Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Go button clicked.";
            lbl2.Text = sender.ToString();
            lbl3.Text = e.ToString();
        }

        private void BtnGo_MouseLeave(object sender, EventArgs e)
        {
            lbl1.Text = "Mouse left Go button.";

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y;
            x = e.X;
            y = e.Y;

            lbl4.Text = "x: " + x + " y: " + y;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            lbl5.Text = e.Button.ToString();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl6.Text = e.KeyChar.ToString();

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {

        }

        private void BtnStop_MouseEnter(object sender, EventArgs e)
        {
            //// 147, 29 original position

//            int yPos = btnStop.Location.Y;
//            btnStop.Location = new System.Drawing.Point(147, yPos + 50);

            int formXWidth = ClientSize.Width;
            int formYHeight = ClientSize.Height;

            lblFormSize.Text = formXWidth + "  " + formYHeight;

            Random random = new Random();
            int randomX = random.Next(10, formXWidth - 90);
            int randomY = random.Next(10, formYHeight - 50);

            btnStop.Location = new System.Drawing.Point(randomX, randomY);


        }
    }
}
