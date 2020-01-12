using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using static System.Console;
using System.Windows.Forms;

namespace GradeAverages
{
    public partial class FrmMain : Form
    {

        int[] grades1 = { 89, 65, 34, 99, 100, 76, 88 };
        int[] grades2 = { 85, 99, 87, 76, 84 };
        int[] grades3 = { 89, 93, 79, 85, 93, 91, 82, 81, 94, 95 };
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {


            


        }

        private void Generate_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("grades1 is: " + GradeComputations.PrintArray(grades2));
            txtOutput.AppendText("\r\ngrades2 is: " + GradeComputations.PrintArray(grades2));
            txtOutput.AppendText("\r\ngrades3 is: " + GradeComputations.PrintArray(grades3));
            txtOutput.AppendText("\r\n");

            txtOutput.AppendText("\r\ngrades1 sum: " + GradeComputations.FindSum(grades1));
            txtOutput.AppendText("\r\ngrades2 sum: " + GradeComputations.FindSum(grades2));
            txtOutput.AppendText("\r\ngrades3 sum: " + GradeComputations.FindSum(grades3));
            txtOutput.AppendText("\r\n");

            txtOutput.AppendText("\r\ngrades1 average: " + string.Format("{0:F2}", GradeComputations.FindAverage(grades1)));
            txtOutput.AppendText("\r\ngrades2 average: " + string.Format("{0:F2}", GradeComputations.FindAverage(grades2)));
            txtOutput.AppendText("\r\ngrades3 average: " + string.Format("{0:F2}", GradeComputations.FindAverage(grades3)));


            WriteLine();
        }
    }
}
