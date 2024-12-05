using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Falcons_FinalProject 
{
    /// <summary>
    /// Determines if the string `s` matches the pattern `p` which can contain '?' and '*'.
    /// '?' matches any single character, and '*' matches any sequence of characters (including empty).
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <param name="p">The pattern string containing wildcard characters '?' and '*'.</param>
    /// <returns>True if the string matches the pattern, otherwise false.</returns>
    public class happelrc
    {
        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;

            // dp[i][j] will be true if the first i characters of s match the first j characters of p
            bool[,] dp = new bool[m + 1, n + 1];

            // Base case: empty pattern matches empty string
            dp[0, 0] = true;

            // Handle the case where pattern starts with '*' characters
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 1];
                }
            }

            // Fill the dp table
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == s[i - 1] || p[j - 1] == '?')
                    {
                        // If characters match, or there's a '?' wildcard, take the value from dp[i-1][j-1]
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        // If there's a '*', two possibilities:
                        // 1. '*' matches an empty sequence, so dp[i][j-1]
                        // 2. '*' matches one or more characters, so dp[i-1][j]
                        dp[i, j] = dp[i, j - 1] || dp[i - 1, j];
                    }
                }
            }

            // The result is stored in dp[m][n]
            return dp[m, n];
        }
    }
}
