using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*5. Longest Palindromic Substring
     *** REF ***
     *** VERY IMP ***
     *https://www.youtube.com/watch?v=y2BD4MJqV20&t=695s
     * Given a string s, return the longest palindromic substring in s.

        Example 1:
        Input: s = "babad"
        Output: "bab"
        Explanation: "aba" is also a valid answer.

        Example 2:
        Input: s = "cbbd"
        Output: "bb"

        Constraints:
        1 <= s.length <= 1000
        s consist of only digits and English letters.
    */
    public class clsLongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int start = 0;
            int longest = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // type 1: with one center
                int l1 = expandFromMiddle(s, i, i);
                // type 2: with two centers
                int l2 = expandFromMiddle(s, i, i + 1);
                int len = Math.Max(l1, l2);
                if (len > longest)
                {
                    start = i - (len - 1) / 2;
                    longest = len;
                }
            }
            return s.Substring(start, longest);
        }

        private int expandFromMiddle(string s, int left, int right)
        {
            if (s == null || left > right)
                return 0;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}
