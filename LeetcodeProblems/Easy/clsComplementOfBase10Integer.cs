using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1009. Complement of Base 10 Integer
     * The complement of an integer is the integer you get when you flip all the 0's to 1's and all the 1's to 0's in its binary representation.

        For example, The integer 5 is "101" in binary and its complement is "010" which is the integer 2.
        Given an integer n, return its complement.

        Example 1:
        Input: n = 5
        Output: 2
        Explanation: 5 is "101" in binary, with complement "010" in binary, which is 2 in base-10.

        Example 2:
        Input: n = 7
        Output: 0
        Explanation: 7 is "111" in binary, with complement "000" in binary, which is 0 in base-10.

        Example 3:
        Input: n = 10
        Output: 5
        Explanation: 10 is "1010" in binary, with complement "0101" in binary, which is 5 in base-10.
 
        Constraints:
        0 <= n < 109

        Note: This question is the same as 476: https://leetcode.com/problems/number-complement/
    */
    public class clsComplementOfBase10Integer
    {
        public int BitwiseComplement(int n)
        {
            if (n == 0)
                return 1;
            int num = 0;
            int power = 0;
            while (n != 0)
            {
                if ((n & 1) == 0)
                    num += (int)Math.Pow(2, power);
                power++;
                n >>= 1;
            }
            return num;
        }
    }
}
