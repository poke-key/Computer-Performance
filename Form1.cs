using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Computer_Performance_Windows_Chart
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to close the window when Exit is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {this.Close();}

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("This application displays your machines CPU load and available memory.\nThere are also classic games you can play if you are bored.");
        }

        /// <summary>
        /// This function retrieves the data from CPU and RAM and displays it in the progress bar and the percentage label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            float cpuVal = perfCpuCount.NextValue();
            float memVal = perfMemCount.NextValue();

            progressBarCPU.Value = (int)cpuVal;
            progressBarRAM.Value = (int)memVal;

            pcntCPU.Text = string.Format("{0:0.00}%", cpuVal);
            pcntRAM.Text = string.Format("{0:0.00}%", memVal);

            chart1.Series["CPU"].Points.AddY(cpuVal);   //adds data stored in cpuVal to the CPU Series
            chart1.Series["RAM"].Points.AddY(memVal);   //adds data stored in memVal to the RAM series
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("This application was designed by Kunal Shrivastav(a.k.a) THE RIZZ GOD!");
        }

        /// <summary>
        /// function for the event of user clicking Games->Tic Tac Toe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ticTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTacToe tictac = new TicTacToe();

            tictac.Show();
        }

        private void sudokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            string message = "Welcome to Sudoku! \n\n Selct Yes to play.";
            string title = "Play";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Sudoku sudoku = new Sudoku();               //instance of Sudoku Form
                sudoku.Show();                              //runs application
            }
        }
    }
}
