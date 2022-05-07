using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*49. Group Anagrams
     * Given an array of strings strs, group the anagrams together. You can return the answer in any order.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        Example 1:
        Input: strs = ["eat","tea","tan","ate","nat","bat"]
        Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    
        Example 2:
        Input: strs = [""]
        Output: [[""]]
        
        Example 3:
        Input: strs = ["a"]
        Output: [["a"]]
 
        Constraints:

        1 <= strs.length <= 104
        0 <= strs[i].length <= 100
        strs[i] consists of lowercase English letters.
    */
    public class clsGroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            IList<IList<string>> lstResult = new List<IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] chSorted = strs[i].ToCharArray();
                Array.Sort(chSorted);
                string sorted = new string(chSorted);
                if (!dict.ContainsKey(sorted))
                    dict.Add(sorted, new List<string>());
                dict[sorted].Add(strs[i]);
            }
            foreach (var item in dict)
            {
                lstResult.Add(item.Value);
            }
            return lstResult;
        }
    }
}
