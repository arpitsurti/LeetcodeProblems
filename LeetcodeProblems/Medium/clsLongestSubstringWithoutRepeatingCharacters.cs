using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*3. Longest Substring Without Repeating Characters
        *** REF ***
        //https://www.youtube.com/watch?v=3IETreEybaA&t=393s
        Given a string s, find the length of the longest substring without repeating characters.

        Example 1:
        Input: s = "abcabcbb"
        Output: 3
        Explanation: The answer is "abc", with the length of 3.

        Example 2:
        Input: s = "bbbbb"
        Output: 1
        Explanation: The answer is "b", with the length of 1.

        Example 3:
        Input: s = "pwwkew"
        Output: 3
        Explanation: The answer is "wke", with the length of 3.
        Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 
        Constraints:
        0 <= s.length <= 5 * 104
        s consists of English letters, digits, symbols and spaces.
    */
    public class clsLongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> hs = new HashSet<char>();
            int maxLength = 0;
            int pointer1 = 0;
            int pointer2 = 0;
            while (pointer2 < s.Length)
            {
                if (!hs.Contains(s[pointer2]))
                {
                    hs.Add(s[pointer2]);
                    pointer2++;
                    maxLength = Math.Max(maxLength, hs.Count);
                }
                else
                {
                    hs.Remove(s[pointer1]);
                    pointer1++;
                }
            }
            return maxLength;
        }
    }
}
