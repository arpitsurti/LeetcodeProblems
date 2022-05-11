using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*1641. Count Sorted Vowel Strings
     *** REF ***
     *https://leetcode.com/problems/count-sorted-vowel-strings/discuss/918507/Java-DP-O(n)-time-Easy-to-understand
     * Given an integer n, return the number of strings of length n that consist only of vowels (a, e, i, o, u) and are lexicographically sorted.

        A string s is lexicographically sorted if for all valid i, s[i] is the same as or comes before s[i+1] in the alphabet.

        Example 1:
        Input: n = 1
        Output: 5
        Explanation: The 5 sorted strings that consist of vowels only are ["a","e","i","o","u"].

        Example 2:
        Input: n = 2
        Output: 15
        Explanation: The 15 sorted strings that consist of vowels only are
        ["aa","ae","ai","ao","au","ee","ei","eo","eu","ii","io","iu","oo","ou","uu"].
        Note that "ea" is not a valid string since 'e' comes after 'a' in the alphabet.

        Example 3:
        Input: n = 33
        Output: 66045
 
        Constraints:
        1 <= n <= 50 
    */
    public class clsCountSortedVowelStrings
    {
        public int CountVowelStrings(int n)
        {
            int aCount = 1;
            int eCount = 1;
            int iCount = 1;
            int oCount = 1;
            int uCount = 1;
            while (n > 1)
            {
                aCount = aCount + eCount + iCount + oCount + uCount;
                eCount = eCount + iCount + oCount + uCount;
                iCount = iCount + oCount + uCount;
                oCount = oCount + uCount;
                uCount = uCount;
                n--;
            }
            return aCount + eCount + iCount + oCount + uCount;
        }
    }
}
