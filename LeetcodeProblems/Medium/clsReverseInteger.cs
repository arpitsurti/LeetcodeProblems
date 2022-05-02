using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*7. Reverse Integer
     *** REF ***
     * Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

        Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

        Example 1:
        Input: x = 123
        Output: 321

        Example 2:
        Input: x = -123
        Output: -321

        Example 3:
        Input: x = 120
        Output: 21
 
        Constraints:
        -231 <= x <= 231 - 1
    */
    public class clsReverseInteger
    {
        public int Reverse(int x)
        {
            long output = 0;
            bool flgNegative = false;
            if (x < 0)
            {
                if (x == int.MinValue)
                    return 0;
                x = Math.Abs(x);
                flgNegative = true;
            }
            while (x > 0)
            {
                output = output * 10 + x % 10;
                x /= 10;
            }
            if (output > int.MaxValue)
                return 0;
            return flgNegative ? (int)(output * -1) : (int)output;
        }
    }
}
