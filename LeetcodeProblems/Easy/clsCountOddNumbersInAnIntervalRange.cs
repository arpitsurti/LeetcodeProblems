using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1523. Count Odd Numbers in an Interval Range
     *** REF ***
     * Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).

        Example 1:
        Input: low = 3, high = 7
        Output: 3
        Explanation: The odd numbers between 3 and 7 are [3,5,7].

        Example 2:
        Input: low = 8, high = 10
        Output: 1
        Explanation: The odd numbers between 8 and 10 are [9].
 
        Constraints:
        0 <= low <= high <= 10^9
    */
    public class clsCountOddNumbersInAnIntervalRange
    {
        //BIT MANIPULATION
        public int CountOdds(int low, int high)
        {
            if ((low & 1) == 0 && (high & 1) == 0)
                return (high - low) >> 1;
            return ((high - low) >> 1) + 1;
        }
        /*Number calculation
        public int CountOdds(int low, int high)
        {
            if (low % 2 == 0 && high % 2 == 0)
                return (high - low) / 2;
            else
                return ((high - low) / 2) + 1;
        }
        */
    }
}
