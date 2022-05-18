using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*680. Valid Palindrome II
     *** REF ***
     * Given a string s, return true if the s can be palindrome after deleting at most one character from it.

        Example 1:
        Input: s = "aba"
        Output: true

        Example 2:
        Input: s = "abca"
        Output: true
        Explanation: You could delete the character 'c'.

        Example 3:
        Input: s = "abc"
        Output: false

        Constraints:
        1 <= s.length <= 105
        s consists of lowercase English letters.
    */
    public class clsValidPalindromeII
    {
        public bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                    return (ValidPalindrome(s, left, right - 1) || ValidPalindrome(s, left + 1, right));
                left++;
                right--;
            }
            return true;
        }

        private bool ValidPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
