using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*2085. Count Common Words With One Occurrence
     * Given two string arrays words1 and words2, return the number of strings that appear exactly once in each of the two arrays.

        Example 1:
        Input: words1 = ["leetcode","is","amazing","as","is"], words2 = ["amazing","leetcode","is"]
        Output: 2
        Explanation:
        - "leetcode" appears exactly once in each of the two arrays. We count this string.
        - "amazing" appears exactly once in each of the two arrays. We count this string.
        - "is" appears in each of the two arrays, but there are 2 occurrences of it in words1. We do not count this string.
        - "as" appears once in words1, but does not appear in words2. We do not count this string.
        Thus, there are 2 strings that appear exactly once in each of the two arrays.

        Example 2:
        Input: words1 = ["b","bb","bbb"], words2 = ["a","aa","aaa"]
        Output: 0
        Explanation: There are no strings that appear in each of the two arrays.

        Example 3:
        Input: words1 = ["a","ab"], words2 = ["a","a","a","ab"]
        Output: 1
        Explanation: The only string that appears exactly once in each of the two arrays is "ab".
 
        Constraints:
        1 <= words1.length, words2.length <= 1000
        1 <= words1[i].length, words2[j].length <= 30
        words1[i] and words2[j] consists only of lowercase English letters.
    */
    public class clsCountCommonWordsWithOneOccurrence
    {
        public int CountWords(string[] words1, string[] words2)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            int output = 0;
            for (int i = 0; i < words1.Length; i++)
            {
                if (!dict.ContainsKey(words1[i]))
                    dict.Add(words1[i], 1);
                else
                    dict[words1[i]]++;
            }

            for (int i = 0; i < words2.Length; i++)
            {
                if (!dict1.ContainsKey(words2[i]))
                    dict1.Add(words2[i], 1);
                else
                    dict1[words2[i]]++;
            }

            foreach (var item in dict)
            {
                if (item.Value == 1 && dict1.ContainsKey(item.Key) && dict1[item.Key] == 1)
                    output++;
            }
            return output;
        }
    }
}
