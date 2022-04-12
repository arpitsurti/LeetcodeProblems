using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*2124. Check if All A's Appears Before All B's
     * Given a string s consisting of only the characters 'a' and 'b', return true if every 'a' appears before every 'b' in the string. Otherwise, return false.

        Example 1:
        Input: s = "aaabbb"
        Output: true
        Explanation:
        The 'a's are at indices 0, 1, and 2, while the 'b's are at indices 3, 4, and 5.
        Hence, every 'a' appears before every 'b' and we return true.

        Example 2:
        Input: s = "abab"
        Output: false
        Explanation:
        There is an 'a' at index 2 and a 'b' at index 1.
        Hence, not every 'a' appears before every 'b' and we return false.
        
        Example 3:
        Input: s = "bbb"
        Output: true
        Explanation:
        There are no 'a's, hence, every 'a' appears before every 'b' and we return true.

        Constraints:
        1 <= s.length <= 100
        s[i] is either 'a' or 'b'.
    */
    public class clsCheckIfAllA_sAppearsBeforeAllB_s
    {
        public bool CheckString(string s)
        {
            int lastIndexA = -1;
            int lastIndexB = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                    lastIndexA = i;
                if (s[i] == 'b' && lastIndexB == -1)
                    lastIndexB = i;
            }
            return lastIndexA == -1 || lastIndexB == -1 || lastIndexA < lastIndexB;
        }
    }
}
