/*
# Name:Luke Elmore
# email:elmorels@mail.uc.edu
# Assignment Title: Final Project
# Due Date:12/10/2024
# Course: IS 3050
# Semester/Year:fall 2024
# Brief Description: This Calculator takes a basic problem and solves it
# Citations: Stacked overflow, ChatGPT for code for Calc solver,InClass_2024_11_19_IS3050_001
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Falcons_FinalProject
{
    public class elmorels
    {
        /// <summary>
        /// Takes a math problem in a string and adds them up 
        /// </summary>
        /// <param name="s">put 2 numbers in </param>
        /// <returns>The answer of math problem</returns>
        public int Calculate(string s)
        {
            // Stack to store the results and signs
            Stack<int> stack = new Stack<int>();
            int currentNumber = 0;
            int result = 0;
            int sign = 1; // 1 for positive, -1 for negative

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsDigit(c)) // If the character is a digit
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }

                if (c == '+' || c == '-' || c == '(' || c == ')' || i == s.Length - 1)
                {
                    if (c == '+' || c == '-')
                    {
                        result += sign * currentNumber;
                        currentNumber = 0;
                        sign = (c == '+') ? 1 : -1;
                    }

                    if (c == '(')
                    {
                        stack.Push(result);
                        stack.Push(sign);
                        result = 0;
                        sign = 1; // Default sign when a new sub-expression starts
                    }

                    if (c == ')')
                    {
                        result += sign * currentNumber;
                        currentNumber = 0;
                        result *= stack.Pop(); // Multiply with the sign before the parentheses
                        result += stack.Pop(); // Add the result before the parentheses
                    }
                }
            }

            result += sign * currentNumber; // Add the last number
            return result;
        }

    }       
}