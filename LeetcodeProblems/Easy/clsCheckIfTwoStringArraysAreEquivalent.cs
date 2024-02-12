using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1662. Check If Two String Arrays are Equivalent
     * Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
        A string is represented by an array if the array elements concatenated in order forms the string.

        Example 1:
        Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
        Output: true
        Explanation:
        word1 represents string "ab" + "c" -> "abc"
        word2 represents string "a" + "bc" -> "abc"
        The strings are the same, so return true.

        Example 2:
        Input: word1 = ["a", "cb"], word2 = ["ab", "c"]
        Output: false

        Example 3:
        Input: word1  = ["abc", "d", "defg"], word2 = ["abcddefg"]
        Output: true

        Constraints:
        1 <= word1.length, word2.length <= 103
        1 <= word1[i].length, word2[i].length <= 103
        1 <= sum(word1[i].length), sum(word2[i].length) <= 103
        word1[i] and word2[i] consist of lowercase letters.
    */
    public class clsCheckIfTwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < word1.Length; i++)
            {
                sb1.Append(word1[i]);
            }
            for (int i = 0; i < word2.Length; i++)
            {
                sb2.Append(word2[i]);
            }
            return sb1.ToString() == sb2.ToString();

            //OR
            //return string.Join("", word1) == string.Join("", word2);
        }
    }
}
