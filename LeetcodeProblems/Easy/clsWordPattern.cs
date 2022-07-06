using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*290. Word Pattern
     * Given a pattern and a string s, find if s follows the same pattern.
        Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

        Example 1:
        Input: pattern = "abba", s = "dog cat cat dog"
        Output: true

        Example 2:
        Input: pattern = "abba", s = "dog cat cat fish"
        Output: false

        Example 3:
        Input: pattern = "aaaa", s = "dog cat cat dog"
        Output: false
 
        Constraints:
        1 <= pattern.length <= 300
        pattern contains only lower-case English letters.
        1 <= s.length <= 3000
        s contains only lowercase English letters and spaces ' '.
        s does not contain any leading or trailing spaces.
        All the words in s are separated by a single space.
    */
    public class clsWordPattern
    {
        //Approach 1 (Using HashMap)
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            string[] inputArray = s.Split(' ');
            int n = inputArray.Length;
            if (n != pattern.Length)
                return false;
            for (int i = 0; i < n; i++)
            {
                if (!dict.ContainsKey(pattern[i]) && !dict.ContainsValue(inputArray[i]))
                    dict.Add(pattern[i], inputArray[i]);
                else if (dict.ContainsKey(pattern[i]) && dict[pattern[i]] != inputArray[i])
                    return false;
                else if (!dict.ContainsKey(pattern[i]) && dict.ContainsValue(inputArray[i]))
                    return false;
            }
            return true;
        }

        /*Approach 2 (Using string array as map)
        public bool WordPattern(string pattern, string s)
        {
            string[] inputArray = s.Split(' ');
            int n = inputArray.Length;
            if (n != pattern.Length)
                return false;
            string[] map = new string[26];
            for (int i = 0; i < n; i++)
            {
                int index = pattern[i] - 'a';
                if (!CheckValues(map, inputArray[i], index))
                    return false;
                if (map[index] != null && map[index] != inputArray[i])
                    return false;
                else
                    map[index] = inputArray[i];
            }
            return true;
        }

        private bool CheckValues(string[] map, string val, int index)
        {
            for (int i = 0; i < 26; i++)
            {
                if (i != index && map[i] == val)
                    return false;
            }
            return true;
        }
        */
}
}
