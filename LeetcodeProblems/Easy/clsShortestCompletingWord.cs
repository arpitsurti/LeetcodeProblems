﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*748. Shortest Completing Word
     * Given a string licensePlate and an array of strings words, find the shortest completing word in words.

        A completing word is a word that contains all the letters in licensePlate. Ignore numbers and spaces in licensePlate, and treat letters as case insensitive. If a letter appears more than once in licensePlate, then it must appear in the word the same number of times or more.

        For example, if licensePlate = "aBc 12c", then it contains letters 'a', 'b' (ignoring case), and 'c' twice. Possible completing words are "abccdef", "caaacab", and "cbca".

        Return the shortest completing word in words. It is guaranteed an answer exists. If there are multiple shortest completing words, return the first one that occurs in words.

        Example 1:
        Input: licensePlate = "1s3 PSt", words = ["step","steps","stripe","stepple"]
        Output: "steps"
        Explanation: licensePlate contains letters 's', 'p', 's' (ignoring case), and 't'.
        "step" contains 't' and 'p', but only contains 1 's'.
        "steps" contains 't', 'p', and both 's' characters.
        "stripe" is missing an 's'.
        "stepple" is missing an 's'.
        Since "steps" is the only word containing all the letters, that is the answer.

        Example 2:
        Input: licensePlate = "1s3 456", words = ["looks","pest","stew","show"]
        Output: "pest"
        Explanation: licensePlate only contains the letter 's'. All the words contain 's', but among these "pest", "stew", and "show" are shortest. The answer is "pest" because it is the word that appears earliest of the 3.

        Constraints:
        1 <= licensePlate.length <= 7
        licensePlate contains digits, letters (uppercase or lowercase), or space ' '.
        1 <= words.length <= 1000
        1 <= words[i].length <= 15
        words[i] consists of lower case English letters.
    */
    public class clsShortestCompletingWord
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            int[] ch = new int[26];
            licensePlate = licensePlate.ToLower();
            for (int i = 0; i < licensePlate.Length; i++)
            {
                if ((licensePlate[i] - '0' >= 0 && licensePlate[i] - '9' <= 9)
                   || licensePlate[i] == ' ')
                    continue;
                else
                    ch[licensePlate[i] - 'a']++;
            }
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (checkOccurence(ch, words[i]) && (result == "" || words[i].Length < result.Length))
                    result = words[i];
            }
            return result;
        }

        private bool checkOccurence(int[] primary, string input)
        {
            int[] ch = new int[26];
            for (int i = 0; i < input.Length; i++)
            {
                ch[input[i] - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (ch[i] - primary[i] < 0)
                    return false;
            }
            return true;
        }
    }
}