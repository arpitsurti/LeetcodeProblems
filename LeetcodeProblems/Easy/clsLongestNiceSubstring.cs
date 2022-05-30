using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1763. Longest Nice Substring
     *** REF ***
     * A string s is nice if, for every letter of the alphabet that s contains, it appears both in uppercase and lowercase. For example, "abABB" is nice because 'A' and 'a' appear, and 'B' and 'b' appear. However, "abA" is not because 'b' appears, but 'B' does not.

        Given a string s, return the longest substring of s that is nice. If there are multiple, return the substring of the earliest occurrence. If there are none, return an empty string.

        Example 1:
        Input: s = "YazaAay"
        Output: "aAa"
        Explanation: "aAa" is a nice string because 'A/a' is the only letter of the alphabet in s, and both 'A' and 'a' appear.
        "aAa" is the longest nice substring.

        Example 2:
        Input: s = "Bb"
        Output: "Bb"
        Explanation: "Bb" is a nice string because both 'B' and 'b' appear. The whole string is a substring.

        Example 3:
        Input: s = "c"
        Output: ""
        Explanation: There are no nice substrings.
 
        Constraints:
        1 <= s.length <= 100
        s consists of uppercase and lowercase English letters.
    */
    public class clsLongestNiceSubstring
    {
        public string LongestNiceSubstring(string s)
        {
            int index = isNotNiceSubstring(s);

            if (index == -1)
                return s;
            string left = LongestNiceSubstring(s.Substring(0, index));
            string right = LongestNiceSubstring(s.Substring(index + 1));
            return left.Length >= right.Length ? left : right;
        }

        private int isNotNiceSubstring(string s)
        {
            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                hs.Add(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (hs.Contains(Char.ToUpper(s[i])) && hs.Contains(Char.ToLower(s[i])))
                    continue;
                else
                    return i;
            }
            return -1;
        }
    }
}
