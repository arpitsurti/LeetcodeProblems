using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1624. Largest Substring Between Two Equal Characters
     *Given a string s, return the length of the longest substring between two equal characters, excluding the two characters. If there is no such substring return -1.

        A substring is a contiguous sequence of characters within a string.

        Example 1:
        Input: s = "aa"
        Output: 0
        Explanation: The optimal substring here is an empty substring between the two 'a's.

        Example 2:
        Input: s = "abca"
        Output: 2
        Explanation: The optimal substring here is "bc".

        Example 3:
        Input: s = "cbzxy"
        Output: -1
        Explanation: There are no characters that appear twice in s.

        Constraints:
        1 <= s.length <= 300
        s contains only lowercase English letters.
    */
    public class clsLargestSubstringBetweenTwoEqualCharacters
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
            int output = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], new List<int>());
                dict[s[i]].Add(i);
                if (dict[s[i]].Count > 1)
                {
                    int length = dict[s[i]].Count - 1;
                    output = Math.Max(output, dict[s[i]][length] - dict[s[i]][0] - 1);
                }
            }
            return output;
        }
    }
}
