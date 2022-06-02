using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /* 438. Find All Anagrams in a String
     * Given two strings s and p, return an array of all the start indices of p's anagrams in s. You may return the answer in any order.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        Example 1:
        Input: s = "cbaebabacd", p = "abc"
        Output: [0,6]
        Explanation:
        The substring with start index = 0 is "cba", which is an anagram of "abc".
        The substring with start index = 6 is "bac", which is an anagram of "abc".

        Example 2:
        Input: s = "abab", p = "ab"
        Output: [0,1,2]
        Explanation:
        The substring with start index = 0 is "ab", which is an anagram of "ab".
        The substring with start index = 1 is "ba", which is an anagram of "ab".
        The substring with start index = 2 is "ab", which is an anagram of "ab".
 
        Constraints:
        1 <= s.length, p.length <= 3 * 104
        s and p consist of lowercase English letters.
    */
    public class clsFindAllAnagramsInAString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> lstResult = new List<int>();
            if (p.Length > s.Length)
                return lstResult;
            int[] pArr = new int[26];
            for (int i = 0; i < p.Length; i++)
            {
                pArr[p[i] - 'a']++;
            }
            for (int i = 0; i < s.Length - p.Length + 1; i++)
            {
                bool flgFound = true;
                int[] sArr = new int[26];
                pArr.CopyTo(sArr, 0);
                string newStr = s.Substring(i, p.Length);
                for (int j = 0; j < newStr.Length; j++)
                {
                    sArr[newStr[j] - 'a']--;
                }
                for (int j = 0; j < 26; j++)
                {
                    if (sArr[j] != 0)
                    {
                        flgFound = false;
                        break;
                    }
                }
                if (flgFound)
                    lstResult.Add(i);
            }
            return lstResult;
        }
    }
}
