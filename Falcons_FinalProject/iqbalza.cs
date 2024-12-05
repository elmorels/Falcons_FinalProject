using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Falcons_FinalProject
{
    public class iqbalza
    {
        public iqbalza()
        {
            // This constructor will initialize the dp array with default size, which can be modified if needed
            dp = new int[1001, 1001];  // Arbitrary size of dp for large strings
        }

        // DP table to store subproblem results
        private int[,] dp;

        // Recursive function to solve the problem
        private int Solve(int currentInd, int currentTarIn, string s, string t)
        {
            // Base case: If we've matched all characters of t
            if (currentTarIn == t.Length)
            {
                return 1; // We found a valid subsequence
            }

            // Base case: If we've exhausted all characters of s
            if (currentInd == s.Length)
            {
                return 0; // We cannot match t completely
            }

            // If the result has been computed before, return it
            if (dp[currentInd, currentTarIn] != -1)
            {
                return dp[currentInd, currentTarIn];
            }

            // Option 1: Skip the current character of s
            int res1 = Solve(currentInd + 1, currentTarIn, s, t);

            // Option 2: If the characters match, include this character in the subsequence
            if (s[currentInd] == t[currentTarIn])
            {
                res1 += Solve(currentInd + 1, currentTarIn + 1, s, t);
            }

            // Store the result and return
            dp[currentInd, currentTarIn] = res1;
            return res1;
        }

        // Public method to start solving the problem
        public int NumDistinct(string s, string t)
        {
            // Initialize dp array with -1 (not computed state)
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = -1;
                }
            }

            return Solve(0, 0, s, t); // Start the recursive solution
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the iqbalza class
            iqbalza solver = new iqbalza();

            // Input strings
            string s = "rabbbit";
            string t = "rabbit";

            // Output the result
            Console.WriteLine("Number of distinct subsequences: " + solver.NumDistinct(s, t));
        }
    }
}
    
