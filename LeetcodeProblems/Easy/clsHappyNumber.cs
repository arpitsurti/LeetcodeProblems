using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /* 202. Happy Number
     * Write an algorithm to determine if a number n is happy.

        A happy number is a number defined by the following process:

        Starting with any positive integer, replace the number by the sum of the squares of its digits.
        Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        Those numbers for which this process ends in 1 are happy.
        Return true if n is a happy number, and false if not.

        Example 1:
        Input: n = 19
        Output: true
        Explanation:
        12 + 92 = 82
        82 + 22 = 68
        62 + 82 = 100
        12 + 02 + 02 = 1
        
        Example 2:
        Input: n = 2
        Output: false

        Constraints:
        1 <= n <= 231 - 1
     */
    public class clsHappyNumber
    {
        public bool IsHappy(int n)
        {
            HashSet<int> hs = new HashSet<int>();
            while (n != 1)
            {
                int current = n;
                int sum = 0;
                while (current != 0)
                {
                    sum += (current % 10) * (current % 10);
                    current /= 10;
                }
                if (hs.Contains(sum))
                    return false;
                hs.Add(sum);
                n = sum;
            }
            return true;
        }
    }
}
