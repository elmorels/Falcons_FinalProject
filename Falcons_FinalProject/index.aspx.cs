/*
# Name:Luke Elmore,Nate Hoang,Ray Happel,Zoha Iqbal
# email:elmorels@mail.uc.edu,hoangnd@mail.uc.edu,happelrc@mail.uc.edu,iqbalza@mail.uc.edu
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

        protected void cmdClickForAnswer_Click(object sender, EventArgs e)
        {
            elmorels calculate = new elmorels();
            hoangnd Sudoku1 = new hoangnd();
            happelrc Wildcard = new happelrc();
            iqbalza Distinct = new iqbalza();
            string SolutionSelector = ddlSolutionSelector.SelectedValue;
            string BasicCalc = "Basic Calculator";
            string Sudoku = "Sudoku Solver";
            string WildcardMatching = "Wildcard Matching";
            string DistinctSubsequences = "Distinct Subsequences";

            if (SolutionSelector == BasicCalc)
            {
                int number = calculate.Calculate("2+1");
                lblShowDescription.Text = "Given a string s representing a valid expression, implement a basic calculator to evaluate it, and return the result of the evaluation.";
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
                lblShowDescription.Text = "Write a program to solve a Sudoku puzzle by filling the empty cells.";
                lblShowSolution.Text = "Sudoku solution solves a Sudoku puzzle: " + solvedBoardHtml;
            }
            else if (SolutionSelector == WildcardMatching)
            {

                string s = "aa";
                string p = "a";
                bool Wild = Wildcard.IsMatch(s, p);
                lblShowDescription.Text = "Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where:\r\n\r\n'?' Matches any single character.\r\n'*' Matches any sequence of characters (including the empty sequence).";
                lblShowSolution.Text = "The Wildcard Matching will try to see if the string match, String s is 'aa' and string p is 'a', Do these strings Match? " + Wild;
            }
            else if (SolutionSelector == DistinctSubsequences)
            {
                string s = "rabbbit";
                 string t = "rabbit";
                int num = Distinct.NumDistinct(s,t);

                lblShowDescription.Text = "Given two strings s and t, return the number of distinct subsequences of s which equals t.";
                lblShowSolution.Text = "s = rabbbit and t = rabbit and there are " + num + " ways you can generate \"rabbit\" from s. rabbbit\r\nrabbbit\r\nrabbbit";
            }

        }
    }
}