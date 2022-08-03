using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1137. N-th Tribonacci Number
     * The Tribonacci sequence Tn is defined as follows: 

        T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.

        Given n, return the value of Tn.

        Example 1:
        Input: n = 4
        Output: 4
        Explanation:
        T_3 = 0 + 1 + 1 = 2
        T_4 = 1 + 1 + 2 = 4

        Example 2:
        Input: n = 25
        Output: 1389537

        Constraints:
        0 <= n <= 37
        The answer is guaranteed to fit within a 32-bit integer, ie. answer <= 2^31 - 1.
    */
    public class clsN_thTribonacciNumber
    {
        public int Tribonacci(int n)
        {
            if (n <= 1)
                return n;
            if (n == 2)
                return 1;
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = dp[2] = 1;
            for (int i = 3; i < n + 1; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
            }
            return dp[n];
        }

        /* USING RECURSION DYNAMIC PROGRAMMING APPROACH
        public int Tribonacci(int n) {
            int[] dp = new int[n + 4];
            return calcTrib(n, dp);
        }
    
        private int calcTrib(int n, int[] dp)
        {
            if(n <= 1)
            {
                dp[n] = n;
                return dp[n];
            }
            else if(n == 2)
            {
                dp[n] = 1;
                return dp[n];
            }   
            if(dp[n] != 0)
                return dp[n];
            return dp[n] = calcTrib(n - 1, dp) + calcTrib(n - 2, dp) + calcTrib(n - 3, dp);
        }
        */
    }
}
