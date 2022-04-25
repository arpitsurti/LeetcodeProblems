using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*884. Uncommon Words from Two Sentences
     * A sentence is a string of single-space separated words where each word consists only of lowercase letters.
        A word is uncommon if it appears exactly once in one of the sentences, and does not appear in the other sentence.
        Given two sentences s1 and s2, return a list of all the uncommon words. You may return the answer in any order.

        Example 1:
        Input: s1 = "this apple is sweet", s2 = "this apple is sour"
        Output: ["sweet","sour"]

        Example 2:
        Input: s1 = "apple apple", s2 = "banana"
        Output: ["banana"]

        Constraints:
        1 <= s1.length, s2.length <= 200
        s1 and s2 consist of lowercase English letters and spaces.
        s1 and s2 do not have leading or trailing spaces.
        All the words in s1 and s2 are separated by a single space.
    */
    public class clsUncommonWordsFromTwoSentences
    {
        public string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] str1 = s1.Split(' ');
            for (int i = 0; i < str1.Length; i++)
            {
                if (!dict.ContainsKey(str1[i]))
                    dict.Add(str1[i], 0);
                dict[str1[i]]++;
            }
            List<string> lstResult = new List<string>();
            str1 = s2.Split(' ');
            for (int i = 0; i < str1.Length; i++)
            {
                if (!dict.ContainsKey(str1[i]))
                    dict.Add(str1[i], 0);
                dict[str1[i]]++;
            }
            foreach (var item in dict)
            {
                if (item.Value == 1)
                    lstResult.Add(item.Key);
            }
            return lstResult.ToArray();
        }
    }
}
