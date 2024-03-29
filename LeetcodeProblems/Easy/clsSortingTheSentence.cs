﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1859. Sorting the Sentence
     * A sentence is a list of words that are separated by a single space with no leading or trailing spaces. Each word consists of lowercase and uppercase English letters.
        A sentence can be shuffled by appending the 1-indexed word position to each word then rearranging the words in the sentence.
        For example, the sentence "This is a sentence" can be shuffled as "sentence4 a3 is2 This1" or "is2 sentence4 This1 a3".
        Given a shuffled sentence s containing no more than 9 words, reconstruct and return the original sentence.

        Example 1:
        Input: s = "is2 sentence4 This1 a3"
        Output: "This is a sentence"
        Explanation: Sort the words in s to their original positions "This1 is2 a3 sentence4", then remove the numbers.

        Example 2:
        Input: s = "Myself2 Me1 I4 and3"
        Output: "Me Myself and I"
        Explanation: Sort the words in s to their original positions "Me1 Myself2 and3 I4", then remove the numbers.
 
        Constraints:
        2 <= s.length <= 200
        s consists of lowercase and uppercase English letters, spaces, and digits from 1 to 9.
        The number of words in s is between 1 and 9.
        The words in s are separated by a single space.
        s contains no leading or trailing spaces.
    */
    public class clsSortingTheSentence
    {
        public string SortSentence(string s)
        {
            int len = s.Split(' ').Length;
            string[] str = new string[len];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char curr = s[i];
                if (curr != ' ')
                {
                    if (curr - '0' >= 0 && curr - '0' <= 9)
                    {
                        str[curr - '0' - 1] = sb.ToString();
                        sb.Clear();
                    }
                    else
                        sb.Append(s[i]);
                }
            }
            return string.Join(" ", str);
            /* USING SUBSTRING
            string[] output = new string[s.Split(' ').Length];
            foreach (string str in s.Split(' '))
            {
                int index = str[str.Length - 1] - '0' - 1;
                output[index] = str.Substring(0, str.Length - 1);
            }
            return string.Join(" ", output);
            */
        }
    }
}
