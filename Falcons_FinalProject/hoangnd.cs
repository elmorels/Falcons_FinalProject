
/*
# Name:Nate Hoang
# email:hoangnd@mail.uc.edu
# Assignment Title: Final Project
# Due Date:12/10/2024
# Course: IS 3050
# Semester/Year:fall 2024
# Brief Description: 
# Citations:
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Falcons_FinalProject
{
    public class hoangnd
    {

        /// <summary>
        /// Checks if it's valid to place the number 'num' at the given row and column in the Sudoku board.
        /// </summary>
        /// <param name="board">The 2D character array representing the Sudoku board.</param>
        /// <param name="row">The row index where the number is to be placed.</param>
        /// <param name="col">The column index where the number is to be placed.</param>
        /// <param name="num">The number to be checked for placement.</param>
        /// <returns>True if the number can be placed at the specified location, otherwise false.</returns>

        public static bool IsValid(char[,] board, int row, int col, char num)
        {
            // Check if num is in the row
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == num)
                {
                    return false;
                }
            }

            // Check if num is in the column
            for (int i = 0; i < 9; i++)
            {
                if (board[i, col] == num)
                {
                    return false;
                }
            }

            // Check if num is in the 3x3 subgrid
            int startRow = row / 3 * 3;
            int startCol = col / 3 * 3;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (board[i, j] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Function to solve the Sudoku puzzle
        public static bool SolveSudoku(char[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // If the cell is empty
                    if (board[row, col] == '.')
                    {
                        // Try placing numbers 1 to 9
                        for (char num = '1'; num <= '9'; num++)
                        {
                            if (IsValid(board, row, col, num))
                            {
                                // Place the number and recurse to solve the rest
                                board[row, col] = num;

                                // If placing num leads to a solution, return true
                                if (SolveSudoku(board))
                                {
                                    return true;
                                }

                                // Backtrack if placing num doesn't lead to a solution
                                board[row, col] = '.';
                            }
                        }

                        // If no number is valid, return false to backtrack
                        return false;
                    }
                }
            }

            // All cells are filled correctly, puzzle solved
            return true;
        }

        // Helper function to print the board
        public static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            // Example Sudoku board (0 represents empty cells)
            char[,] board = {
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

            // Solve the Sudoku
            SolveSudoku(board);

            // Print the solved board
            Console.WriteLine("Solved Sudoku:");
            PrintBoard(board);
        }
    }
}
