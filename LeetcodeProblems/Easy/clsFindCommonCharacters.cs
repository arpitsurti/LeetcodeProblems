using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1002. Find Common Characters
     *** REF IMP ***
     * Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). You may return the answer in any order.

        Example 1:
        Input: words = ["bella","label","roller"]
        Output: ["e","l","l"]

        Example 2:
        Input: words = ["cool","lock","cook"]
        Output: ["c","o"]

        Constraints:
        1 <= words.length <= 100
        1 <= words[i].length <= 100
        words[i] consists of lowercase English letters.
    */
    public class clsFindCommonCharacters
    {
        public IList<string> CommonChars(string[] words)
        {
            IList<string> lstResult = new List<string>();
            int[] minFreq = new int[26];
            for (int i = 0; i < 26; i++)
            {
                minFreq[i] = int.MaxValue;
            }
            for (int i = 0; i < words.Length; i++)
            {
                int[] countFreq = new int[26];
                foreach (var c in words[i])
                {
                    countFreq[c - 'a']++;
                }
                for (int t = 0; t < 26; t++)
                {
                    minFreq[t] = Math.Min(countFreq[t], minFreq[t]);
                }
            }
            for (int i = 0; i < 26; i++)
            {
                while (minFreq[i] != 0)
                {
                    lstResult.Add("" + (char)(i + 'a'));
                    minFreq[i]--;
                }
            }
            return lstResult;
        }
    }
}
