using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*69. Sqrt(x)
     *** REF ***
     *** VERY IMP ***
     *https://leetcode.com/problems/sqrtx/discuss/25198/3-JAVA-solutions-with-explanation
     * Given a non-negative integer x, compute and return the square root of x.

        Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.

        Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.

        Example 1:
        Input: x = 4
        Output: 2

        Example 2:
        Input: x = 8
        Output: 2
        Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
 
        Constraints:
        0 <= x <= 231 - 1
    */
    public class clsSqrt_x_
    {
        public int MySqrt(int x)
        {
            if (x == 0)
                return 0;
            int left = 1;
            int right = x;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (mid <= x / mid && (mid + 1) > x / (mid + 1))
                    return mid;
                else if (mid > x / mid)
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }
    }
}
