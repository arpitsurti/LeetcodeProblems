using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*14. Longest Common Prefix
     *** VERY IMP ***
     //https://www.youtube.com/watch?v=bl8ue-dTxgs
     * Write a function to find the longest common prefix string amongst an array of strings.
        If there is no common prefix, return an empty string "".

        Example 1:
        Input: strs = ["flower","flow","flight"]
        Output: "fl"

        Example 2:
        Input: strs = ["dog","racecar","car"]
        Output: ""
        Explanation: There is no common prefix among the input strings.

        Constraints:
        1 <= strs.length <= 200
        0 <= strs[i].length <= 200
        strs[i] consists of only lower-case English letters.
    */
    public class clsLongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            /* APPROACH 1
             * string result = strs[0];
                for(int i = 1; i < strs.Length; i++)
                {
                    int j = 0;
                    while(j < result.Length && j < strs[i].Length)
                    {
                        if(result[j] != strs[i][j])
                            break;
                        j++;
                    }
                    result = strs[i].Substring(0, j);
                }
                return result;
            */
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }
    }
}
