using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*242. Valid Anagram
     * Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        Example 1:
        Input: s = "anagram", t = "nagaram"
        Output: true

        Example 2:
        Input: s = "rat", t = "car"
        Output: false

        Constraints:
        1 <= s.length, t.length <= 5 * 104
        s and t consist of lowercase English letters.
 
        Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
    */
    public class clsValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            //APROACH 1 USING ARRAY COUNT
            if (s.Length != t.Length)
                return false;
            int[] charCount = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                charCount[c - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                char c = t[i];
                charCount[c - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (charCount[i] > 0)
                    return false;
            }
            return true;
            /*
            APPROACH 2 USING DICTIONARY
            if (s.Length != t.Length)
                return false;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 0);
                dict[s[i]]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!dict.ContainsKey(t[i]))
                    return false;
                dict[t[i]]--;
                if (dict[t[i]] < 0)
                    return false;
            }
            return true;

            */
        }
    }
}
