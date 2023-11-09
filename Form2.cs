using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Computer_Performance_Windows_Chart
{
    public partial class TicTacToe : MetroFramework.Forms.MetroForm
    {
        //global variables
        bool player = true;     //true = X, false = O
        int count = 0;          //counter for # of turns

        public TicTacToe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// function responsible for resetting game when there is a draw, or one of the players win
        /// </summary>
        private void reset()
        {
            player = true;
            count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";   //clears each button
                }
                catch { }

            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("First player to fill 3 boxes in a row, column, or diagonal with X or O wins!");
        }

        /// <summary>
        /// If Exit is clicked in the Tic Tac Toe application, you will be prompted before you exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            string message = "Are you sure you want to quit?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if(result == DialogResult.Yes)
            {
                this.Close();                 //exits application upon clicking yes.
            }
        }

        /// <summary>
        /// function that handles the event of clicking on the 9 buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; //casts the sender object into a button
            if(player)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            player = !player;   //switches the turn
            b.Enabled = false;
            count++;

           check_winner(); //see if there is a winner
        }
        #region 
        private void check_winner()
        {
            bool winner = false;   //no winner yet

            //horizontal check for wins
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            if (C1.Text == C2.Text && C2.Text == C3.Text && (!C1.Enabled))
                winner = true;
            //vertical check for wins
            if (A1.Text == B1.Text && B1.Text == C1.Text && (!A1.Enabled))
                winner = true;
            if (A2.Text == B2.Text && B2.Text == C2.Text && (!A2.Enabled))
                winner = true;
            if (A3.Text == B3.Text && B3.Text == C3.Text && (!A3.Enabled))
                winner = true;
            //diagonal check for wins
            if (A1.Text == B2.Text && B2.Text == C3.Text && (!A1.Enabled))
                winner = true;
            if (C1.Text == B2.Text && B2.Text == A3.Text && (!C1.Enabled))
                winner = true;


            if (winner)
            {
                disableAll();   //can no longer edit buttons
                String player_winner = "";

                if (player) {
                    player_winner = player2_label.Text;
                    O_Count.Text = ((Int32.Parse(O_Count.Text) + 1).ToString());
                }

                else
                {
                    player_winner = player1_label.Text;
                    X_Count.Text = ((Int32.Parse(X_Count.Text) + 1).ToString());
                }
                    
                SystemSounds.Asterisk.Play();
                MessageBox.Show(player_winner + " Wins!", "Congratulations!");
                reset();
            }
            else
            {
                if(count == 9) //maximum # of turns is 9
                {
                    SystemSounds.Asterisk.Play();
                    Draw_Count.Text = ((Int32.Parse(Draw_Count.Text) + 1).ToString());
                    MessageBox.Show("It's a Draw!", "Too Bad!");
                    reset();
                }
            }
        }
        #endregion
        private void disableAll()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;      //disables all buttons when winner is reached
                }
            }
            catch { }
            
        }
        /// <summary>
        /// function called when a new game is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = true;
            count = 0;
                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";   //clears each button
                    }
                catch { }
                    
                }
        }
        /// <summary>
        /// function that handles event of entering each button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouse_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender; //casts the sender object into a button
            if(b.Enabled) {
                if (player)
                    b.Text = "X";

                else
                    b.Text = "O";
            }
        }

        /// <summary>
        /// function to handle event for leaving each button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouse_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender; //casts the sender object into a button
            if (b.Enabled)
            {
                b.Text = "";
            }
        }


        /// <summary>
        /// function resets all counters to 0 when reset event occurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_Count.Text = "0";
            X_Count.Text = "0";
            Draw_Count.Text = "0";
        }
    }
}
