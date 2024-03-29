﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1408. String Matching in an Array
     * Given an array of string words. Return all strings in words which is substring of another word in any order. 

        String words[i] is substring of words[j], if can be obtained removing some characters to left and/or right side of words[j].

        Example 1:
        Input: words = ["mass","as","hero","superhero"]
        Output: ["as","hero"]
        Explanation: "as" is substring of "mass" and "hero" is substring of "superhero".
        ["hero","as"] is also a valid answer.

        Example 2:
        Input: words = ["leetcode","et","code"]
        Output: ["et","code"]
        Explanation: "et", "code" are substring of "leetcode".

        Example 3:
        Input: words = ["blue","green","bu"]
        Output: []
 
        Constraints:
        1 <= words.length <= 100
        1 <= words[i].length <= 30
        words[i] contains only lowercase English letters.
        It's guaranteed that words[i] will be unique.
    */
    public class clsStringMatchingInAnArray
    {
        public IList<string> StringMatching(string[] words)
        {
            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < words.Length - 1; i++)
            {
                string currWord = words[i];
                for (int j = i + 1; j < words.Length; j++)
                {
                    string nextWord = words[j];
                    if (currWord.Contains(nextWord))
                        hs.Add(nextWord);
                    if (nextWord.Contains(currWord))
                        hs.Add(currWord);
                }
            }
            return hs.ToList();
        }
    }
}
