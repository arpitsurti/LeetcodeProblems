using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*792. Number of Matching Subsequences
     *** REF ***
     *https://leetcode.com/problems/number-of-matching-subsequences/discuss/2100473/Java-HashMap-Next-letter-pointers-technique-with-explanation
     * Given a string s and an array of strings words, return the number of words[i] that is a subsequence of s.
        A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.
        For example, "ace" is a subsequence of "abcde".
 
        Example 1:
        Input: s = "abcde", words = ["a","bb","acd","ace"]
        Output: 3
        Explanation: There are three strings in words that are a subsequence of s: "a", "acd", "ace".
        
        Example 2:
        Input: s = "dsahjpjauf", words = ["ahjpjau","ja","ahbwzgqnuk","tnmlanowax"]
        Output: 2
 
        Constraints:
        1 <= s.length <= 5 * 104
        1 <= words.length <= 5000
        1 <= words[i].length <= 50
        s and words[i] consist of only lowercase English letters.
    */
    public class clsNumberOfMatchingSubsequences
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            int result = 0;
            Dictionary<char, List<string>> dict = new Dictionary<char, List<string>>();
            for (int i = 0; i < words.Length; i++)
            {
                addWordInMap(words[i], dict);
            }
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (dict.ContainsKey(ch))
                {
                    List<string> tmp = dict[ch];
                    dict.Remove(ch);
                    foreach (var item in tmp)
                    {
                        if (item.Length <= 1)
                            result++;
                        else
                            addWordInMap(item.Substring(1), dict);
                    }
                }
            }
            return result;
        }

        private void addWordInMap(string s, Dictionary<char, List<string>> dict)
        {
            if (!dict.ContainsKey(s[0]))
                dict.Add(s[0], new List<string>());
            dict[s[0]].Add(s);
        }
        /*O(n^2) solution
        public int NumMatchingSubseq(string s, string[] words)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (isSubsequence(words[i], s))
                    count++;
            }
            return count;
        }

        private bool isSubsequence(string s1, string s2)
        {
            int s1Pointer = 0;
            int s2Pointer = 0;
            while (s2Pointer < s2.Length && s1Pointer < s1.Length)
            {
                if (s1[s1Pointer] == s2[s2Pointer])
                    s1Pointer++;
                s2Pointer++;
            }
            return s1Pointer == s1.Length;
        }
        */
    }
}
