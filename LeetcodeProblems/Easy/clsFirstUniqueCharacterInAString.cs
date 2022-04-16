using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*387. First Unique Character in a String
     * Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

        Example 1:
        Input: s = "leetcode"
        Output: 0

        Example 2:
        Input: s = "loveleetcode"
        Output: 2

        Example 3:
        Input: s = "aabb"
        Output: -1
 
        Constraints:
        1 <= s.length <= 105
        s consists of only lowercase English letters.
    */
    public class clsFirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 1);
                else
                    dict[s[i]]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }
}
