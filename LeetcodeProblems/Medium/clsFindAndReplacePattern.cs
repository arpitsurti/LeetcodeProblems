using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*890. Find and Replace Pattern
     * Given a list of strings words and a string pattern, return a list of words[i] that match pattern. You may return the answer in any order.

        A word matches the pattern if there exists a permutation of letters p so that after replacing every letter x in the pattern with p(x), we get the desired word.

        Recall that a permutation of letters is a bijection from letters to letters: every letter maps to another letter, and no two letters map to the same letter.

        Example 1:
        Input: words = ["abc","deq","mee","aqq","dkd","ccc"], pattern = "abb"
        Output: ["mee","aqq"]
        Explanation: "mee" matches the pattern because there is a permutation {a -> m, b -> e, ...}. 
        "ccc" does not match the pattern because {a -> c, b -> c, ...} is not a permutation, since a and b map to the same letter.

        Example 2:
        Input: words = ["a","b","c"], pattern = "a"
        Output: ["a","b","c"]

        Constraints:
        1 <= pattern.length <= 20
        1 <= words.length <= 50
        words[i].length == pattern.length
        pattern and words[i] are lowercase English letters.
     */
    public class clsFindAndReplacePattern
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            IList<string> lstResult = new List<string>();
            foreach (string word in words)
            {
                if (IsMatch(word, pattern))
                {
                    lstResult.Add(word);
                }
            }
            return lstResult;
        }

        private bool IsMatch(string word, string pattern)
        {
            if (word.Length != pattern.Length)
                return false;
            Dictionary<char, char> dict = new Dictionary<char, char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (dict.ContainsKey(word[i]) && dict[word[i]] != pattern[i])
                    return false;
                else if (!dict.ContainsKey(word[i]) && dict.ContainsValue(pattern[i]))
                    return false;
                else if (!dict.ContainsKey(word[i]) && !dict.ContainsValue(pattern[i]))
                    dict.Add(word[i], pattern[i]);
                else
                    continue;
            }
            return true;
        }
    }
}
