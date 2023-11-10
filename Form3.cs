using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Performance_Windows_Chart
{
    public partial class Sudoku : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroButton[,] sudokuButtons;
        public Sudoku()
        {
            InitializeComponent();
            // Initialize the 2D array
            sudokuButtons = new MetroFramework.Controls.MetroButton[9, 9]
            {
                {A1, A2, A3, A4, A5, A6, A7, A8, A9},
                {B1, B2, B3, B4, B5, B6, B7, B8, B9},
                {C1, C2, C3, C4, C5, C6, C7, C8, C9},
                {D1, D2, D3, D4, D5, D6, D7, D8, D9},
                {E1, E2, E3, E4, E5, E6, E7, E8, E9},
                {F1, F2, F3, F4, F5, F6, F7, F8, F9},
                {G1, G2, G3, G4, G5, G6, G7, G8, G9},
                {H1, H2, H3, H4, H5, H6, H7, H8, H9},
                {I1, I2, I3, I4, I5, I6, I7, I8, I9}
            };

            // Attach the drag-and-drop event handlers into 9x9 grid
            foreach (var button in sudokuButtons)
            {
                button.MouseDown += SudokuButton_MouseDown;
                button.AllowDrop = true;
                button.DragEnter += SudokuButton_DragEnter;
                button.DragDrop += SudokuButton_DragDrop;
            }
        }

        /// <summary>
        /// The following methods handle drag-and-drop functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SudokuButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Start the drag-and-drop operation
                DoDragDrop(sender, DragDropEffects.Move);
            }
        }

        private void SudokuButton_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data is a MetroButton
            if (e.Data.GetDataPresent(typeof(MetroFramework.Controls.MetroButton)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void SudokuButton_DragDrop(object sender, DragEventArgs e)
        {
            // Get the dragged button
            MetroFramework.Controls.MetroButton draggedButton = (MetroFramework.Controls.MetroButton)e.Data.GetData(typeof(MetroFramework.Controls.MetroButton));

            // Get the destination button
            MetroFramework.Controls.MetroButton destinationButton = (MetroFramework.Controls.MetroButton)sender;

            // Swap the text (numbers) between the dragged and destination buttons
            string tempText = destinationButton.Text;
            destinationButton.Text = draggedButton.Text;
            draggedButton.Text = tempText;
        }
    }
}
