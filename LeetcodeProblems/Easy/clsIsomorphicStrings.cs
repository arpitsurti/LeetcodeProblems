using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*205. Isomorphic Strings
     *** REF ***
     * Given two strings s and t, determine if they are isomorphic.

        Two strings s and t are isomorphic if the characters in s can be replaced to get t.

        All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

        Example 1:
        Input: s = "egg", t = "add"
        Output: true

        Example 2:
        Input: s = "foo", t = "bar"
        Output: false

        Example 3:
        Input: s = "paper", t = "title"
        Output: true
 
        Constraints:
        1 <= s.length <= 5 * 104
        t.length == s.length
        s and t consist of any valid ascii character.
    */
    public class clsIsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]) && dict[s[i]] != t[i])
                    return false;
                else if (!dict.ContainsKey(s[i]) && dict.ContainsValue(t[i]))
                    return false;
                else if (!dict.ContainsKey(s[i]) && !dict.ContainsValue(t[i]))
                    dict.Add(s[i], t[i]);
            }
            return true;
        }
    }
}
