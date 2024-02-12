using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*693. Binary Number with Alternating Bits
     * Given a positive integer, check whether it has alternating bits: namely, if two adjacent bits will always have different values.

        Example 1:
        Input: n = 5
        Output: true
        Explanation: The binary representation of 5 is: 101

        Example 2:
        Input: n = 7
        Output: false
        Explanation: The binary representation of 7 is: 111.

        Example 3:
        Input: n = 11
        Output: false
        Explanation: The binary representation of 11 is: 1011.
 
        Constraints:
        1 <= n <= 231 - 1
    */
    public class clsBinaryNumberWithAlternatingBits
    {
        public bool HasAlternatingBits(int n)
        {
            int lastBit = -1;
            while (n != 0)
            {
                int currBit = n & 1;
                if (lastBit == currBit)
                    return false;
                lastBit = currBit;
                n >>= 1;
            }
            return true;
        }
    }
}
