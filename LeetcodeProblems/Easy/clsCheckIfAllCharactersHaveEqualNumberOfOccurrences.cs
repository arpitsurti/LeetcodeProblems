using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1941. Check if All Characters Have Equal Number of Occurrences
     * Given a string s, return true if s is a good string, or false otherwise.
        A string s is good if all the characters that appear in s have the same number of occurrences (i.e., the same frequency).

        Example 1:
        Input: s = "abacbc"
        Output: true
        Explanation: The characters that appear in s are 'a', 'b', and 'c'. All characters occur 2 times in s.

        Example 2:
        Input: s = "aaabb"
        Output: false
        Explanation: The characters that appear in s are 'a' and 'b'.
        'a' occurs 3 times while 'b' occurs 2 times, which is not the same number of times.
 
        Constraints:
        1 <= s.length <= 1000
        s consists of lowercase English letters.
    */
    public class clsCheckIfAllCharactersHaveEqualNumberOfOccurrences
    {
        public bool AreOccurrencesEqual(string s)
        {
            int[] iArr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                iArr[s[i] - 'a']++;
            }
            int lastNum = iArr[s[0] - 'a'];
            for (int i = 0; i < 26; i++)
            {
                if (iArr[i] > 0 && iArr[i] != lastNum)
                    return false;
            }
            return true;
        }

        /*ALTERNATE SOLUTION WITH DICTIONARY
        public bool AreOccurrencesEqual(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 1);
                else
                    dict[s[i]]++;
            }
            int lastValue = dict[s[0]];
            foreach (var item in dict.Values)
            {
                if (lastValue != item)
                    return false;
            }
            return true;
        }
        */
    }
}
