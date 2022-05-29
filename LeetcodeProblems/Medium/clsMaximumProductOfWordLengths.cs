using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*318. Maximum Product of Word Lengths
     * Given a string array words, return the maximum value of length(word[i]) * length(word[j]) where the two words do not share common letters. If no such two words exist, return 0.

        Example 1:
        Input: words = ["abcw","baz","foo","bar","xtfn","abcdef"]
        Output: 16
        Explanation: The two words can be "abcw", "xtfn".

        Example 2:
        Input: words = ["a","ab","abc","d","cd","bcd","abcd"]
        Output: 4
        Explanation: The two words can be "ab", "cd".

        Example 3:
        Input: words = ["a","aa","aaa","aaaa"]
        Output: 0
        Explanation: No such pair of words.
 
        Constraints:
        2 <= words.length <= 1000
        1 <= words[i].length <= 1000
        words[i] consists only of lowercase English letters.
    */
    public class clsMaximumProductOfWordLengths
    {
        public int MaxProduct(string[] words)
        {
            int currLen = 0;
            int maxLeng = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (!CheckCommonChars(words[i], words[j]))
                    {
                        currLen = words[i].Length * words[j].Length;
                        maxLeng = Math.Max(currLen, maxLeng);
                    }
                }
            }
            return maxLeng;
        }

        private bool CheckCommonChars(string str1, string str2)
        {
            int[] freq = new int[26];
            for (int i = 0; i < str1.Length; i++)
            {
                freq[str1[i] - 'a']++;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                if (freq[str2[i] - 'a'] > 0)
                    return true;
            }
            return false;
        }
    }
}
