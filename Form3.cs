using System;
using System.Windows.Forms;

namespace Computer_Performance_Windows_Chart
{
    public partial class Sudoku : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroButton[,] sudokuButtons;
        private Random random = new Random();

        public Sudoku()
        {
            InitializeComponent();
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

            foreach (var button in sudokuButtons)
            {
                button.MouseDown += SudokuButton_MouseDown;
                button.AllowDrop = true;
                button.DragEnter += SudokuButton_DragEnter;
                button.DragDrop += SudokuButton_DragDrop;
            }

            GenerateSudokuPuzzle();
        }

        private void GenerateSudokuPuzzle()
        {
            int[,] puzzle = new int[9, 9];

            // Fill the diagonal 3x3 grids
            for (int i = 0; i < 9; i += 3)
                FillGrid(i, i, puzzle);

            SolveSudoku(puzzle);

            // Copy the puzzle to the UI grid and hide some numbers
            HideNumbers(puzzle, 0.75); // Hiding 75% of the numbers

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int value = puzzle[row, col];
                    sudokuButtons[row, col].Text = value == 0 ? "" : value.ToString();
                    sudokuButtons[row, col].Enabled = value == 0;
                }
            }
        }
        private void HideNumbers(int[,] puzzle, double percentageToHide)
        {
            int totalCells = 9 * 9;
            int cellsToHide = (int)(percentageToHide * totalCells);
            int cellsHidden = 0;

            while (cellsHidden < cellsToHide)
            {
                int row = random.Next(9);
                int col = random.Next(9);

                if (puzzle[row, col] != 0)
                {
                    puzzle[row, col] = 0;
                    cellsHidden++;
                }
            }
        }

        private void FillGrid(int startRow, int startCol, int[,] puzzle)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int num;
                    do
                    {
                        num = random.Next(1, 10);
                    } while (!IsValidMove(startRow + i, startCol + j, num, puzzle));

                    puzzle[startRow + i, startCol + j] = num;
                }
            }
        }

        private bool IsValidMove(int row, int col, int value, int[,] puzzle)
        {
            // Check if the value is already present in the same row or column
            for (int i = 0; i < 9; i++)
            {
                if (puzzle[row, i] == value || puzzle[i, col] == value)
                {
                    return false;
                }
            }

            // Check if the value is already present in the same 3x3 grid
            int startRow = row - (row % 3);
            int startCol = col - (col % 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (puzzle[startRow + i, startCol + j] == value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void SolveSudoku(int[,] puzzle)
        {
            Solve(puzzle);
        }

        private bool Solve(int[,] puzzle)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (puzzle[row, col] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (IsValidMove(row, col, num, puzzle))
                            {
                                puzzle[row, col] = num;

                                if (Solve(puzzle))
                                    return true;

                                puzzle[row, col] = 0;
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        private void SudokuButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(sender, DragDropEffects.Move);
            }
        }

        private void SudokuButton_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(MetroFramework.Controls.MetroButton)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void SudokuButton_DragDrop(object sender, DragEventArgs e)
        {
            MetroFramework.Controls.MetroButton draggedButton = (MetroFramework.Controls.MetroButton)e.Data.GetData(typeof(MetroFramework.Controls.MetroButton));
            MetroFramework.Controls.MetroButton destinationButton = (MetroFramework.Controls.MetroButton)sender;

            string tempText = destinationButton.Text;
            destinationButton.Text = draggedButton.Text;
            draggedButton.Text = tempText;
        }
    }
}
