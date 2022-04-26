using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*125. Valid Palindrome
     * A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

        Given a string s, return true if it is a palindrome, or false otherwise.

        Example 1:
        Input: s = "A man, a plan, a canal: Panama"
        Output: true
        Explanation: "amanaplanacanalpanama" is a palindrome.

        Example 2:
        Input: s = "race a car"
        Output: false
        Explanation: "raceacar" is not a palindrome.

        Example 3:
        Input: s = " "
        Output: true
        Explanation: s is an empty string "" after removing non-alphanumeric characters.
        Since an empty string reads the same forward and backward, it is a palindrome.

        Constraints:
        1 <= s.length <= 2 * 105
        s consists only of printable ASCII characters.
    */
    public class clsValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                bool flgLeft = false;
                bool flgRight = false;
                if (!((s[left] >= 'a' && s[left] <= 'z') ||
                   (s[left] >= 'A' && s[left] <= 'Z') ||
                   (s[left] - '0' >= 0 && s[left] - '0' <= 9)))
                    left++;
                else
                    flgLeft = true;
                if (!((s[right] >= 'a' && s[right] <= 'z') ||
                   (s[right] >= 'A' && s[right] <= 'Z') ||
                   (s[right] - '0' >= 0 && s[right] - '0' <= 9)))
                    right--;
                else
                    flgRight = true;
                if (flgLeft && flgRight)
                {
                    if ((s[left] + "").ToLower() != (s[right] + "").ToLower())
                        return false;
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}
