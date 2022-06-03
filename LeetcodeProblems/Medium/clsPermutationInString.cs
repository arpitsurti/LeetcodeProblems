using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*567. Permutation in String
     * Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.

        In other words, return true if one of s1's permutations is the substring of s2.

        Example 1:
        Input: s1 = "ab", s2 = "eidbaooo"
        Output: true
        Explanation: s2 contains one permutation of s1 ("ba").

        Example 2:
        Input: s1 = "ab", s2 = "eidboaoo"
        Output: false
 
        Constraints:
        1 <= s1.length, s2.length <= 104
        s1 and s2 consist of lowercase English letters.
    */
    public class clsPermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int[] s1Map = new int[26];
            for (int i = 0; i < s1.Length; i++)
                s1Map[s1[i] - 'a']++;
            for (int i = 0; i < s2.Length - s1.Length + 1; i++)
            {
                int left = i;
                int right = left + s1.Length;
                int[] s2Map = new int[26];
                while (left < right)
                {
                    s2Map[s2[left] - 'a']++;
                    left++;
                }
                if (matches(s1Map, s2Map))
                    return true;
            }
            return false;
        }

        private bool matches(int[] map1, int[] map2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (map1[i] != map2[i])
                    return false;
            }
            return true;
        }
    }
}
