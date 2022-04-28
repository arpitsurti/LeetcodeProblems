using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1446. Consecutive Characters
     * The power of the string is the maximum length of a non-empty substring that contains only one unique character.

        Given a string s, return the power of s.

        Example 1:
        Input: s = "leetcode"
        Output: 2
        Explanation: The substring "ee" is of length 2 with the character 'e' only.

        Example 2:
        Input: s = "abbcccddddeeeeedcba"
        Output: 5
        Explanation: The substring "eeeee" is of length 5 with the character 'e' only.
 
        Constraints:
        1 <= s.length <= 500
        s consists of only lowercase English letters.
    */
    public class clsConsecutiveCharacters
    {
        public int MaxPower(string s)
        {
            int currMax = 1;
            int max = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    currMax++;
                else
                    currMax = 1;
                max = Math.Max(max, currMax);
            }
            return Math.Max(max, currMax);
        }
    }
}
