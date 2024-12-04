/*
# Name:Luke Elmore,Nate Hoang
# email:elmorels@mail.uc.edu,hoangnd@mail.uc.edu
# Assignment Title: Final Project
# Due Date:12/10/2024
# Course: IS 3050
# Semester/Year:fall 2024
# Brief Description: This takes the problems for each of the different classes and once the 
user picks which problem they want solved they click the button and it will solve the problem
# Citations: Stacked overflow,InClass_2024_11_19_IS3050_001
*/
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Falcons_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cdmClickForAnswer_Click(object sender, EventArgs e)
        {
            elmorels calculate = new elmorels();
            hoangnd Sudoku1 = new hoangnd();
            string SolutionSelector = ddlSolutionSelector.SelectedValue;
            string BasicCalc = "Basic Calculator";
            string Sudoku = "Sudoku Solver";
            string Other = "Other";

            if (SolutionSelector == BasicCalc)
            {
                int number = calculate.Calculate("2+1");
                lblShowSolution.Text = "The Basic Calculator added up 2+1 which equals " + number.ToString();
            }
            else if (SolutionSelector == Sudoku)
            {


                char[,] board = new char[9, 9] {
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


                hoangnd.SolveSudoku(board);
                string solvedBoardHtml = hoangnd.PrintBoard(board);
                lblShowSolution.Text = "Sudoku solution solves a Sudoku puzzle: " + solvedBoardHtml;
            }
            else if(SolutionSelector == Other) 
            {
                lblShowSolution.Text ="Other";
            }

        }
    }
}