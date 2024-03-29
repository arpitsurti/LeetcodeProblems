﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    public class clsDecryptStringFromAlphabetToIntegerMapping
    {
        /*1309. Decrypt String from Alphabet to Integer Mapping
         * You are given a string s formed by digits and '#'. We want to map s to English lowercase characters as follows:
            Characters ('a' to 'i') are represented by ('1' to '9') respectively.
            Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.
            Return the string formed after mapping.

            The test cases are generated so that a unique mapping will always exist.

            Example 1:
            Input: s = "10#11#12"
            Output: "jkab"
            Explanation: "j" -> "10#" , "k" -> "11#" , "a" -> "1" , "b" -> "2".

            Example 2:
            Input: s = "1326#"
            Output: "acz"
 
            Constraints:
            1 <= s.length <= 1000
            s consists of digits and the '#' letter.
            s will be a valid string such that mapping is always possible.
        */
        public string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if ((i + 2) < s.Length && s[i + 2] == '#')
                {
                    sb.Append(helper(s[i].ToString() + "" + s[i + 1].ToString()));
                    i = i + 2;
                }
                else
                    sb.Append((char)('a' + ((s[i] - '0') - 1)));
            }
            return sb.ToString();
        }

        private char helper(string input)
        {
            int val = ((input[0] - '0') * 10) + (input[1] - '0') - 1;
            return (char)('a' + val);
        }
    }
}
